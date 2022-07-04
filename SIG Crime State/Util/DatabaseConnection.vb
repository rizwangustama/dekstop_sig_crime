Imports System.IO
Imports MySql.Data.MySqlClient
Public Class DatabaseConnection

    Dim MySQL_Connection As New MySqlConnection

    Dim resultDs As SigDataSet
    Dim resultStatus As ResultCode
    Dim resultMessage As String = ""

    Public objectSender As Object
    Public tableName As String
    Public Property Query As String = ""

    Public WithUpload As Boolean = False
    Public UploadUrl As String = ""
    Public UploadFile As String = ""

    Public Function Connect_Server() As String
        Connect_Server = "server=" & host & ";" & "userid=" & uid & ";" & "password=" & pwd & "; default command timeout=1800; " & "database=" & db & "; Convert Zero Datetime=True;"
        Return Connect_Server
    End Function

    Private Sub DatabaseConnection_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        
    End Sub

    Private Sub DatabaseConnection_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MySQL_Connection = New MySqlConnection(Connect_Server)
        Me.resultDs = New SigDataSet
        Control.CheckForIllegalCrossThreadCalls = False
        MetroProgressSpinner1.Visible = True
        Me.ControlBox = False
        Label2.Text = "Checking progress"
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            If WithUpload = True Then
                Label2.Text += vbNewLine & "Uploading file to server ...."
                Dim filepath As String = Me.UploadFile
                Dim url As String = UploadUrl

                Dim boundary As String = IO.Path.GetRandomFileName
                Dim header As New System.Text.StringBuilder()
                header.AppendLine("--" & boundary)
                header.Append("Content-Disposition: form-data; name=""file"";")
                header.AppendFormat("filename=""{0}""", IO.Path.GetFileName(filepath))
                header.AppendLine()
                header.AppendLine("Content-Type: application/octet-stream")
                header.AppendLine()

                Dim headerbytes() As Byte = System.Text.Encoding.UTF8.GetBytes(header.ToString)
                Dim endboundarybytes() As Byte = System.Text.Encoding.ASCII.GetBytes(vbNewLine & "--" & boundary & "--" & vbNewLine)

                Dim req As Net.HttpWebRequest = Net.HttpWebRequest.Create(url)
                req.ContentType = "multipart/form-data; boundary=" & boundary
                req.ContentLength = headerbytes.Length + New IO.FileInfo(filepath).Length + endboundarybytes.Length
                req.Method = "POST"

                Dim s As IO.Stream = req.GetRequestStream
                s.Write(headerbytes, 0, headerbytes.Length)
                Dim filebytes() As Byte = My.Computer.FileSystem.ReadAllBytes(filepath)
                s.Write(filebytes, 0, filebytes.Length)
                s.Write(endboundarybytes, 0, endboundarybytes.Length)
                s.Close()

                'Get the responds of these request
                Dim resp As Net.HttpWebResponse = req.GetResponse()
                Dim sresp As IO.Stream = resp.GetResponseStream()
                Dim bytes(80000) As Byte
                sresp.Read(bytes, 0, 80000)
                Dim stringResponse As String = System.Text.Encoding.ASCII.GetChars(bytes)
                Label2.Text = System.Text.Encoding.ASCII.GetChars(bytes)

                'Connecto database
                Label1.Text += vbNewLine & "Connecting to database ....."
                MySQL_Connection.Open()
                If MySQL_Connection.State = ConnectionState.Open Then
                    resultStatus = ResultCode.Success
                    resultMessage = "Connection Success"
                End If
            End If

            If WithUpload = False Then
                Label1.Text += vbNewLine & "Connecting to database ....."
                MySQL_Connection.Open()
                If MySQL_Connection.State = ConnectionState.Open Then
                    resultStatus = ResultCode.Success
                    resultMessage = "Connection Success"
                End If
            End If
        Catch ex As Exception
            resultStatus = ResultCode.Failed
            resultMessage = "Error Code Connection" & Err.Number & vbNewLine & ex.Message
            If BackgroundWorker1.IsBusy Then
                BackgroundWorker1.CancelAsync()
            End If
        Finally
            Label2.Text += vbNewLine & resultMessage
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If resultStatus = ResultCode.Success Then
            MetroProgressSpinner1.Visible = False
            BackgroundWorker2.RunWorkerAsync()
            resultDs.Clear()
            resultDs = New SigDataSet
        Else
            MetroProgressSpinner1.Visible = False
            Me.ControlBox = True
        End If
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Label1.Text += vbNewLine & "Executing query command ....."
        Dim MySQL_Command As New MySqlCommand
        Dim MySQL_Adapter As New MySqlDataAdapter
        Try
            MySQL_Command.CommandText = Query
            MySQL_Command.Connection = MySQL_Connection
            MySQL_Adapter = New MySqlDataAdapter(MySQL_Command)
            MySQL_Adapter.Fill(resultDs, tableName)
            resultStatus = ResultCode.Success
            resultMessage = "Success executing command"
        Catch ex As Exception
            resultStatus = ResultCode.Failed
            resultMessage = "Error Code executing command " & Err.Number & vbNewLine & ex.Message
            MsgBox(ex.Message.ToString)
            If BackgroundWorker2.IsBusy Then
                BackgroundWorker2.CancelAsync()
            End If
        Finally
            MySQL_Command = Nothing
            MySQL_Adapter = Nothing
            If MySQL_Connection.State = ConnectionState.Open Then MySQL_Connection.Close()
            Label2.Text += vbNewLine & resultMessage
        End Try

    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        If resultStatus = ResultCode.Failed Then
            MetroProgressSpinner1.Visible = False
            Me.ControlBox = True
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MetroProgressSpinner1.Visible = False
            Me.Close()
            Me.DialogResult = Windows.Forms.DialogResult.Abort
            ' CHECK FORM / CONTROL FOR RETRIVE INTERFACE
            'If objectSender.GetType.Name = Dashboard.Name Then
            '    With CType(objectSender, Dashboard)
            '        .DatabaseResult(resultStatus, resultMessage, resultDs)
            '    End With
            '    Me.Close()
            'End If

            objectSender.DatabaseResult(resultStatus, resultMessage, resultDs)
        End If
    End Sub
End Class
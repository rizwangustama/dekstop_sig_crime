Public Class ListOfNews
    Implements IDbConnection

    Dim selectedGridIndex As Integer = -1

    Public Sub DatabaseResult(status As String, message As String, dt As SigDataSet) Implements Globals.IDbConnection.DatabaseResult
        Try
            Dim resultStatus As String = ""
            If status = ResultCode.Success Then
                resultStatus = "Success"
                Try
                    Me.MetroGrid1.Rows.Clear()
                Catch ex As Exception

                End Try
                Me.MetroGrid1.DataSource = dt
                Me.MetroGrid1.DataMember = "kriminal"
                Me.MetroGrid1.Refresh()
            ElseIf status = ResultCode.Failed Then
                resultStatus = "Failed"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListOfNews_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            Dim dbConn As New DatabaseConnection
            dbConn.Query = "SELECT * FROM kriminal"
            dbConn.tableName = "kriminal"
            dbConn.objectSender = Me
            dbConn.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As System.Object, e As System.EventArgs) Handles MetroButton2.Click
        Dim addForm As New DialogDataKriminal
        addForm.Text = "Tambah Data"
        addForm.FormSender = Me
        addForm.MetroButton3.Visible = False
        addForm.ShowDialog()
        If addForm.DialogResult = DialogResult.OK Then
            MetroButton3.PerformClick()
            MetroGrid1.ClearSelection()
        End If
    End Sub

    Private Sub MetroGrid1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MetroGrid1.CellContentClick
        Try
            Dim senderGrid = DirectCast(sender, DataGridView)

            If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
                e.RowIndex >= 0 Then
                selectedGridIndex = e.RowIndex
                Dim addForm As New DialogDataKriminal
                With addForm
                    .Text = "Perbaharui Data"
                    .FormSender = Me
                    .MetroButton2.Visible = False
                    .docID = MetroGrid1.Rows(e.RowIndex).Cells(0).Value

                End With
                addForm.ShowDialog()
                If addForm.DialogResult = DialogResult.OK Then
                    MetroButton3.PerformClick()
                    MetroGrid1.ClearSelection()
                    MetroGrid1.CurrentCell = MetroGrid1.Rows(selectedGridIndex).Cells(1)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MetroButton3_Click(sender As System.Object, e As System.EventArgs) Handles MetroButton3.Click
        Dim dbConn As New DatabaseConnection
        dbConn.Query = "SELECT * FROM kriminal"
        dbConn.tableName = "kriminal"
        dbConn.objectSender = Me
        dbConn.ShowDialog()
    End Sub

    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        If MetroTextBox1.Text.Length > 0 Then
            Dim dbConn As New DatabaseConnection
            dbConn.Query = "SELECT * FROM kriminal WHERE kriminal.kasus_kriminal LIKE '%" & MetroTextBox1.Text & "%' OR kriminal.alamat LIKE '%" & MetroTextBox1.Text & "%'"
            dbConn.tableName = "kriminal"
            dbConn.objectSender = Me
            dbConn.ShowDialog()
        Else
            MetroButton3.PerformClick()
        End If
    End Sub
End Class

Imports SIG_Crime_State.Globals
Imports MySql.Data.MySqlClient

Public Class Dashboard
    Implements IDbConnection

    Dim selectedGridIndex As Integer = -1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dbConn As New DatabaseConnection
        dbConn.Query = "SELECT * FROM kecamatan"
        dbConn.tableName = "kecamatan"
        dbConn.objectSender = Me
        dbConn.ShowDialog()
    End Sub


    Sub getCountKecamatan()
        Me.UseWaitCursor = True
        'SELECT COUNT(kecamatan.id) AS CountKecamatan FROM kecamatan
        Dim sql2 As String = "SELECT COUNT(kecamatan.id) AS CountKecamatan FROM kecamatan"
        Dim con As MySqlConnection = New MySqlConnection("server=" & host & ";" & "userid=" & uid & ";" & "password=" & pwd & "; default command timeout=1800; " & "database=" & db & "; Convert Zero Datetime=True;")
        Try
            con.Open()
            Dim da As New MySqlDataAdapter(sql2, con)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MetroTile1.TileCount = dt.Rows(0).Item(0)
            End If
            Me.UseWaitCursor = False
        Catch ex As Exception
            Me.UseWaitCursor = False
            MsgBox(ex.Message)
        Finally
            Me.UseWaitCursor = False
            con.Close()
        End Try
    End Sub
    Sub getCountUsers()
        'SELECT COUNT(users.id) AS CountUser FROM users
        Me.UseWaitCursor = True
        Dim sql2 As String = "SELECT COUNT(users.id) AS CountUser FROM users WHERE isdeleted='false'"
        Dim con As MySqlConnection = New MySqlConnection("server=" & host & ";" & "userid=" & uid & ";" & "password=" & pwd & "; default command timeout=1800; " & "database=" & db & "; Convert Zero Datetime=True;")
        Try
            con.Open()
            Dim da As New MySqlDataAdapter(sql2, con)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MetroTile3.TileCount = dt.Rows(0).Item(0)
            End If
            Me.UseWaitCursor = False
        Catch ex As Exception
            Me.UseWaitCursor = False
            MsgBox(ex.Message)
        Finally
            Me.UseWaitCursor = False
            con.Close()
        End Try
    End Sub
    Sub getCountKriminal()
        Me.UseWaitCursor = True
        'SELECT COUNT(kriminal.id) AS CountKriminal FROM kriminal
        Dim sql2 As String = "SELECT COUNT(kriminal.id) AS CountKriminal FROM kriminal"
        Dim con As MySqlConnection = New MySqlConnection("server=" & host & ";" & "userid=" & uid & ";" & "password=" & pwd & "; default command timeout=1800; " & "database=" & db & "; Convert Zero Datetime=True;")
        Try
            con.Open()
            Dim da As New MySqlDataAdapter(sql2, con)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MetroTile4.TileCount = dt.Rows(0).Item(0)
            End If
            Me.UseWaitCursor = False
        Catch ex As Exception
            Me.UseWaitCursor = False
            MsgBox(ex.Message)
        Finally
            Me.UseWaitCursor = False
            con.Close()
        End Try
    End Sub
    Sub getCountKlasifikasiKriminal()
        Me.UseWaitCursor = True
        'SELECT COUNT(klasifikasi_kriminal.id) AS CountKlasifikasiKriminal FROM klasifikasi_kriminal
        Dim sql2 As String = "SELECT COUNT(klasifikasi_kriminal.id) AS CountKlasifikasiKriminal FROM klasifikasi_kriminal"
        Dim con As MySqlConnection = New MySqlConnection("server=" & host & ";" & "userid=" & uid & ";" & "password=" & pwd & "; default command timeout=1800; " & "database=" & db & "; Convert Zero Datetime=True;")
        Try
            con.Open()
            Dim da As New MySqlDataAdapter(sql2, con)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MetroTile2.TileCount = dt.Rows(0).Item(0)
            End If
            Me.UseWaitCursor = False
        Catch ex As Exception
            Me.UseWaitCursor = False
            MsgBox(ex.Message)
        Finally
            Me.UseWaitCursor = False
            con.Close()
        End Try
    End Sub

    Sub DatabaseResult(ByVal status As String, ByVal message As String, ByVal dt As SigDataSet) Implements IDbConnection.DatabaseResult
        'Dim resultStatus As String = ""
        'If status = ResultCode.Success Then
        '    resultStatus = "Success"
        'ElseIf status = ResultCode.Failed Then
        '    resultStatus = "Failed"
        'End If
        'Label1.Text = resultStatus & vbCrLf & message & " "

        'If dt.Rows.Count > 0 Then
        '    Label1.Text += dt.Rows(0).Item(1).ToString
        'End If


        'Me.MetroGrid1.DataSource = DataSet.kecamatan

    End Sub

    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If userLogin = "#" Then
            Dim loginForm As New LoginForm
            loginForm.WindowState = FormWindowState.Normal
            loginForm.StartPosition = FormStartPosition.CenterScreen
            loginForm.ShowDialog()
        End If
        getCountKecamatan()
        getCountKlasifikasiKriminal()
        getCountUsers()
        getCountKriminal()
    End Sub

    'Private Sub MetroButton2_Click(sender As System.Object, e As System.EventArgs) Handles MetroButton2.Click
    '    Dim addForm As New DialogKecamatan
    '    addForm.Text = "Tambah Data"
    '    addForm.FormSender = Me
    '    addForm.MetroButton3.Visible = False
    '    addForm.ShowDialog()
    '    If addForm.DialogResult = DialogResult.OK Then
    '        MetroGrid1.ClearSelection()
    '        MetroGrid1.CurrentCell = MetroGrid1.Rows(selectedGridIndex).Cells(1)
    '    End If
    'End Sub

    'Private Sub MetroGrid1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    Dim senderGrid = DirectCast(sender, DataGridView)

    '    If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
    '        e.RowIndex >= 0 Then
    '        selectedGridIndex = e.RowIndex
    '        Dim addForm As New DialogKecamatan
    '        With addForm
    '            .Text = "Perbaharui Data"
    '            .kmlName = MetroGrid1.Rows(e.RowIndex).Cells(5).Value
    '            .FormSender = Me
    '            .MetroButton2.Visible = False
    '            .MetroTextBox1.Text = MetroGrid1.Rows(e.RowIndex).Cells(0).Value
    '            .MetroTextBox2.Text = MetroGrid1.Rows(e.RowIndex).Cells(1).Value
    '            .MetroTextBox3.Text = MetroGrid1.Rows(e.RowIndex).Cells(2).Value
    '            .MetroTextBox4.Text = MetroGrid1.Rows(e.RowIndex).Cells(3).Value
    '            .MetroTextBox5.Text = MetroGrid1.Rows(e.RowIndex).Cells(4).Value
    '            .MetroTextBox6.Text = MetroGrid1.Rows(e.RowIndex).Cells(5).Value
    '            If Not IsDBNull(MetroGrid1.Rows(e.RowIndex).Cells(6).Value) Then
    '                Dim lastUpdate As DateTime = MetroGrid1.Rows(e.RowIndex).Cells(6).Value
    '                .MetroTextBox7.Text = lastUpdate.ToString("yyyy-MM-dd hh:mm")
    '            End If
    '        End With
    '        addForm.ShowDialog()
    '        If addForm.DialogResult = DialogResult.OK Then
    '            'RefreshData()
    '            MetroGrid1.ClearSelection()
    '            MetroGrid1.CurrentCell = MetroGrid1.Rows(selectedGridIndex).Cells(1)
    '        End If
    '    End If
    'End Sub

    Private Sub MetroTile1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile1.Click
        Dim control As New ControlKecamatan
        control.Dock = DockStyle.Fill
        MetroUserControl1.Controls.Clear()
        MetroUserControl1.Controls.Add(control)
    End Sub

    Private Sub MetroTile2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile2.Click
        Dim control As New DataKlasifikasiKriminal
        control.Dock = DockStyle.Fill
        MetroUserControl1.Controls.Clear()
        MetroUserControl1.Controls.Add(control)
    End Sub

    Private Sub MetroTile4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile4.Click
        Dim control As New ListOfNews
        control.Dock = DockStyle.Fill
        MetroUserControl1.Controls.Clear()
        MetroUserControl1.Controls.Add(control)
    End Sub

    Private Sub MetroTile3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile3.Click
        Dim control As New ListOfUsers
        control.Dock = DockStyle.Fill
        MetroUserControl1.Controls.Clear()
        MetroUserControl1.Controls.Add(control)
    End Sub

    Private Sub MetroTile5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile5.Click
        MetroUserControl1.Controls.Clear()
        userLogin = "#"
        Dim login As New LoginForm
        login.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
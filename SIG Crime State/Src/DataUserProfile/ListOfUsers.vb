Public Class ListOfUsers
    Implements IDbConnection

    Dim selectedGridIndex As Integer = -1

    Public Sub DatabaseResult(status As String, message As String, dt As SigDataSet) Implements Globals.IDbConnection.DatabaseResult
        Dim resultStatus As String = ""
        If status = ResultCode.Success Then
            resultStatus = "Success"
            Try
                Me.MetroGrid1.Rows.Clear()
            Catch ex As Exception

            End Try
            Me.MetroGrid1.DataSource = dt
            Me.MetroGrid1.DataMember = "users"
            Me.MetroGrid1.Refresh()
        ElseIf status = ResultCode.Failed Then
            resultStatus = "Failed"
        End If
    End Sub

    Private Sub ListOfUsers_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim dbConn As New DatabaseConnection
        dbConn.Query = "SELECT * FROM users WHERE isdeleted ='false'"
        dbConn.tableName = "users"
        dbConn.objectSender = Me
        dbConn.ShowDialog()
    End Sub

    Private Sub MetroButton2_Click(sender As System.Object, e As System.EventArgs) Handles MetroButton2.Click
        Dim addForm As New DialogUserProfile
        addForm.Text = "Tambah Data"
        addForm.FormSender = Me
        addForm.MetroButton3.Visible = False
        addForm.isnewUser = True
        addForm.ShowDialog()
        If addForm.DialogResult = DialogResult.OK Then
            MetroButton3.PerformClick()
            MetroGrid1.ClearSelection()
        End If
    End Sub

    Private Sub MetroGrid1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MetroGrid1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
            e.RowIndex >= 0 Then
            selectedGridIndex = e.RowIndex
            Dim addForm As New DialogUserProfile
            With addForm
                .Text = "Perbaharui Data"
                .FindUserData(MetroGrid1.Rows(e.RowIndex).Cells(0).Value)
                .FormSender = Me
                .isUpdateUser = True
                .MetroButton2.Visible = False
            End With
            addForm.ShowDialog()
            If addForm.DialogResult = DialogResult.OK Then
                Try
                    MetroButton3.PerformClick()
                    MetroGrid1.ClearSelection()
                    MetroGrid1.CurrentCell = MetroGrid1.Rows(selectedGridIndex).Cells(4)
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    Private Sub MetroButton3_Click(sender As System.Object, e As System.EventArgs) Handles MetroButton3.Click
        Dim dbConn As New DatabaseConnection
        dbConn.Query = "SELECT * FROM users WHERE isdeleted ='false'"
        dbConn.tableName = "users"
        dbConn.objectSender = Me
        dbConn.ShowDialog()
    End Sub

    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        If MetroTextBox1.Text.Length > 0 Then
            Dim dbConn As New DatabaseConnection
            dbConn.Query = "SELECT * FROM users WHERE users.email LIKE '%" & MetroTextBox1.Text & "%' OR " + _
                "users.full_name LIKE '%" & MetroTextBox1.Text & "%' AND isdeleted ='false'"
            dbConn.tableName = "users"
            dbConn.objectSender = Me
            dbConn.ShowDialog()
        Else
            MetroButton3.PerformClick()
        End If
    End Sub
End Class

Public Class LoginForm
    Implements IDbConnection


    Public Sub DatabaseResult(ByVal status As String, ByVal message As String, ByVal dt As SigDataSet) Implements Globals.IDbConnection.DatabaseResult
        If dt.Tables("users").Rows.Count > 0 Then
            Dim usertable As New DataTable
            usertable = dt.Tables("users")
            userLogin = usertable.Rows(0).Item(0)
            Me.Close()
        Else
            MsgBox("User Tidak Ditemukan")
        End If

    End Sub

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim dbConn As New DatabaseConnection
        dbConn.Query = "SELECT * FROM users WHERE users.user = '" & UsernameTextBox.Text & "' AND " + _
            "users.pass = '" & PasswordTextBox.Text & "' AND isdeleted ='false'"
        dbConn.tableName = "users"
        dbConn.objectSender = Me
        dbConn.ShowDialog()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If userLogin = "#" Then
            Application.Exit()
        End If
    End Sub
End Class

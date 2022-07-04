Public Class Users

    Public Property id As Integer
    Public Property user As String
    Public Property pass As String
    Public Property full_name As String
    Public Property is_admin As Integer
    Public Property user_verified As Integer

    Sub New()

    End Sub

    Sub New(ByVal id_ As Integer, ByVal user_ As String, ByVal pass_ As String, ByVal full_name_ As String, ByVal is_admin_ As Integer, ByVal user_verified_ As Integer)
        Me.id = id_
        Me.user = user_
        Me.pass = pass_
        Me.full_name = full_name_
        Me.is_admin = is_admin_
        Me.user_verified = user_verified_
    End Sub

End Class

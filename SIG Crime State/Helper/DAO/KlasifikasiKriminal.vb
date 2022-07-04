Public Class KlasifikasiKriminal
    Public Property id As Integer
    Public Property klasifikasi_kriminal As String
    Public Property desc As String
    Public Property ico As String
    Public Property last_upadted As DateTime

    Sub New(ByVal id_ As Integer, ByVal klasifikasi_kriminal_ As String, ByVal desc_ As String, ByVal ico_ As String, ByVal last_upadted_ As DateTime)
        Me.id = id_
        Me.klasifikasi_kriminal = klasifikasi_kriminal_
        Me.desc = desc_
        Me.ico = ico_
        Me.last_upadted = last_upadted_
    End Sub
End Class

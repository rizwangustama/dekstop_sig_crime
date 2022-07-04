Public Class Kecamatan
    Public Property id As Integer
    Public Property kecamatan As String
    Public Property alamat As String
    Public Property map_long As Double
    Public Property map_lang As Double
    Public Property geo_file As String
    Public Property last_update As DateTime

    Sub New()

    End Sub

    Sub New(ByVal id_ As Integer, ByVal kecamatan_ As String, ByVal alamat_ As String, ByVal map_long_ As Double, ByVal map_lang_ As Double, ByVal geo_file_ As String, ByVal last_update_ As DateTime)
        Me.id = id_
        Me.kecamatan = kecamatan_
        Me.alamat = alamat_
        Me.map_long = map_long_
        Me.map_lang = map_lang_
        Me.geo_file = geo_file_
        Me.last_update = last_update_
    End Sub


End Class

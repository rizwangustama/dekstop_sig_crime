Public Class UserData

    Public Property id As Integer
    Public Property nik As Integer
    Public Property user_id As Integer
    Public Property name As String
    Public Property tempat_lahir As String
    Public Property tanggal_lahir As DateTime
    Public Property jenis_kelamin As String
    Public Property alamat As String
    Public Property rt_rw As String
    Public Property kel_desa As String
    Public Property kecamatan As String
    Public Property agama As String
    Public Property st_kawin As String
    Public Property pekerjaan As String
    Public Property kewarganegaraan As String
    Public Property exp As String
    Public Property img As String


    Sub New()

    End Sub

    Sub New(ByVal id_ As Integer, ByVal nik_ As Integer, ByVal user_id_ As Integer, ByVal name_ As String, ByVal tempat_lahir_ As String, ByVal tanggal_lahir_ As DateTime, ByVal jenis_kelamin_ As String, ByVal alamat_ As String, ByVal rt_rw_ As String, ByVal kel_desa_ As String, ByVal kecamatan_ As String, ByVal agama_ As String, ByVal st_kawin_ As String, ByVal pekerjaan_ As String, ByVal kewarganegaraan_ As String, ByVal exp_ As String, ByVal img_ As String)
        Me.id = id_
        Me.nik = nik_
        Me.user_id = user_id_
        Me.name = name_
        Me.tempat_lahir = tempat_lahir_
        Me.tanggal_lahir = tanggal_lahir_
        Me.jenis_kelamin = jenis_kelamin_
        Me.alamat = alamat_
        Me.rt_rw = rt_rw_
        Me.kel_desa = kel_desa_
        Me.kecamatan = kecamatan_
        Me.agama = agama_
        Me.st_kawin = st_kawin_
        Me.pekerjaan = pekerjaan_
        Me.kewarganegaraan = kewarganegaraan_
        Me.exp = exp_
        Me.img = img_

    End Sub




End Class

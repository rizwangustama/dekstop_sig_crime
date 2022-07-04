Module Globals
    'Public Property host As String = "localhost"
    'Public Property uid As String = "root"
    'Public Property pwd As String = ""
    'Public Property db As String = "sig_crime"

    Public Property host As String = "103.145.226.247"
    Public Property uid As String = "rizwangu_rizwangustama"
    Public Property pwd As String = "noekasep@ok!!"
    Public Property db As String = "rizwangu_sig_crime"
    Public Property UploadKml As String = "http://localhost/sig/uploader.php"
    Public Property userLogin As String = "#"

    'Public Const weburi As String = "http://localhost"
    Public Const weburi As String = "http://rizwangustama.my.id"


    Public Const kecPicUrl As String = weburi + "/sig/Assets/image/kecamatan/"
    Public Const userPofilePicUrl As String = weburi + "/sig/Assets/image/userprofile/"
    Public Const userPicUrl As String = weburi + "/sig/Assets/api/identifier/identifier/"
    Public Property UploadAssets As String = weburi + "/sig/Assets/api/appscript/postnews/uploader.php"


    Public Const UploadKecamatanImg As String = weburi + "/sig/Assets/image/uploaderkecamatan.php"
    Public Const UploadUserImg As String = weburi + "/sig/Assets/image/uploaderprofiledesktop.php"
    Public Const UploadKtpImg As String = weburi + "/sig/Assets/api/identifier/identifieruploaddesktop.php"

    Public Enum ResultCode
        Success
        Failed
    End Enum

    Public Function ImgToByte(picture As PictureBox)
        Dim arrImage() As Byte
        Dim mstream As New System.IO.MemoryStream()
        picture.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()
        Return arrImage
    End Function

    Public Interface IDbConnection
        Sub DatabaseResult(status As String, message As String, dt As SigDataSet)
    End Interface
End Module

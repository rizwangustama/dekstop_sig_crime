<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogUserProfile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NikLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim Tempat_lahirLabel As System.Windows.Forms.Label
        Dim Tanggal_lahirLabel As System.Windows.Forms.Label
        Dim Jenis_kelaminLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim Rt_rwLabel As System.Windows.Forms.Label
        Dim Kel_desaLabel As System.Windows.Forms.Label
        Dim KecamatanLabel As System.Windows.Forms.Label
        Dim AgamaLabel As System.Windows.Forms.Label
        Dim St_kawinLabel As System.Windows.Forms.Label
        Dim PekerjaanLabel As System.Windows.Forms.Label
        Dim KewarganegaraanLabel As System.Windows.Forms.Label
        Dim ExpLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SigDataSet = New SIG_Crime_State.SigDataSet()
        Me.ExpTextBox = New System.Windows.Forms.TextBox()
        Me.UserdataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.KewarganegaraanTextBox = New System.Windows.Forms.TextBox()
        Me.PekerjaanTextBox = New System.Windows.Forms.TextBox()
        Me.St_kawinTextBox = New System.Windows.Forms.TextBox()
        Me.AgamaTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Kel_desaTextBox = New System.Windows.Forms.TextBox()
        Me.Rt_rwTextBox = New System.Windows.Forms.TextBox()
        Me.AlamatTextBox = New System.Windows.Forms.TextBox()
        Me.KecamatanTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NikTextBox = New System.Windows.Forms.TextBox()
        Me.User_idTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Tempat_lahirTextBox = New System.Windows.Forms.TextBox()
        Me.Tanggal_lahirDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Jenis_kelaminTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox3 = New MetroFramework.Controls.MetroTextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.UserPicFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.KtpFileDialog = New System.Windows.Forms.OpenFileDialog()
        NikLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        Tempat_lahirLabel = New System.Windows.Forms.Label()
        Tanggal_lahirLabel = New System.Windows.Forms.Label()
        Jenis_kelaminLabel = New System.Windows.Forms.Label()
        AlamatLabel = New System.Windows.Forms.Label()
        Rt_rwLabel = New System.Windows.Forms.Label()
        Kel_desaLabel = New System.Windows.Forms.Label()
        KecamatanLabel = New System.Windows.Forms.Label()
        AgamaLabel = New System.Windows.Forms.Label()
        St_kawinLabel = New System.Windows.Forms.Label()
        PekerjaanLabel = New System.Windows.Forms.Label()
        KewarganegaraanLabel = New System.Windows.Forms.Label()
        ExpLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.MetroPanel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SigDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserdataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NikLabel
        '
        NikLabel.AutoSize = True
        NikLabel.Location = New System.Drawing.Point(8, 27)
        NikLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NikLabel.Name = "NikLabel"
        NikLabel.Size = New System.Drawing.Size(38, 25)
        NikLabel.TabIndex = 2
        NikLabel.Text = "nik:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(8, 68)
        NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(61, 25)
        NameLabel.TabIndex = 6
        NameLabel.Text = "name:"
        '
        'Tempat_lahirLabel
        '
        Tempat_lahirLabel.AutoSize = True
        Tempat_lahirLabel.Location = New System.Drawing.Point(8, 108)
        Tempat_lahirLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Tempat_lahirLabel.Name = "Tempat_lahirLabel"
        Tempat_lahirLabel.Size = New System.Drawing.Size(113, 25)
        Tempat_lahirLabel.TabIndex = 8
        Tempat_lahirLabel.Text = "tempat lahir:"
        '
        'Tanggal_lahirLabel
        '
        Tanggal_lahirLabel.AutoSize = True
        Tanggal_lahirLabel.Location = New System.Drawing.Point(8, 150)
        Tanggal_lahirLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Tanggal_lahirLabel.Name = "Tanggal_lahirLabel"
        Tanggal_lahirLabel.Size = New System.Drawing.Size(115, 25)
        Tanggal_lahirLabel.TabIndex = 10
        Tanggal_lahirLabel.Text = "tanggal lahir:"
        '
        'Jenis_kelaminLabel
        '
        Jenis_kelaminLabel.AutoSize = True
        Jenis_kelaminLabel.Location = New System.Drawing.Point(8, 190)
        Jenis_kelaminLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Jenis_kelaminLabel.Name = "Jenis_kelaminLabel"
        Jenis_kelaminLabel.Size = New System.Drawing.Size(117, 25)
        Jenis_kelaminLabel.TabIndex = 12
        Jenis_kelaminLabel.Text = "jenis kelamin:"
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Location = New System.Drawing.Point(8, 28)
        AlamatLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(69, 25)
        AlamatLabel.TabIndex = 14
        AlamatLabel.Text = "alamat:"
        '
        'Rt_rwLabel
        '
        Rt_rwLabel.AutoSize = True
        Rt_rwLabel.Location = New System.Drawing.Point(36, 118)
        Rt_rwLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Rt_rwLabel.Name = "Rt_rwLabel"
        Rt_rwLabel.Size = New System.Drawing.Size(54, 25)
        Rt_rwLabel.TabIndex = 16
        Rt_rwLabel.Text = "rt rw:"
        '
        'Kel_desaLabel
        '
        Kel_desaLabel.AutoSize = True
        Kel_desaLabel.Location = New System.Drawing.Point(36, 159)
        Kel_desaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Kel_desaLabel.Name = "Kel_desaLabel"
        Kel_desaLabel.Size = New System.Drawing.Size(80, 25)
        Kel_desaLabel.TabIndex = 18
        Kel_desaLabel.Text = "kel desa:"
        '
        'KecamatanLabel
        '
        KecamatanLabel.AutoSize = True
        KecamatanLabel.Location = New System.Drawing.Point(36, 199)
        KecamatanLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        KecamatanLabel.Name = "KecamatanLabel"
        KecamatanLabel.Size = New System.Drawing.Size(101, 25)
        KecamatanLabel.TabIndex = 20
        KecamatanLabel.Text = "kecamatan:"
        '
        'AgamaLabel
        '
        AgamaLabel.AutoSize = True
        AgamaLabel.Location = New System.Drawing.Point(12, 44)
        AgamaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AgamaLabel.Name = "AgamaLabel"
        AgamaLabel.Size = New System.Drawing.Size(70, 25)
        AgamaLabel.TabIndex = 22
        AgamaLabel.Text = "agama:"
        '
        'St_kawinLabel
        '
        St_kawinLabel.AutoSize = True
        St_kawinLabel.Location = New System.Drawing.Point(12, 85)
        St_kawinLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        St_kawinLabel.Name = "St_kawinLabel"
        St_kawinLabel.Size = New System.Drawing.Size(78, 25)
        St_kawinLabel.TabIndex = 24
        St_kawinLabel.Text = "st kawin:"
        '
        'PekerjaanLabel
        '
        PekerjaanLabel.AutoSize = True
        PekerjaanLabel.Location = New System.Drawing.Point(12, 126)
        PekerjaanLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PekerjaanLabel.Name = "PekerjaanLabel"
        PekerjaanLabel.Size = New System.Drawing.Size(93, 25)
        PekerjaanLabel.TabIndex = 26
        PekerjaanLabel.Text = "pekerjaan:"
        '
        'KewarganegaraanLabel
        '
        KewarganegaraanLabel.AutoSize = True
        KewarganegaraanLabel.Location = New System.Drawing.Point(12, 166)
        KewarganegaraanLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        KewarganegaraanLabel.Name = "KewarganegaraanLabel"
        KewarganegaraanLabel.Size = New System.Drawing.Size(156, 25)
        KewarganegaraanLabel.TabIndex = 28
        KewarganegaraanLabel.Text = "kewarganegaraan:"
        '
        'ExpLabel
        '
        ExpLabel.AutoSize = True
        ExpLabel.Location = New System.Drawing.Point(191, 256)
        ExpLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ExpLabel.Name = "ExpLabel"
        ExpLabel.Size = New System.Drawing.Size(45, 25)
        ExpLabel.TabIndex = 30
        ExpLabel.Text = "exp:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 207)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(55, 25)
        Label1.TabIndex = 30
        Label1.Text = "Email"
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.Panel1)
        Me.MetroPanel1.Controls.Add(Me.MetroButton1)
        Me.MetroPanel1.Controls.Add(Me.MetroButton3)
        Me.MetroPanel1.Controls.Add(Me.MetroButton2)
        Me.MetroPanel1.Controls.Add(Me.GroupBox3)
        Me.MetroPanel1.Controls.Add(Me.PictureBox1)
        Me.MetroPanel1.Controls.Add(Me.GroupBox2)
        Me.MetroPanel1.Controls.Add(Me.GroupBox1)
        Me.MetroPanel1.Controls.Add(Me.MetroTextBox1)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 12
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(1165, 820)
        Me.MetroPanel1.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroPanel1.TabIndex = 2
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.UseCustomForeColor = True
        Me.MetroPanel1.UseStyleColors = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 13
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(336, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 41)
        Me.Panel1.TabIndex = 25
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(1041, 139)
        Me.MetroButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(100, 28)
        Me.MetroButton1.TabIndex = 24
        Me.MetroButton1.Text = "Hapus"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(1041, 175)
        Me.MetroButton3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(100, 28)
        Me.MetroButton3.TabIndex = 23
        Me.MetroButton3.Text = "Perbaharui"
        Me.MetroButton3.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(1041, 175)
        Me.MetroButton2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(100, 28)
        Me.MetroButton2.TabIndex = 22
        Me.MetroButton2.Text = "Simpan"
        Me.MetroButton2.UseSelectable = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.IdTextBox)
        Me.GroupBox3.Controls.Add(NikLabel)
        Me.GroupBox3.Controls.Add(Me.NikTextBox)
        Me.GroupBox3.Controls.Add(Me.User_idTextBox)
        Me.GroupBox3.Controls.Add(NameLabel)
        Me.GroupBox3.Controls.Add(Me.NameTextBox)
        Me.GroupBox3.Controls.Add(Tempat_lahirLabel)
        Me.GroupBox3.Controls.Add(Me.Tempat_lahirTextBox)
        Me.GroupBox3.Controls.Add(Tanggal_lahirLabel)
        Me.GroupBox3.Controls.Add(Me.Tanggal_lahirDateTimePicker)
        Me.GroupBox3.Controls.Add(Jenis_kelaminLabel)
        Me.GroupBox3.Controls.Add(Me.Jenis_kelaminTextBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(21, 210)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(1125, 602)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "User Data"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.PictureBox2)
        Me.GroupBox6.Controls.Add(Me.ExpTextBox)
        Me.GroupBox6.Controls.Add(ExpLabel)
        Me.GroupBox6.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(577, 299)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox6.Size = New System.Drawing.Size(540, 295)
        Me.GroupBox6.TabIndex = 34
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Lampiran KTP"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.SigDataSet, "userdata.img", True))
        Me.PictureBox2.Location = New System.Drawing.Point(8, 25)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(513, 219)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.WaitOnLoad = True
        '
        'SigDataSet
        '
        Me.SigDataSet.DataSetName = "SigDataSet"
        Me.SigDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExpTextBox
        '
        Me.ExpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserdataBindingSource, "exp", True))
        Me.ExpTextBox.Location = New System.Drawing.Point(256, 252)
        Me.ExpTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ExpTextBox.Name = "ExpTextBox"
        Me.ExpTextBox.Size = New System.Drawing.Size(265, 32)
        Me.ExpTextBox.TabIndex = 31
        '
        'UserdataBindingSource
        '
        Me.UserdataBindingSource.DataMember = "userdata"
        Me.UserdataBindingSource.DataSource = Me.SigDataSet
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.EmailTextBox)
        Me.GroupBox5.Controls.Add(Label1)
        Me.GroupBox5.Controls.Add(AgamaLabel)
        Me.GroupBox5.Controls.Add(Me.KewarganegaraanTextBox)
        Me.GroupBox5.Controls.Add(KewarganegaraanLabel)
        Me.GroupBox5.Controls.Add(Me.PekerjaanTextBox)
        Me.GroupBox5.Controls.Add(PekerjaanLabel)
        Me.GroupBox5.Controls.Add(Me.St_kawinTextBox)
        Me.GroupBox5.Controls.Add(St_kawinLabel)
        Me.GroupBox5.Controls.Add(Me.AgamaTextBox)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(577, 23)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(540, 268)
        Me.GroupBox5.TabIndex = 33
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Aditional Data"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SigDataSet, "users.email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(183, 203)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(339, 32)
        Me.EmailTextBox.TabIndex = 31
        '
        'KewarganegaraanTextBox
        '
        Me.KewarganegaraanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserdataBindingSource, "kewarganegaraan", True))
        Me.KewarganegaraanTextBox.Location = New System.Drawing.Point(183, 162)
        Me.KewarganegaraanTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KewarganegaraanTextBox.Name = "KewarganegaraanTextBox"
        Me.KewarganegaraanTextBox.Size = New System.Drawing.Size(339, 32)
        Me.KewarganegaraanTextBox.TabIndex = 29
        '
        'PekerjaanTextBox
        '
        Me.PekerjaanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserdataBindingSource, "pekerjaan", True))
        Me.PekerjaanTextBox.Location = New System.Drawing.Point(183, 122)
        Me.PekerjaanTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PekerjaanTextBox.Name = "PekerjaanTextBox"
        Me.PekerjaanTextBox.Size = New System.Drawing.Size(339, 32)
        Me.PekerjaanTextBox.TabIndex = 27
        '
        'St_kawinTextBox
        '
        Me.St_kawinTextBox.AutoCompleteCustomSource.AddRange(New String() {"Belum Kawin", "Kawin"})
        Me.St_kawinTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.St_kawinTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.St_kawinTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserdataBindingSource, "st_kawin", True))
        Me.St_kawinTextBox.Location = New System.Drawing.Point(183, 81)
        Me.St_kawinTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.St_kawinTextBox.Name = "St_kawinTextBox"
        Me.St_kawinTextBox.Size = New System.Drawing.Size(339, 32)
        Me.St_kawinTextBox.TabIndex = 25
        '
        'AgamaTextBox
        '
        Me.AgamaTextBox.AutoCompleteCustomSource.AddRange(New String() {"Islam", "Kristen", "Hindu", "Budha"})
        Me.AgamaTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.AgamaTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.AgamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserdataBindingSource, "agama", True))
        Me.AgamaTextBox.Location = New System.Drawing.Point(183, 41)
        Me.AgamaTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AgamaTextBox.Name = "AgamaTextBox"
        Me.AgamaTextBox.Size = New System.Drawing.Size(339, 32)
        Me.AgamaTextBox.TabIndex = 23
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(AlamatLabel)
        Me.GroupBox4.Controls.Add(Me.Kel_desaTextBox)
        Me.GroupBox4.Controls.Add(Kel_desaLabel)
        Me.GroupBox4.Controls.Add(Me.Rt_rwTextBox)
        Me.GroupBox4.Controls.Add(Rt_rwLabel)
        Me.GroupBox4.Controls.Add(Me.AlamatTextBox)
        Me.GroupBox4.Controls.Add(Me.KecamatanTextBox)
        Me.GroupBox4.Controls.Add(KecamatanLabel)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(8, 241)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(551, 245)
        Me.GroupBox4.TabIndex = 32
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Alamat"
        '
        'Kel_desaTextBox
        '
        Me.Kel_desaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserdataBindingSource, "kel_desa", True))
        Me.Kel_desaTextBox.Location = New System.Drawing.Point(179, 155)
        Me.Kel_desaTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Kel_desaTextBox.Name = "Kel_desaTextBox"
        Me.Kel_desaTextBox.Size = New System.Drawing.Size(363, 32)
        Me.Kel_desaTextBox.TabIndex = 19
        '
        'Rt_rwTextBox
        '
        Me.Rt_rwTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserdataBindingSource, "rt_rw", True))
        Me.Rt_rwTextBox.Location = New System.Drawing.Point(179, 114)
        Me.Rt_rwTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Rt_rwTextBox.Name = "Rt_rwTextBox"
        Me.Rt_rwTextBox.Size = New System.Drawing.Size(363, 32)
        Me.Rt_rwTextBox.TabIndex = 17
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserdataBindingSource, "alamat", True))
        Me.AlamatTextBox.Location = New System.Drawing.Point(179, 25)
        Me.AlamatTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AlamatTextBox.Multiline = True
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.Size = New System.Drawing.Size(363, 82)
        Me.AlamatTextBox.TabIndex = 15
        '
        'KecamatanTextBox
        '
        Me.KecamatanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserdataBindingSource, "kecamatan", True))
        Me.KecamatanTextBox.Location = New System.Drawing.Point(179, 196)
        Me.KecamatanTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KecamatanTextBox.Name = "KecamatanTextBox"
        Me.KecamatanTextBox.Size = New System.Drawing.Size(363, 32)
        Me.KecamatanTextBox.TabIndex = 21
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserdataBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(1020, 41)
        Me.IdTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(111, 32)
        Me.IdTextBox.TabIndex = 1
        Me.IdTextBox.Visible = False
        '
        'NikTextBox
        '
        Me.NikTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserdataBindingSource, "nik", True))
        Me.NikTextBox.Location = New System.Drawing.Point(179, 23)
        Me.NikTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NikTextBox.Name = "NikTextBox"
        Me.NikTextBox.Size = New System.Drawing.Size(371, 32)
        Me.NikTextBox.TabIndex = 3
        '
        'User_idTextBox
        '
        Me.User_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserdataBindingSource, "user_id", True))
        Me.User_idTextBox.Location = New System.Drawing.Point(1020, 86)
        Me.User_idTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.User_idTextBox.Name = "User_idTextBox"
        Me.User_idTextBox.Size = New System.Drawing.Size(111, 32)
        Me.User_idTextBox.TabIndex = 5
        Me.User_idTextBox.Visible = False
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserdataBindingSource, "name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(179, 64)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(371, 32)
        Me.NameTextBox.TabIndex = 7
        '
        'Tempat_lahirTextBox
        '
        Me.Tempat_lahirTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserdataBindingSource, "tempat_lahir", True))
        Me.Tempat_lahirTextBox.Location = New System.Drawing.Point(179, 105)
        Me.Tempat_lahirTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tempat_lahirTextBox.Name = "Tempat_lahirTextBox"
        Me.Tempat_lahirTextBox.Size = New System.Drawing.Size(371, 32)
        Me.Tempat_lahirTextBox.TabIndex = 9
        '
        'Tanggal_lahirDateTimePicker
        '
        Me.Tanggal_lahirDateTimePicker.CustomFormat = "yyyy-MM-dd"
        Me.Tanggal_lahirDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UserdataBindingSource, "tanggal_lahir", True))
        Me.Tanggal_lahirDateTimePicker.Location = New System.Drawing.Point(179, 145)
        Me.Tanggal_lahirDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tanggal_lahirDateTimePicker.Name = "Tanggal_lahirDateTimePicker"
        Me.Tanggal_lahirDateTimePicker.Size = New System.Drawing.Size(371, 32)
        Me.Tanggal_lahirDateTimePicker.TabIndex = 11
        '
        'Jenis_kelaminTextBox
        '
        Me.Jenis_kelaminTextBox.AutoCompleteCustomSource.AddRange(New String() {"Laki - Laki", "Perempuan"})
        Me.Jenis_kelaminTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Jenis_kelaminTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Jenis_kelaminTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserdataBindingSource, "jenis_kelamin", True))
        Me.Jenis_kelaminTextBox.Location = New System.Drawing.Point(179, 186)
        Me.Jenis_kelaminTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Jenis_kelaminTextBox.Name = "Jenis_kelaminTextBox"
        Me.Jenis_kelaminTextBox.Size = New System.Drawing.Size(371, 32)
        Me.Jenis_kelaminTextBox.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.SigDataSet, "users.pic", True))
        Me.PictureBox1.Location = New System.Drawing.Point(749, 25)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 178)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(544, 52)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(197, 151)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "User Status"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SigDataSet, "users.user_verified", True))
        Me.CheckBox3.Location = New System.Drawing.Point(8, 100)
        Me.CheckBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(133, 29)
        Me.CheckBox3.TabIndex = 20
        Me.CheckBox3.Text = "Verified User"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SigDataSet, "users.is_admin", True))
        Me.CheckBox2.Location = New System.Drawing.Point(8, 46)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(142, 29)
        Me.CheckBox2.TabIndex = 19
        Me.CheckBox2.Text = "Administrator"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.GroupBox1.Controls.Add(Me.MetroTextBox2)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.MetroTextBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 52)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(515, 151)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Login"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(8, 28)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(38, 20)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroLabel3.TabIndex = 5
        Me.MetroLabel3.Text = "User"
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel3.UseCustomBackColor = True
        Me.MetroLabel3.UseCustomForeColor = True
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = Nothing
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(399, 2)
        Me.MetroTextBox2.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroTextBox2.CustomButton.Name = ""
        Me.MetroTextBox2.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.MetroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox2.CustomButton.TabIndex = 1
        Me.MetroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox2.CustomButton.UseSelectable = True
        Me.MetroTextBox2.CustomButton.Visible = False
        Me.MetroTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SigDataSet, "users.user", True))
        Me.MetroTextBox2.Lines = New String(-1) {}
        Me.MetroTextBox2.Location = New System.Drawing.Point(172, 28)
        Me.MetroTextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroTextBox2.MaxLength = 32767
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.PromptText = "User"
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.ShortcutsEnabled = True
        Me.MetroTextBox2.Size = New System.Drawing.Size(325, 28)
        Me.MetroTextBox2.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox2.TabIndex = 4
        Me.MetroTextBox2.UseCustomBackColor = True
        Me.MetroTextBox2.UseCustomForeColor = True
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMark = "User"
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(8, 64)
        Me.MetroLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(66, 20)
        Me.MetroLabel4.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroLabel4.TabIndex = 7
        Me.MetroLabel4.Text = "Password"
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel4.UseCustomBackColor = True
        Me.MetroLabel4.UseCustomForeColor = True
        '
        'MetroTextBox3
        '
        '
        '
        '
        Me.MetroTextBox3.CustomButton.Image = Nothing
        Me.MetroTextBox3.CustomButton.Location = New System.Drawing.Point(399, 2)
        Me.MetroTextBox3.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroTextBox3.CustomButton.Name = ""
        Me.MetroTextBox3.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.MetroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox3.CustomButton.TabIndex = 1
        Me.MetroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox3.CustomButton.UseSelectable = True
        Me.MetroTextBox3.CustomButton.Visible = False
        Me.MetroTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SigDataSet, "users.pass", True))
        Me.MetroTextBox3.Lines = New String(-1) {}
        Me.MetroTextBox3.Location = New System.Drawing.Point(172, 64)
        Me.MetroTextBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroTextBox3.MaxLength = 32767
        Me.MetroTextBox3.Name = "MetroTextBox3"
        Me.MetroTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.MetroTextBox3.PromptText = "Password"
        Me.MetroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox3.SelectedText = ""
        Me.MetroTextBox3.SelectionLength = 0
        Me.MetroTextBox3.SelectionStart = 0
        Me.MetroTextBox3.ShortcutsEnabled = True
        Me.MetroTextBox3.Size = New System.Drawing.Size(325, 28)
        Me.MetroTextBox3.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox3.TabIndex = 6
        Me.MetroTextBox3.UseCustomBackColor = True
        Me.MetroTextBox3.UseCustomForeColor = True
        Me.MetroTextBox3.UseSelectable = True
        Me.MetroTextBox3.UseSystemPasswordChar = True
        Me.MetroTextBox3.WaterMark = "Password"
        Me.MetroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(172, 100)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(155, 29)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(159, 2)
        Me.MetroTextBox1.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(365, 16)
        Me.MetroTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.PromptText = "id"
        Me.MetroTextBox1.ReadOnly = True
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(145, 28)
        Me.MetroTextBox1.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox1.TabIndex = 0
        Me.MetroTextBox1.TabStop = False
        Me.MetroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MetroTextBox1.UseCustomBackColor = True
        Me.MetroTextBox1.UseCustomForeColor = True
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMark = "id"
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(4, 14)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(106, 25)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "User Profil"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'UserPicFileDialog
        '
        '
        'KtpFileDialog
        '
        '
        'DialogUserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1165, 820)
        Me.Controls.Add(Me.MetroPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogUserProfile"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DialogUserProfile"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SigDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserdataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MetroTextBox3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Kel_desaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserdataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SigDataSet As SIG_Crime_State.SigDataSet
    Friend WithEvents Rt_rwTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlamatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KecamatanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NikTextBox As System.Windows.Forms.TextBox
    Friend WithEvents User_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tempat_lahirTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tanggal_lahirDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Jenis_kelaminTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents St_kawinTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PekerjaanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KewarganegaraanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents UserPicFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents KtpFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class

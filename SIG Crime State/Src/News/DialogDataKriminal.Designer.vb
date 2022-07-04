<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogDataKriminal
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
        Dim Kasus_kriminalLabel As System.Windows.Forms.Label
        Dim Tanggal_kejadianLabel As System.Windows.Forms.Label
        Dim Waktu_kejadianLabel As System.Windows.Forms.Label
        Dim Map_latLabel As System.Windows.Forms.Label
        Dim Map_langLabel As System.Windows.Forms.Label
        Dim Create_byLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.KriminalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SigDataSet = New SIG_Crime_State.SigDataSet()
        Me.Id_kecamatanTextBox = New System.Windows.Forms.TextBox()
        Me.Id_klassifikasi_kriminalTextBox = New System.Windows.Forms.TextBox()
        Me.Kasus_kriminalTextBox = New System.Windows.Forms.TextBox()
        Me.Tanggal_kejadianDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AlamatTextBox = New System.Windows.Forms.TextBox()
        Me.Map_latTextBox = New System.Windows.Forms.TextBox()
        Me.Map_langTextBox = New System.Windows.Forms.TextBox()
        Me.Create_byTextBox = New System.Windows.Forms.TextBox()
        Me.WaktuKejadianDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Is_verifiedCheckBox = New System.Windows.Forms.CheckBox()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KriminalidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FilenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Action = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox_judul = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Kasus_kriminalLabel = New System.Windows.Forms.Label()
        Tanggal_kejadianLabel = New System.Windows.Forms.Label()
        Waktu_kejadianLabel = New System.Windows.Forms.Label()
        Map_latLabel = New System.Windows.Forms.Label()
        Map_langLabel = New System.Windows.Forms.Label()
        Create_byLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.KriminalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SigDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Kasus_kriminalLabel
        '
        Kasus_kriminalLabel.AutoSize = True
        Kasus_kriminalLabel.Location = New System.Drawing.Point(12, 188)
        Kasus_kriminalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Kasus_kriminalLabel.Name = "Kasus_kriminalLabel"
        Kasus_kriminalLabel.Size = New System.Drawing.Size(97, 20)
        Kasus_kriminalLabel.TabIndex = 10
        Kasus_kriminalLabel.Text = "Kasus Kriminal"
        '
        'Tanggal_kejadianLabel
        '
        Tanggal_kejadianLabel.AutoSize = True
        Tanggal_kejadianLabel.Location = New System.Drawing.Point(555, 83)
        Tanggal_kejadianLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Tanggal_kejadianLabel.Name = "Tanggal_kejadianLabel"
        Tanggal_kejadianLabel.Size = New System.Drawing.Size(112, 20)
        Tanggal_kejadianLabel.TabIndex = 12
        Tanggal_kejadianLabel.Text = "Tanggal Kejadian"
        '
        'Waktu_kejadianLabel
        '
        Waktu_kejadianLabel.AutoSize = True
        Waktu_kejadianLabel.Location = New System.Drawing.Point(555, 121)
        Waktu_kejadianLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Waktu_kejadianLabel.Name = "Waktu_kejadianLabel"
        Waktu_kejadianLabel.Size = New System.Drawing.Size(103, 20)
        Waktu_kejadianLabel.TabIndex = 14
        Waktu_kejadianLabel.Text = "Waktu Kejadian"
        '
        'Map_latLabel
        '
        Map_latLabel.AutoSize = True
        Map_latLabel.Location = New System.Drawing.Point(55, 88)
        Map_latLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Map_latLabel.Name = "Map_latLabel"
        Map_latLabel.Size = New System.Drawing.Size(58, 20)
        Map_latLabel.TabIndex = 18
        Map_latLabel.Text = "Latitude"
        '
        'Map_langLabel
        '
        Map_langLabel.AutoSize = True
        Map_langLabel.Location = New System.Drawing.Point(55, 118)
        Map_langLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Map_langLabel.Name = "Map_langLabel"
        Map_langLabel.Size = New System.Drawing.Size(71, 20)
        Map_langLabel.TabIndex = 20
        Map_langLabel.Text = "Longitude"
        '
        'Create_byLabel
        '
        Create_byLabel.AutoSize = True
        Create_byLabel.Location = New System.Drawing.Point(705, 373)
        Create_byLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Create_byLabel.Name = "Create_byLabel"
        Create_byLabel.Size = New System.Drawing.Size(24, 20)
        Create_byLabel.TabIndex = 24
        Create_byLabel.Text = "By"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(405, 377)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(124, 20)
        Label1.TabIndex = 30
        Label1.Text = "Max 500 charakter"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(12, 83)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(119, 20)
        Label2.TabIndex = 37
        Label2.Text = "Klasifikasi Kriminal"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(12, 117)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(77, 20)
        Label3.TabIndex = 39
        Label3.Text = "Kecamatan"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(12, 151)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(41, 20)
        Label4.TabIndex = 42
        Label4.Text = "Judul"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(16, 14)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(128, 25)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "Data Kriminal"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KriminalBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(159, 14)
        Me.IdTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(87, 27)
        Me.IdTextBox.TabIndex = 5
        Me.IdTextBox.TabStop = False
        Me.IdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KriminalBindingSource
        '
        Me.KriminalBindingSource.DataMember = "kriminal"
        Me.KriminalBindingSource.DataSource = Me.SigDataSet
        '
        'SigDataSet
        '
        Me.SigDataSet.DataSetName = "SigDataSet"
        Me.SigDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Id_kecamatanTextBox
        '
        Me.Id_kecamatanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KriminalBindingSource, "id_kecamatan", True))
        Me.Id_kecamatanTextBox.Location = New System.Drawing.Point(259, 78)
        Me.Id_kecamatanTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Id_kecamatanTextBox.Name = "Id_kecamatanTextBox"
        Me.Id_kecamatanTextBox.Size = New System.Drawing.Size(66, 27)
        Me.Id_kecamatanTextBox.TabIndex = 7
        '
        'Id_klassifikasi_kriminalTextBox
        '
        Me.Id_klassifikasi_kriminalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KriminalBindingSource, "id_klassifikasi_kriminal", True))
        Me.Id_klassifikasi_kriminalTextBox.Location = New System.Drawing.Point(361, 78)
        Me.Id_klassifikasi_kriminalTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Id_klassifikasi_kriminalTextBox.Name = "Id_klassifikasi_kriminalTextBox"
        Me.Id_klassifikasi_kriminalTextBox.Size = New System.Drawing.Size(78, 27)
        Me.Id_klassifikasi_kriminalTextBox.TabIndex = 9
        '
        'Kasus_kriminalTextBox
        '
        Me.Kasus_kriminalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KriminalBindingSource, "kasus_kriminal", True))
        Me.Kasus_kriminalTextBox.Location = New System.Drawing.Point(159, 185)
        Me.Kasus_kriminalTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Kasus_kriminalTextBox.MaxLength = 500
        Me.Kasus_kriminalTextBox.Multiline = True
        Me.Kasus_kriminalTextBox.Name = "Kasus_kriminalTextBox"
        Me.Kasus_kriminalTextBox.Size = New System.Drawing.Size(370, 187)
        Me.Kasus_kriminalTextBox.TabIndex = 3
        '
        'Tanggal_kejadianDateTimePicker
        '
        Me.Tanggal_kejadianDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.KriminalBindingSource, "tanggal_kejadian", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "dddd, dd MMM yyyy"))
        Me.Tanggal_kejadianDateTimePicker.Location = New System.Drawing.Point(709, 76)
        Me.Tanggal_kejadianDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tanggal_kejadianDateTimePicker.Name = "Tanggal_kejadianDateTimePicker"
        Me.Tanggal_kejadianDateTimePicker.Size = New System.Drawing.Size(309, 27)
        Me.Tanggal_kejadianDateTimePicker.TabIndex = 4
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KriminalBindingSource, "alamat", True))
        Me.AlamatTextBox.Location = New System.Drawing.Point(7, 24)
        Me.AlamatTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AlamatTextBox.Multiline = True
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.Size = New System.Drawing.Size(445, 56)
        Me.AlamatTextBox.TabIndex = 6
        '
        'Map_latTextBox
        '
        Me.Map_latTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KriminalBindingSource, "map_lat", True))
        Me.Map_latTextBox.Location = New System.Drawing.Point(209, 83)
        Me.Map_latTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Map_latTextBox.Name = "Map_latTextBox"
        Me.Map_latTextBox.Size = New System.Drawing.Size(243, 27)
        Me.Map_latTextBox.TabIndex = 7
        Me.Map_latTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Map_langTextBox
        '
        Me.Map_langTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KriminalBindingSource, "map_lang", True))
        Me.Map_langTextBox.Location = New System.Drawing.Point(209, 113)
        Me.Map_langTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Map_langTextBox.Name = "Map_langTextBox"
        Me.Map_langTextBox.Size = New System.Drawing.Size(243, 27)
        Me.Map_langTextBox.TabIndex = 8
        Me.Map_langTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Create_byTextBox
        '
        Me.Create_byTextBox.Location = New System.Drawing.Point(753, 370)
        Me.Create_byTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Create_byTextBox.Name = "Create_byTextBox"
        Me.Create_byTextBox.ReadOnly = True
        Me.Create_byTextBox.Size = New System.Drawing.Size(265, 27)
        Me.Create_byTextBox.TabIndex = 25
        Me.Create_byTextBox.TabStop = False
        Me.Create_byTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'WaktuKejadianDateTimePicker
        '
        Me.WaktuKejadianDateTimePicker.CustomFormat = "HH:MM:ss"
        Me.WaktuKejadianDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.KriminalBindingSource, "waktu_kejadian", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "hh:mm:ss"))
        Me.WaktuKejadianDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.WaktuKejadianDateTimePicker.Location = New System.Drawing.Point(709, 116)
        Me.WaktuKejadianDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.WaktuKejadianDateTimePicker.Name = "WaktuKejadianDateTimePicker"
        Me.WaktuKejadianDateTimePicker.Size = New System.Drawing.Size(102, 27)
        Me.WaktuKejadianDateTimePicker.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AlamatTextBox)
        Me.GroupBox1.Controls.Add(Me.Map_latTextBox)
        Me.GroupBox1.Controls.Add(Me.Map_langTextBox)
        Me.GroupBox1.Controls.Add(Map_langLabel)
        Me.GroupBox1.Controls.Add(Map_latLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(559, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(459, 152)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alamat"
        '
        'Is_verifiedCheckBox
        '
        Me.Is_verifiedCheckBox.AutoSize = True
        Me.Is_verifiedCheckBox.Location = New System.Drawing.Point(159, 49)
        Me.Is_verifiedCheckBox.Name = "Is_verifiedCheckBox"
        Me.Is_verifiedCheckBox.Size = New System.Drawing.Size(75, 24)
        Me.Is_verifiedCheckBox.TabIndex = 34
        Me.Is_verifiedCheckBox.TabStop = False
        Me.Is_verifiedCheckBox.Text = "Verified"
        Me.Is_verifiedCheckBox.UseVisualStyleBackColor = True
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(943, 575)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton3.TabIndex = 36
        Me.MetroButton3.TabStop = False
        Me.MetroButton3.Text = "Perbaharui"
        Me.MetroButton3.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(943, 575)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton2.TabIndex = 35
        Me.MetroButton2.TabStop = False
        Me.MetroButton2.Text = "Simpan"
        Me.MetroButton2.UseSelectable = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SigDataSet, "klasifikasikriminal.id", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(159, 78)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(280, 28)
        Me.ComboBox1.TabIndex = 0
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SigDataSet, "klasifikasikriminal.id", True))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(159, 112)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(280, 28)
        Me.ComboBox2.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MetroButton1)
        Me.GroupBox2.Controls.Add(Me.MetroGrid1)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 400)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(513, 198)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lampiran"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(432, 17)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 42
        Me.MetroButton1.TabStop = False
        Me.MetroButton1.Text = "Tambah"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.AutoGenerateColumns = False
        Me.MetroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MetroGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.KriminalidDataGridViewTextBoxColumn, Me.FilenameDataGridViewTextBoxColumn, Me.Action})
        Me.MetroGrid1.DataMember = "lampiran"
        Me.MetroGrid1.DataSource = Me.SigDataSet
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle6
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(6, 46)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.ReadOnly = True
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroGrid1.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(501, 146)
        Me.MetroGrid1.TabIndex = 14
        Me.MetroGrid1.TabStop = False
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.FillWeight = 20.0!
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KriminalidDataGridViewTextBoxColumn
        '
        Me.KriminalidDataGridViewTextBoxColumn.DataPropertyName = "kriminal_id"
        Me.KriminalidDataGridViewTextBoxColumn.HeaderText = "kriminal_id"
        Me.KriminalidDataGridViewTextBoxColumn.Name = "KriminalidDataGridViewTextBoxColumn"
        Me.KriminalidDataGridViewTextBoxColumn.ReadOnly = True
        Me.KriminalidDataGridViewTextBoxColumn.Visible = False
        '
        'FilenameDataGridViewTextBoxColumn
        '
        Me.FilenameDataGridViewTextBoxColumn.DataPropertyName = "filename"
        Me.FilenameDataGridViewTextBoxColumn.HeaderText = "File"
        Me.FilenameDataGridViewTextBoxColumn.Name = "FilenameDataGridViewTextBoxColumn"
        Me.FilenameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FilenameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FilenameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Action
        '
        Me.Action.FillWeight = 20.0!
        Me.Action.HeaderText = "Action"
        Me.Action.Name = "Action"
        Me.Action.ReadOnly = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox_judul
        '
        Me.TextBox_judul.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KriminalBindingSource, "map_lat", True))
        Me.TextBox_judul.Location = New System.Drawing.Point(159, 148)
        Me.TextBox_judul.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_judul.Name = "TextBox_judul"
        Me.TextBox_judul.Size = New System.Drawing.Size(280, 27)
        Me.TextBox_judul.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(159, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 40)
        Me.Panel1.TabIndex = 43
        '
        'DialogDataKriminal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 610)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox_judul)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.Is_verifiedCheckBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.WaktuKejadianDateTimePicker)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.Id_kecamatanTextBox)
        Me.Controls.Add(Me.Id_klassifikasi_kriminalTextBox)
        Me.Controls.Add(Kasus_kriminalLabel)
        Me.Controls.Add(Me.Kasus_kriminalTextBox)
        Me.Controls.Add(Tanggal_kejadianLabel)
        Me.Controls.Add(Me.Tanggal_kejadianDateTimePicker)
        Me.Controls.Add(Waktu_kejadianLabel)
        Me.Controls.Add(Create_byLabel)
        Me.Controls.Add(Me.Create_byTextBox)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogDataKriminal"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DialogDataKriminal"
        CType(Me.KriminalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SigDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents SigDataSet As SIG_Crime_State.SigDataSet
    Friend WithEvents KriminalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_kecamatanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_klassifikasi_kriminalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kasus_kriminalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tanggal_kejadianDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AlamatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Map_latTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Map_langTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Create_byTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WaktuKejadianDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Is_verifiedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KriminalidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FilenameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Action As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TextBox_judul As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class

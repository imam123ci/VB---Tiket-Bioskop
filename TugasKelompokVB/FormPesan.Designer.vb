<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPesan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPesan))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.SirkusIdDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JudulDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SinopsisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VideoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PosterDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.SirkusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SirkusdbDataSet = New TugasKelompokVB.sirkusdbDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.WaktusirkusIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SirkusIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JamMulaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JamSelesaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HariDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaktusirkusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Waktu = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBoxNamaSirkus = New System.Windows.Forms.ComboBox()
        Me.SirkusBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.BangkusirkusIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SirkusIdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BangkuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KapasitasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BangkusirkusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BanyakTiket = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LabelTotalHarga = New System.Windows.Forms.Label()
        Me.JenisTiket = New System.Windows.Forms.ComboBox()
        Me.BangkusirkusBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Waktu_sirkusTableAdapter = New TugasKelompokVB.sirkusdbDataSetTableAdapters.waktu_sirkusTableAdapter()
        Me.Bangku_sirkusTableAdapter = New TugasKelompokVB.sirkusdbDataSetTableAdapters.bangku_sirkusTableAdapter()
        Me.SirkusTableAdapter = New TugasKelompokVB.sirkusdbDataSetTableAdapters.sirkusTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SirkusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SirkusdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaktusirkusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SirkusBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BangkusirkusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BanyakTiket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BangkusirkusBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(797, 493)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = Global.TugasKelompokVB.My.Resources.Resources.wallpaper
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabPage1.Controls.Add(Me.DataGridView3)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Waktu)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.ComboBoxNamaSirkus)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabPage1.Size = New System.Drawing.Size(789, 467)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "SHOWS"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SirkusIdDataGridViewTextBoxColumn2, Me.JudulDataGridViewTextBoxColumn, Me.SinopsisDataGridViewTextBoxColumn, Me.VideoDataGridViewTextBoxColumn, Me.PosterDataGridViewImageColumn})
        Me.DataGridView3.DataSource = Me.SirkusBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(205, 180)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(543, 108)
        Me.DataGridView3.TabIndex = 16
        Me.DataGridView3.Visible = False
        '
        'SirkusIdDataGridViewTextBoxColumn2
        '
        Me.SirkusIdDataGridViewTextBoxColumn2.DataPropertyName = "sirkusId"
        Me.SirkusIdDataGridViewTextBoxColumn2.HeaderText = "sirkusId"
        Me.SirkusIdDataGridViewTextBoxColumn2.Name = "SirkusIdDataGridViewTextBoxColumn2"
        Me.SirkusIdDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'JudulDataGridViewTextBoxColumn
        '
        Me.JudulDataGridViewTextBoxColumn.DataPropertyName = "judul"
        Me.JudulDataGridViewTextBoxColumn.HeaderText = "judul"
        Me.JudulDataGridViewTextBoxColumn.Name = "JudulDataGridViewTextBoxColumn"
        '
        'SinopsisDataGridViewTextBoxColumn
        '
        Me.SinopsisDataGridViewTextBoxColumn.DataPropertyName = "sinopsis"
        Me.SinopsisDataGridViewTextBoxColumn.HeaderText = "sinopsis"
        Me.SinopsisDataGridViewTextBoxColumn.Name = "SinopsisDataGridViewTextBoxColumn"
        '
        'VideoDataGridViewTextBoxColumn
        '
        Me.VideoDataGridViewTextBoxColumn.DataPropertyName = "video"
        Me.VideoDataGridViewTextBoxColumn.HeaderText = "video"
        Me.VideoDataGridViewTextBoxColumn.Name = "VideoDataGridViewTextBoxColumn"
        '
        'PosterDataGridViewImageColumn
        '
        Me.PosterDataGridViewImageColumn.DataPropertyName = "poster"
        Me.PosterDataGridViewImageColumn.HeaderText = "poster"
        Me.PosterDataGridViewImageColumn.Name = "PosterDataGridViewImageColumn"
        '
        'SirkusBindingSource
        '
        Me.SirkusBindingSource.DataMember = "sirkus"
        Me.SirkusBindingSource.DataSource = Me.SirkusdbDataSet
        '
        'SirkusdbDataSet
        '
        Me.SirkusdbDataSet.DataSetName = "sirkusdbDataSet"
        Me.SirkusdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WaktusirkusIdDataGridViewTextBoxColumn, Me.SirkusIdDataGridViewTextBoxColumn, Me.JamMulaiDataGridViewTextBoxColumn, Me.JamSelesaiDataGridViewTextBoxColumn, Me.HariDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.WaktusirkusBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(209, 127)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(539, 150)
        Me.DataGridView1.TabIndex = 15
        Me.DataGridView1.Visible = False
        '
        'WaktusirkusIdDataGridViewTextBoxColumn
        '
        Me.WaktusirkusIdDataGridViewTextBoxColumn.DataPropertyName = "waktu_sirkusId"
        Me.WaktusirkusIdDataGridViewTextBoxColumn.HeaderText = "waktu_sirkusId"
        Me.WaktusirkusIdDataGridViewTextBoxColumn.Name = "WaktusirkusIdDataGridViewTextBoxColumn"
        Me.WaktusirkusIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SirkusIdDataGridViewTextBoxColumn
        '
        Me.SirkusIdDataGridViewTextBoxColumn.DataPropertyName = "sirkusId"
        Me.SirkusIdDataGridViewTextBoxColumn.HeaderText = "sirkusId"
        Me.SirkusIdDataGridViewTextBoxColumn.Name = "SirkusIdDataGridViewTextBoxColumn"
        '
        'JamMulaiDataGridViewTextBoxColumn
        '
        Me.JamMulaiDataGridViewTextBoxColumn.DataPropertyName = "jamMulai"
        Me.JamMulaiDataGridViewTextBoxColumn.HeaderText = "jamMulai"
        Me.JamMulaiDataGridViewTextBoxColumn.Name = "JamMulaiDataGridViewTextBoxColumn"
        '
        'JamSelesaiDataGridViewTextBoxColumn
        '
        Me.JamSelesaiDataGridViewTextBoxColumn.DataPropertyName = "jamSelesai"
        Me.JamSelesaiDataGridViewTextBoxColumn.HeaderText = "jamSelesai"
        Me.JamSelesaiDataGridViewTextBoxColumn.Name = "JamSelesaiDataGridViewTextBoxColumn"
        '
        'HariDataGridViewTextBoxColumn
        '
        Me.HariDataGridViewTextBoxColumn.DataPropertyName = "hari"
        Me.HariDataGridViewTextBoxColumn.HeaderText = "hari"
        Me.HariDataGridViewTextBoxColumn.Name = "HariDataGridViewTextBoxColumn"
        '
        'WaktusirkusBindingSource
        '
        Me.WaktusirkusBindingSource.DataMember = "waktu_sirkus"
        Me.WaktusirkusBindingSource.DataSource = Me.SirkusdbDataSet
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Brown
        Me.Button4.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(672, 427)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(109, 32)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "CHOOSE"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(177, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "<< CLICK"
        '
        'Waktu
        '
        Me.Waktu.AutoSize = True
        Me.Waktu.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Waktu.Location = New System.Drawing.Point(288, 368)
        Me.Waktu.Name = "Waktu"
        Me.Waktu.Size = New System.Drawing.Size(33, 18)
        Me.Waktu.TabIndex = 12
        Me.Waktu.Text = ". . . ."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(288, 333)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Date and Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(288, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = ". . . ."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(408, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = ". . . ."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "About The Show:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Brown
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(75, 368)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 28)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "DETAILS"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ComboBoxNamaSirkus
        '
        Me.ComboBoxNamaSirkus.BackColor = System.Drawing.Color.DarkRed
        Me.ComboBoxNamaSirkus.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SirkusBindingSource1, "judul", True))
        Me.ComboBoxNamaSirkus.DataSource = Me.SirkusBindingSource1
        Me.ComboBoxNamaSirkus.DisplayMember = "judul"
        Me.ComboBoxNamaSirkus.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxNamaSirkus.ForeColor = System.Drawing.Color.White
        Me.ComboBoxNamaSirkus.FormattingEnabled = True
        Me.ComboBoxNamaSirkus.Location = New System.Drawing.Point(26, 43)
        Me.ComboBoxNamaSirkus.Name = "ComboBoxNamaSirkus"
        Me.ComboBoxNamaSirkus.Size = New System.Drawing.Size(150, 27)
        Me.ComboBoxNamaSirkus.TabIndex = 5
        Me.ComboBoxNamaSirkus.ValueMember = "judul"
        '
        'SirkusBindingSource1
        '
        Me.SirkusBindingSource1.DataMember = "sirkus"
        Me.SirkusBindingSource1.DataSource = Me.SirkusdbDataSet
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 257)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "time"
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = Global.TugasKelompokVB.My.Resources.Resources.wallpaper
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.BanyakTiket)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.LabelTotalHarga)
        Me.TabPage2.Controls.Add(Me.JenisTiket)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(789, 467)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "SEATS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BangkusirkusIdDataGridViewTextBoxColumn, Me.SirkusIdDataGridViewTextBoxColumn1, Me.BangkuDataGridViewTextBoxColumn, Me.KapasitasDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.BangkusirkusBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(17, 74)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(540, 150)
        Me.DataGridView2.TabIndex = 15
        Me.DataGridView2.Visible = False
        '
        'BangkusirkusIdDataGridViewTextBoxColumn
        '
        Me.BangkusirkusIdDataGridViewTextBoxColumn.DataPropertyName = "bangku_sirkusId"
        Me.BangkusirkusIdDataGridViewTextBoxColumn.HeaderText = "bangku_sirkusId"
        Me.BangkusirkusIdDataGridViewTextBoxColumn.Name = "BangkusirkusIdDataGridViewTextBoxColumn"
        Me.BangkusirkusIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SirkusIdDataGridViewTextBoxColumn1
        '
        Me.SirkusIdDataGridViewTextBoxColumn1.DataPropertyName = "sirkusId"
        Me.SirkusIdDataGridViewTextBoxColumn1.HeaderText = "sirkusId"
        Me.SirkusIdDataGridViewTextBoxColumn1.Name = "SirkusIdDataGridViewTextBoxColumn1"
        '
        'BangkuDataGridViewTextBoxColumn
        '
        Me.BangkuDataGridViewTextBoxColumn.DataPropertyName = "bangku"
        Me.BangkuDataGridViewTextBoxColumn.HeaderText = "bangku"
        Me.BangkuDataGridViewTextBoxColumn.Name = "BangkuDataGridViewTextBoxColumn"
        '
        'KapasitasDataGridViewTextBoxColumn
        '
        Me.KapasitasDataGridViewTextBoxColumn.DataPropertyName = "kapasitas"
        Me.KapasitasDataGridViewTextBoxColumn.HeaderText = "kapasitas"
        Me.KapasitasDataGridViewTextBoxColumn.Name = "KapasitasDataGridViewTextBoxColumn"
        '
        'HargaDataGridViewTextBoxColumn
        '
        Me.HargaDataGridViewTextBoxColumn.DataPropertyName = "harga"
        Me.HargaDataGridViewTextBoxColumn.HeaderText = "harga"
        Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
        '
        'BangkusirkusBindingSource
        '
        Me.BangkusirkusBindingSource.DataMember = "bangku_sirkus"
        Me.BangkusirkusBindingSource.DataSource = Me.SirkusdbDataSet
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Tomato
        Me.Button5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(457, 425)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(132, 34)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Back"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(769, 281)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(0, 13)
        Me.Label17.TabIndex = 13
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Brown
        Me.Button3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(599, 425)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(132, 34)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "CHECKOUT"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(502, 354)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(168, 19)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "TOTAL PAYMENT"
        '
        'BanyakTiket
        '
        Me.BanyakTiket.BackColor = System.Drawing.Color.Brown
        Me.BanyakTiket.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BanyakTiket.ForeColor = System.Drawing.Color.White
        Me.BanyakTiket.Location = New System.Drawing.Point(625, 304)
        Me.BanyakTiket.Name = "BanyakTiket"
        Me.BanyakTiket.Size = New System.Drawing.Size(73, 29)
        Me.BanyakTiket.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(479, 281)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(222, 19)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "CHOOSE YOUR TICKETS"
        '
        'LabelTotalHarga
        '
        Me.LabelTotalHarga.AutoSize = True
        Me.LabelTotalHarga.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalHarga.Location = New System.Drawing.Point(545, 394)
        Me.LabelTotalHarga.Name = "LabelTotalHarga"
        Me.LabelTotalHarga.Size = New System.Drawing.Size(85, 22)
        Me.LabelTotalHarga.TabIndex = 8
        Me.LabelTotalHarga.Text = ". . . . . . . ."
        '
        'JenisTiket
        '
        Me.JenisTiket.BackColor = System.Drawing.Color.Brown
        Me.JenisTiket.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BangkusirkusBindingSource1, "bangku", True))
        Me.JenisTiket.DataSource = Me.BangkusirkusBindingSource1
        Me.JenisTiket.DisplayMember = "bangku"
        Me.JenisTiket.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JenisTiket.ForeColor = System.Drawing.Color.White
        Me.JenisTiket.FormattingEnabled = True
        Me.JenisTiket.Location = New System.Drawing.Point(483, 303)
        Me.JenisTiket.Name = "JenisTiket"
        Me.JenisTiket.Size = New System.Drawing.Size(121, 30)
        Me.JenisTiket.TabIndex = 7
        Me.JenisTiket.ValueMember = "bangku"
        '
        'BangkusirkusBindingSource1
        '
        Me.BangkusirkusBindingSource1.DataMember = "bangku_sirkus"
        Me.BangkusirkusBindingSource1.DataSource = Me.SirkusdbDataSet
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("High Tower Text", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(500, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(182, 34)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "PRICE LIST"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Olive
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(484, 227)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(215, 26)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "CAT4 : IDR 600.000   "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.DarkRed
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(484, 188)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(215, 26)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "CAT3 : IDR 800.000   "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.DarkSalmon
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(484, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(214, 26)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "CAT2 : IDR 1.000.000"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.LightSalmon
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(484, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(214, 26)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "CAT1 : IDR 1.500.000"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Peru
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(486, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(213, 26)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "VIP    : IDR 2.000.000"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(405, 467)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Waktu_sirkusTableAdapter
        '
        Me.Waktu_sirkusTableAdapter.ClearBeforeFill = True
        '
        'Bangku_sirkusTableAdapter
        '
        Me.Bangku_sirkusTableAdapter.ClearBeforeFill = True
        '
        'SirkusTableAdapter
        '
        Me.SirkusTableAdapter.ClearBeforeFill = True
        '
        'FormPesan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 493)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormPesan"
        Me.Text = "Pesan Tiket"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SirkusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SirkusdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaktusirkusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SirkusBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BangkusirkusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BanyakTiket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BangkusirkusBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBoxNamaSirkus As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Waktu As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents JenisTiket As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents BanyakTiket As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents LabelTotalHarga As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents SirkusdbDataSet As sirkusdbDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents WaktusirkusBindingSource As BindingSource
    Friend WithEvents Waktu_sirkusTableAdapter As sirkusdbDataSetTableAdapters.waktu_sirkusTableAdapter
    Friend WithEvents WaktusirkusIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SirkusIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JamMulaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JamSelesaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HariDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents BangkusirkusBindingSource As BindingSource
    Friend WithEvents Bangku_sirkusTableAdapter As sirkusdbDataSetTableAdapters.bangku_sirkusTableAdapter
    Friend WithEvents BangkusirkusIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SirkusIdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BangkuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KapasitasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BangkusirkusBindingSource1 As BindingSource
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents SirkusBindingSource As BindingSource
    Friend WithEvents SirkusTableAdapter As sirkusdbDataSetTableAdapters.sirkusTableAdapter
    Friend WithEvents SirkusIdDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents JudulDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SinopsisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VideoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PosterDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents SirkusBindingSource1 As BindingSource
End Class

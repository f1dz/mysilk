<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrsSample
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtNmJenisSample = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtKdJenisSample = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.txtCari = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.grid = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.txtTutupSampleLain = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtBahanWadahLain = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtWadahSampleLain = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtBentukSampleLain = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtSuhuSatuan = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtJumlahSatuan = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.txtSuhu = New DevComponents.Editors.DoubleInput()
        Me.txtJumlah = New DevComponents.Editors.DoubleInput()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtKetSample = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.cbTutupSample = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.cbBahanWadah = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.cbWadahSample = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.cbBentukSample = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtKdSample = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnExit = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.txtMerk = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.txtNmPengambil = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.BtnTambah = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSuhu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.BtnTambah)
        Me.GroupPanel1.Controls.Add(Me.txtNmPengambil)
        Me.GroupPanel1.Controls.Add(Me.LabelX12)
        Me.GroupPanel1.Controls.Add(Me.txtMerk)
        Me.GroupPanel1.Controls.Add(Me.LabelX11)
        Me.GroupPanel1.Controls.Add(Me.txtNmJenisSample)
        Me.GroupPanel1.Controls.Add(Me.txtKdJenisSample)
        Me.GroupPanel1.Controls.Add(Me.LabelX10)
        Me.GroupPanel1.Controls.Add(Me.txtCari)
        Me.GroupPanel1.Controls.Add(Me.PanelEx1)
        Me.GroupPanel1.Controls.Add(Me.LabelX9)
        Me.GroupPanel1.Controls.Add(Me.txtTutupSampleLain)
        Me.GroupPanel1.Controls.Add(Me.txtBahanWadahLain)
        Me.GroupPanel1.Controls.Add(Me.txtWadahSampleLain)
        Me.GroupPanel1.Controls.Add(Me.txtBentukSampleLain)
        Me.GroupPanel1.Controls.Add(Me.txtSuhuSatuan)
        Me.GroupPanel1.Controls.Add(Me.txtJumlahSatuan)
        Me.GroupPanel1.Controls.Add(Me.LabelX8)
        Me.GroupPanel1.Controls.Add(Me.txtSuhu)
        Me.GroupPanel1.Controls.Add(Me.txtJumlah)
        Me.GroupPanel1.Controls.Add(Me.LabelX7)
        Me.GroupPanel1.Controls.Add(Me.LabelX6)
        Me.GroupPanel1.Controls.Add(Me.txtKetSample)
        Me.GroupPanel1.Controls.Add(Me.LabelX5)
        Me.GroupPanel1.Controls.Add(Me.cbTutupSample)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.cbBahanWadah)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.cbWadahSample)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.cbBentukSample)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.txtKdSample)
        Me.GroupPanel1.Location = New System.Drawing.Point(3, 7)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(754, 356)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.Class = ""
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.Class = ""
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.Class = ""
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "Sample"
        '
        'txtNmJenisSample
        '
        '
        '
        '
        Me.txtNmJenisSample.Border.Class = "TextBoxBorder"
        Me.txtNmJenisSample.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNmJenisSample.Enabled = False
        Me.txtNmJenisSample.Location = New System.Drawing.Point(167, 29)
        Me.txtNmJenisSample.Name = "txtNmJenisSample"
        Me.txtNmJenisSample.Size = New System.Drawing.Size(206, 20)
        Me.txtNmJenisSample.TabIndex = 57
        '
        'txtKdJenisSample
        '
        '
        '
        '
        Me.txtKdJenisSample.Border.Class = "TextBoxBorder"
        Me.txtKdJenisSample.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKdJenisSample.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKdJenisSample.Location = New System.Drawing.Point(121, 29)
        Me.txtKdJenisSample.Name = "txtKdJenisSample"
        Me.txtKdJenisSample.Size = New System.Drawing.Size(40, 20)
        Me.txtKdJenisSample.TabIndex = 56
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.Class = ""
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Location = New System.Drawing.Point(443, 12)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX10.Size = New System.Drawing.Size(40, 23)
        Me.LabelX10.TabIndex = 55
        Me.LabelX10.Text = "Cari"
        '
        'txtCari
        '
        '
        '
        '
        Me.txtCari.Border.Class = "TextBoxBorder"
        Me.txtCari.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCari.Location = New System.Drawing.Point(489, 15)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(221, 20)
        Me.txtCari.TabIndex = 0
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.grid)
        Me.PanelEx1.Location = New System.Drawing.Point(464, 41)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(276, 263)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 53
        Me.PanelEx1.Text = "PanelEx1"
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.grid.Location = New System.Drawing.Point(0, 0)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.Size = New System.Drawing.Size(276, 263)
        Me.grid.TabIndex = 0
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.Class = ""
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(40, 29)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX9.Size = New System.Drawing.Size(75, 23)
        Me.LabelX9.TabIndex = 52
        Me.LabelX9.Text = "Jenis Sample"
        '
        'txtTutupSampleLain
        '
        '
        '
        '
        Me.txtTutupSampleLain.Border.Class = "TextBoxBorder"
        Me.txtTutupSampleLain.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTutupSampleLain.Enabled = False
        Me.txtTutupSampleLain.Location = New System.Drawing.Point(247, 241)
        Me.txtTutupSampleLain.Name = "txtTutupSampleLain"
        Me.txtTutupSampleLain.Size = New System.Drawing.Size(206, 20)
        Me.txtTutupSampleLain.TabIndex = 10
        '
        'txtBahanWadahLain
        '
        '
        '
        '
        Me.txtBahanWadahLain.Border.Class = "TextBoxBorder"
        Me.txtBahanWadahLain.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBahanWadahLain.Enabled = False
        Me.txtBahanWadahLain.Location = New System.Drawing.Point(247, 215)
        Me.txtBahanWadahLain.Name = "txtBahanWadahLain"
        Me.txtBahanWadahLain.Size = New System.Drawing.Size(206, 20)
        Me.txtBahanWadahLain.TabIndex = 9
        '
        'txtWadahSampleLain
        '
        '
        '
        '
        Me.txtWadahSampleLain.Border.Class = "TextBoxBorder"
        Me.txtWadahSampleLain.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtWadahSampleLain.Enabled = False
        Me.txtWadahSampleLain.Location = New System.Drawing.Point(247, 189)
        Me.txtWadahSampleLain.Name = "txtWadahSampleLain"
        Me.txtWadahSampleLain.Size = New System.Drawing.Size(206, 20)
        Me.txtWadahSampleLain.TabIndex = 8
        '
        'txtBentukSampleLain
        '
        '
        '
        '
        Me.txtBentukSampleLain.Border.Class = "TextBoxBorder"
        Me.txtBentukSampleLain.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBentukSampleLain.Enabled = False
        Me.txtBentukSampleLain.Location = New System.Drawing.Point(247, 107)
        Me.txtBentukSampleLain.Name = "txtBentukSampleLain"
        Me.txtBentukSampleLain.Size = New System.Drawing.Size(206, 20)
        Me.txtBentukSampleLain.TabIndex = 2
        '
        'txtSuhuSatuan
        '
        '
        '
        '
        Me.txtSuhuSatuan.Border.Class = "TextBoxBorder"
        Me.txtSuhuSatuan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSuhuSatuan.Location = New System.Drawing.Point(207, 163)
        Me.txtSuhuSatuan.Name = "txtSuhuSatuan"
        Me.txtSuhuSatuan.Size = New System.Drawing.Size(100, 20)
        Me.txtSuhuSatuan.TabIndex = 7
        '
        'txtJumlahSatuan
        '
        '
        '
        '
        Me.txtJumlahSatuan.Border.Class = "TextBoxBorder"
        Me.txtJumlahSatuan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtJumlahSatuan.Location = New System.Drawing.Point(207, 134)
        Me.txtJumlahSatuan.Name = "txtJumlahSatuan"
        Me.txtJumlahSatuan.Size = New System.Drawing.Size(100, 20)
        Me.txtJumlahSatuan.TabIndex = 5
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.Class = ""
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(28, 269)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX8.Size = New System.Drawing.Size(86, 23)
        Me.LabelX8.TabIndex = 50
        Me.LabelX8.Text = "Keterangan"
        '
        'txtSuhu
        '
        Me.txtSuhu.AllowEmptyState = False
        '
        '
        '
        Me.txtSuhu.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtSuhu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSuhu.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtSuhu.Increment = 1.0R
        Me.txtSuhu.Location = New System.Drawing.Point(121, 163)
        Me.txtSuhu.MaxValue = 100000.0R
        Me.txtSuhu.MinValue = 0.0R
        Me.txtSuhu.Name = "txtSuhu"
        Me.txtSuhu.ShowUpDown = True
        Me.txtSuhu.Size = New System.Drawing.Size(80, 20)
        Me.txtSuhu.TabIndex = 6
        '
        'txtJumlah
        '
        Me.txtJumlah.AllowEmptyState = False
        '
        '
        '
        Me.txtJumlah.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtJumlah.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtJumlah.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtJumlah.Increment = 1.0R
        Me.txtJumlah.Location = New System.Drawing.Point(121, 134)
        Me.txtJumlah.MaxValue = 100000.0R
        Me.txtJumlah.MinValue = 0.0R
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.ShowUpDown = True
        Me.txtJumlah.Size = New System.Drawing.Size(80, 20)
        Me.txtJumlah.TabIndex = 4
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.Class = ""
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(40, 160)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX7.Size = New System.Drawing.Size(75, 23)
        Me.LabelX7.TabIndex = 47
        Me.LabelX7.Text = "Suhu - Satuan"
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(13, 131)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX6.Size = New System.Drawing.Size(102, 23)
        Me.LabelX6.TabIndex = 46
        Me.LabelX6.Text = "Jumlah - Satuan"
        '
        'txtKetSample
        '
        '
        '
        '
        Me.txtKetSample.Border.Class = "TextBoxBorder"
        Me.txtKetSample.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKetSample.Location = New System.Drawing.Point(120, 267)
        Me.txtKetSample.Multiline = True
        Me.txtKetSample.Name = "txtKetSample"
        Me.txtKetSample.Size = New System.Drawing.Size(333, 63)
        Me.txtKetSample.TabIndex = 11
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(29, 240)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX5.Size = New System.Drawing.Size(86, 23)
        Me.LabelX5.TabIndex = 44
        Me.LabelX5.Text = "Tutup Sample"
        '
        'cbTutupSample
        '
        Me.cbTutupSample.DisplayMember = "Text"
        Me.cbTutupSample.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbTutupSample.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTutupSample.FormattingEnabled = True
        Me.cbTutupSample.ItemHeight = 14
        Me.cbTutupSample.Location = New System.Drawing.Point(120, 241)
        Me.cbTutupSample.Name = "cbTutupSample"
        Me.cbTutupSample.Size = New System.Drawing.Size(121, 20)
        Me.cbTutupSample.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbTutupSample.TabIndex = 10
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(29, 214)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX4.Size = New System.Drawing.Size(86, 23)
        Me.LabelX4.TabIndex = 41
        Me.LabelX4.Text = "Bahan Wadah"
        '
        'cbBahanWadah
        '
        Me.cbBahanWadah.DisplayMember = "Text"
        Me.cbBahanWadah.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbBahanWadah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBahanWadah.FormattingEnabled = True
        Me.cbBahanWadah.ItemHeight = 14
        Me.cbBahanWadah.Location = New System.Drawing.Point(120, 215)
        Me.cbBahanWadah.Name = "cbBahanWadah"
        Me.cbBahanWadah.Size = New System.Drawing.Size(121, 20)
        Me.cbBahanWadah.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbBahanWadah.TabIndex = 9
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(29, 188)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX3.Size = New System.Drawing.Size(86, 23)
        Me.LabelX3.TabIndex = 38
        Me.LabelX3.Text = "Wadah Sample"
        '
        'cbWadahSample
        '
        Me.cbWadahSample.DisplayMember = "Text"
        Me.cbWadahSample.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbWadahSample.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWadahSample.FormattingEnabled = True
        Me.cbWadahSample.ItemHeight = 14
        Me.cbWadahSample.Location = New System.Drawing.Point(120, 189)
        Me.cbWadahSample.Name = "cbWadahSample"
        Me.cbWadahSample.Size = New System.Drawing.Size(121, 20)
        Me.cbWadahSample.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbWadahSample.TabIndex = 8
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(40, 106)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 35
        Me.LabelX2.Text = "Bentuk Sample"
        '
        'cbBentukSample
        '
        Me.cbBentukSample.DisplayMember = "Text"
        Me.cbBentukSample.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbBentukSample.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBentukSample.FormattingEnabled = True
        Me.cbBentukSample.ItemHeight = 14
        Me.cbBentukSample.Location = New System.Drawing.Point(121, 107)
        Me.cbBentukSample.Name = "cbBentukSample"
        Me.cbBentukSample.Size = New System.Drawing.Size(121, 20)
        Me.cbBentukSample.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbBentukSample.TabIndex = 3
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(39, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 32
        Me.LabelX1.Text = "No. Sample"
        '
        'txtKdSample
        '
        '
        '
        '
        Me.txtKdSample.Border.Class = "TextBoxBorder"
        Me.txtKdSample.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKdSample.Enabled = False
        Me.txtKdSample.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKdSample.Location = New System.Drawing.Point(121, 3)
        Me.txtKdSample.MaxLength = 10
        Me.txtKdSample.Name = "txtKdSample"
        Me.txtKdSample.ReadOnly = True
        Me.txtKdSample.Size = New System.Drawing.Size(78, 20)
        Me.txtKdSample.TabIndex = 0
        Me.txtKdSample.TabStop = False
        Me.txtKdSample.WatermarkText = "BARU"
        '
        'btnExit
        '
        Me.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExit.Location = New System.Drawing.Point(682, 369)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 34)
        Me.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Location = New System.Drawing.Point(601, 369)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 34)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "&Save"
        '
        'txtMerk
        '
        '
        '
        '
        Me.txtMerk.Border.Class = "TextBoxBorder"
        Me.txtMerk.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMerk.Location = New System.Drawing.Point(121, 55)
        Me.txtMerk.MaxLength = 50
        Me.txtMerk.Name = "txtMerk"
        Me.txtMerk.Size = New System.Drawing.Size(252, 20)
        Me.txtMerk.TabIndex = 1
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX11.BackgroundStyle.Class = ""
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Location = New System.Drawing.Point(40, 55)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX11.Size = New System.Drawing.Size(75, 23)
        Me.LabelX11.TabIndex = 58
        Me.LabelX11.Text = "Merk"
        '
        'txtNmPengambil
        '
        '
        '
        '
        Me.txtNmPengambil.Border.Class = "TextBoxBorder"
        Me.txtNmPengambil.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNmPengambil.Location = New System.Drawing.Point(121, 81)
        Me.txtNmPengambil.MaxLength = 50
        Me.txtNmPengambil.Name = "txtNmPengambil"
        Me.txtNmPengambil.Size = New System.Drawing.Size(252, 20)
        Me.txtNmPengambil.TabIndex = 2
        '
        'LabelX12
        '
        Me.LabelX12.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX12.BackgroundStyle.Class = ""
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Location = New System.Drawing.Point(40, 81)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX12.Size = New System.Drawing.Size(75, 23)
        Me.LabelX12.TabIndex = 61
        Me.LabelX12.Text = "Pengambil"
        '
        'BtnTambah
        '
        Me.BtnTambah.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnTambah.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnTambah.Location = New System.Drawing.Point(716, 15)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(24, 20)
        Me.BtnTambah.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnTambah.TabIndex = 62
        Me.BtnTambah.Text = "+"
        '
        'frmTrsSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 407)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupPanel1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTrsSample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penerimaan Sample"
        Me.TopMost = True
        Me.GroupPanel1.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSuhu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJumlah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtSuhuSatuan As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtJumlahSatuan As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSuhu As DevComponents.Editors.DoubleInput
    Friend WithEvents txtJumlah As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtKetSample As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbTutupSample As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbBahanWadah As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbWadahSample As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbBentukSample As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtKdSample As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtTutupSampleLain As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtBahanWadahLain As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtWadahSampleLain As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtBentukSampleLain As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnExit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCari As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtKdJenisSample As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNmJenisSample As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents grid As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents txtMerk As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNmPengambil As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnTambah As DevComponents.DotNetBar.ButtonX
End Class

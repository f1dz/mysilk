<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrsRegistrasi
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnVoid = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnExit = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.dgvSample = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.txtKdRegNew = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtKotaRujuk = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtAlmRujuk2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtAlmRujuk1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNmRujuk = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtJamReg = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtTglReg = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.txtKdRujuk = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtKdReg = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.xTimer = New System.Windows.Forms.Timer(Me.components)
        Me.kodeSample = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kodeMR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ketSample = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupPanel1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.dgvSample, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        CType(Me.txtTglReg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btnVoid)
        Me.GroupPanel1.Controls.Add(Me.btnSave)
        Me.GroupPanel1.Controls.Add(Me.btnExit)
        Me.GroupPanel1.Controls.Add(Me.PanelEx2)
        Me.GroupPanel1.Controls.Add(Me.PanelEx1)
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 3)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(780, 503)
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
        '
        'btnVoid
        '
        Me.btnVoid.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnVoid.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnVoid.Location = New System.Drawing.Point(609, 455)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(75, 35)
        Me.btnVoid.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnVoid.TabIndex = 4
        Me.btnVoid.Text = "&Void"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Location = New System.Drawing.Point(528, 455)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 35)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save"
        '
        'btnExit
        '
        Me.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExit.Location = New System.Drawing.Point(690, 455)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 35)
        Me.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "&Exit"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.dgvSample)
        Me.PanelEx2.Location = New System.Drawing.Point(9, 148)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(756, 301)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 1
        Me.PanelEx2.Text = "PanelEx2"
        '
        'dgvSample
        '
        Me.dgvSample.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSample.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSample.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSample.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSample.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodeSample, Me.kodeMR, Me.ketSample})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSample.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSample.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSample.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvSample.Location = New System.Drawing.Point(0, 0)
        Me.dgvSample.Name = "dgvSample"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSample.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSample.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvSample.Size = New System.Drawing.Size(756, 301)
        Me.dgvSample.TabIndex = 0
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.txtKdRegNew)
        Me.PanelEx1.Controls.Add(Me.LabelX5)
        Me.PanelEx1.Controls.Add(Me.LabelX4)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Controls.Add(Me.txtKotaRujuk)
        Me.PanelEx1.Controls.Add(Me.txtAlmRujuk2)
        Me.PanelEx1.Controls.Add(Me.txtAlmRujuk1)
        Me.PanelEx1.Controls.Add(Me.txtNmRujuk)
        Me.PanelEx1.Controls.Add(Me.txtJamReg)
        Me.PanelEx1.Controls.Add(Me.txtTglReg)
        Me.PanelEx1.Controls.Add(Me.txtKdRujuk)
        Me.PanelEx1.Controls.Add(Me.txtKdReg)
        Me.PanelEx1.Location = New System.Drawing.Point(9, 7)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(756, 135)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'txtKdRegNew
        '
        '
        '
        '
        Me.txtKdRegNew.Border.Class = "TextBoxBorder"
        Me.txtKdRegNew.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKdRegNew.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKdRegNew.Enabled = False
        Me.txtKdRegNew.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKdRegNew.Location = New System.Drawing.Point(202, 19)
        Me.txtKdRegNew.MaxLength = 10
        Me.txtKdRegNew.Name = "txtKdRegNew"
        Me.txtKdRegNew.ReadOnly = True
        Me.txtKdRegNew.Size = New System.Drawing.Size(78, 20)
        Me.txtKdRegNew.TabIndex = 13
        Me.txtKdRegNew.TabStop = False
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(385, 45)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX5.Size = New System.Drawing.Size(75, 23)
        Me.LabelX5.TabIndex = 12
        Me.LabelX5.Text = "Alamat"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(385, 19)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX4.Size = New System.Drawing.Size(75, 23)
        Me.LabelX4.TabIndex = 11
        Me.LabelX4.Text = "Nama Perujuk"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(38, 71)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 10
        Me.LabelX3.Text = "Tanggal/Jam"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(38, 42)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 9
        Me.LabelX2.Text = "Perujuk"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(38, 19)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 8
        Me.LabelX1.Text = "Kode Reg"
        '
        'txtKotaRujuk
        '
        '
        '
        '
        Me.txtKotaRujuk.Border.Class = "TextBoxBorder"
        Me.txtKotaRujuk.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKotaRujuk.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKotaRujuk.Location = New System.Drawing.Point(466, 97)
        Me.txtKotaRujuk.MaxLength = 100
        Me.txtKotaRujuk.Name = "txtKotaRujuk"
        Me.txtKotaRujuk.ReadOnly = True
        Me.txtKotaRujuk.Size = New System.Drawing.Size(266, 20)
        Me.txtKotaRujuk.TabIndex = 7
        Me.txtKotaRujuk.TabStop = False
        '
        'txtAlmRujuk2
        '
        '
        '
        '
        Me.txtAlmRujuk2.Border.Class = "TextBoxBorder"
        Me.txtAlmRujuk2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAlmRujuk2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlmRujuk2.Location = New System.Drawing.Point(466, 71)
        Me.txtAlmRujuk2.MaxLength = 100
        Me.txtAlmRujuk2.Name = "txtAlmRujuk2"
        Me.txtAlmRujuk2.ReadOnly = True
        Me.txtAlmRujuk2.Size = New System.Drawing.Size(266, 20)
        Me.txtAlmRujuk2.TabIndex = 6
        Me.txtAlmRujuk2.TabStop = False
        '
        'txtAlmRujuk1
        '
        '
        '
        '
        Me.txtAlmRujuk1.Border.Class = "TextBoxBorder"
        Me.txtAlmRujuk1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAlmRujuk1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlmRujuk1.Location = New System.Drawing.Point(466, 45)
        Me.txtAlmRujuk1.MaxLength = 100
        Me.txtAlmRujuk1.Name = "txtAlmRujuk1"
        Me.txtAlmRujuk1.ReadOnly = True
        Me.txtAlmRujuk1.Size = New System.Drawing.Size(266, 20)
        Me.txtAlmRujuk1.TabIndex = 5
        Me.txtAlmRujuk1.TabStop = False
        '
        'txtNmRujuk
        '
        '
        '
        '
        Me.txtNmRujuk.Border.Class = "TextBoxBorder"
        Me.txtNmRujuk.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNmRujuk.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNmRujuk.Location = New System.Drawing.Point(466, 19)
        Me.txtNmRujuk.MaxLength = 100
        Me.txtNmRujuk.Name = "txtNmRujuk"
        Me.txtNmRujuk.ReadOnly = True
        Me.txtNmRujuk.Size = New System.Drawing.Size(266, 20)
        Me.txtNmRujuk.TabIndex = 4
        Me.txtNmRujuk.TabStop = False
        '
        'txtJamReg
        '
        '
        '
        '
        Me.txtJamReg.Border.Class = "TextBoxBorder"
        Me.txtJamReg.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtJamReg.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJamReg.Location = New System.Drawing.Point(216, 71)
        Me.txtJamReg.MaxLength = 10
        Me.txtJamReg.Name = "txtJamReg"
        Me.txtJamReg.Size = New System.Drawing.Size(64, 20)
        Me.txtJamReg.TabIndex = 3
        Me.txtJamReg.Text = "24:00:00"
        '
        'txtTglReg
        '
        Me.txtTglReg.AllowEmptyState = False
        '
        '
        '
        Me.txtTglReg.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtTglReg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTglReg.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.txtTglReg.ButtonDropDown.Visible = True
        Me.txtTglReg.CustomFormat = "dd-MM-yyyy"
        Me.txtTglReg.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTglReg.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.txtTglReg.Location = New System.Drawing.Point(119, 71)
        Me.txtTglReg.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.txtTglReg.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txtTglReg.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.txtTglReg.MonthCalendar.BackgroundStyle.Class = ""
        Me.txtTglReg.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTglReg.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.txtTglReg.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.txtTglReg.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.txtTglReg.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.txtTglReg.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtTglReg.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.txtTglReg.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.txtTglReg.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.txtTglReg.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTglReg.MonthCalendar.DisplayMonth = New Date(2011, 9, 1, 0, 0, 0, 0)
        Me.txtTglReg.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.txtTglReg.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txtTglReg.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.txtTglReg.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.txtTglReg.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.txtTglReg.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.txtTglReg.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTglReg.MonthCalendar.TodayButtonVisible = True
        Me.txtTglReg.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.txtTglReg.Name = "txtTglReg"
        Me.txtTglReg.Size = New System.Drawing.Size(94, 20)
        Me.txtTglReg.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txtTglReg.TabIndex = 2
        Me.txtTglReg.Value = New Date(2011, 1, 1, 0, 0, 0, 0)
        '
        'txtKdRujuk
        '
        '
        '
        '
        Me.txtKdRujuk.Border.Class = "TextBoxBorder"
        Me.txtKdRujuk.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKdRujuk.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKdRujuk.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKdRujuk.Location = New System.Drawing.Point(119, 45)
        Me.txtKdRujuk.MaxLength = 10
        Me.txtKdRujuk.Name = "txtKdRujuk"
        Me.txtKdRujuk.Size = New System.Drawing.Size(78, 20)
        Me.txtKdRujuk.TabIndex = 1
        Me.txtKdRujuk.WatermarkText = "PERUJUK"
        '
        'txtKdReg
        '
        '
        '
        '
        Me.txtKdReg.Border.Class = "TextBoxBorder"
        Me.txtKdReg.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKdReg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKdReg.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKdReg.Location = New System.Drawing.Point(119, 19)
        Me.txtKdReg.MaxLength = 10
        Me.txtKdReg.Name = "txtKdReg"
        Me.txtKdReg.Size = New System.Drawing.Size(78, 20)
        Me.txtKdReg.TabIndex = 0
        Me.txtKdReg.WatermarkText = "BARU"
        '
        'xTimer
        '
        Me.xTimer.Enabled = True
        Me.xTimer.Interval = 1000
        '
        'kodeSample
        '
        Me.kodeSample.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.kodeSample.FillWeight = 189.6983!
        Me.kodeSample.HeaderText = "Kode"
        Me.kodeSample.MaxInputLength = 10
        Me.kodeSample.Name = "kodeSample"
        Me.kodeSample.ReadOnly = True
        Me.kodeSample.Width = 90
        '
        'kodeMR
        '
        Me.kodeMR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.kodeMR.FillWeight = 103.9825!
        Me.kodeMR.HeaderText = "Kode MR"
        Me.kodeMR.MaxInputLength = 10
        Me.kodeMR.Name = "kodeMR"
        Me.kodeMR.Width = 90
        '
        'ketSample
        '
        Me.ketSample.FillWeight = 121.5476!
        Me.ketSample.HeaderText = "Keterangan"
        Me.ketSample.Name = "ketSample"
        Me.ketSample.ReadOnly = True
        '
        'frmTrsRegistrasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 508)
        Me.Controls.Add(Me.GroupPanel1)
        Me.DoubleBuffered = True
        Me.Name = "frmTrsRegistrasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrasi & Penerimaan Sample"
        Me.GroupPanel1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.dgvSample, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.txtTglReg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtKdReg As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtTglReg As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents txtKdRujuk As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtJamReg As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtKotaRujuk As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtAlmRujuk2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtAlmRujuk1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNmRujuk As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnExit As DevComponents.DotNetBar.ButtonX
    Public WithEvents dgvSample As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents xTimer As System.Windows.Forms.Timer
    Friend WithEvents txtKdRegNew As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnVoid As DevComponents.DotNetBar.ButtonX
    Friend WithEvents kodeSample As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kodeMR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ketSample As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

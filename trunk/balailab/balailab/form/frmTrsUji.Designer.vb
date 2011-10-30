<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrsUji
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.grid = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.KodeTarif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NmTarif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn()
        Me.Tarif = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn()
        Me.lstSample = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.KdSample = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NmPasien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtTglEstimasi = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtKotaRujuk = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtAlmRujuk2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtAlmRujuk1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNmRujuk = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtJamUji = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtTglUji = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.txtKdReg = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.xTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnExit = New DevComponents.DotNetBar.ButtonX()
        Me.btnVoid = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.txtTotal = New DevComponents.Editors.DoubleInput()
        Me.GroupPanel1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        CType(Me.txtTglEstimasi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTglUji, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.GroupPanel1.Controls.Add(Me.PanelEx2)
        Me.GroupPanel1.Controls.Add(Me.PanelEx1)
        Me.GroupPanel1.Location = New System.Drawing.Point(2, 9)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(882, 448)
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
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.SplitContainer1)
        Me.PanelEx2.Location = New System.Drawing.Point(7, 131)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(860, 303)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 21
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grid)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lstSample)
        Me.SplitContainer1.Size = New System.Drawing.Size(860, 303)
        Me.SplitContainer1.SplitterDistance = 595
        Me.SplitContainer1.TabIndex = 1
        '
        'grid
        '
        Me.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeTarif, Me.NmTarif, Me.Qty, Me.Tarif})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle3
        Me.grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.grid.Location = New System.Drawing.Point(0, 0)
        Me.grid.Name = "grid"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grid.Size = New System.Drawing.Size(595, 303)
        Me.grid.TabIndex = 5
        '
        'KodeTarif
        '
        Me.KodeTarif.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.KodeTarif.HeaderText = "Kode"
        Me.KodeTarif.Name = "KodeTarif"
        Me.KodeTarif.Width = 90
        '
        'NmTarif
        '
        Me.NmTarif.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NmTarif.HeaderText = "Pengujian"
        Me.NmTarif.Name = "NmTarif"
        Me.NmTarif.ReadOnly = True
        '
        'Qty
        '
        Me.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        '
        '
        '
        Me.Qty.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.Qty.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.Qty.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Qty.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Qty.DefaultCellStyle = DataGridViewCellStyle1
        Me.Qty.HeaderText = "Qty"
        Me.Qty.MaxInputLength = 5
        Me.Qty.MaxValue = 500
        Me.Qty.MinValue = 0
        Me.Qty.Name = "Qty"
        Me.Qty.ReadOnly = True
        Me.Qty.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Qty.ShowUpDown = True
        Me.Qty.Width = 40
        '
        'Tarif
        '
        Me.Tarif.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        '
        '
        '
        Me.Tarif.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.Tarif.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.Tarif.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tarif.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText
        Me.Tarif.ButtonDropDown.Enabled = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Tarif.DefaultCellStyle = DataGridViewCellStyle2
        Me.Tarif.HeaderText = "Tarif"
        Me.Tarif.Increment = 1.0R
        Me.Tarif.MinValue = 0.0R
        Me.Tarif.Name = "Tarif"
        Me.Tarif.ReadOnly = True
        Me.Tarif.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tarif.Width = 110
        '
        'lstSample
        '
        '
        '
        '
        Me.lstSample.Border.Class = "ListViewBorder"
        Me.lstSample.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lstSample.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.KdSample, Me.NmPasien})
        Me.lstSample.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstSample.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSample.FullRowSelect = True
        Me.lstSample.GridLines = True
        Me.lstSample.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstSample.Location = New System.Drawing.Point(0, 0)
        Me.lstSample.Name = "lstSample"
        Me.lstSample.Size = New System.Drawing.Size(261, 303)
        Me.lstSample.TabIndex = 0
        Me.lstSample.UseCompatibleStateImageBehavior = False
        Me.lstSample.View = System.Windows.Forms.View.Details
        '
        'KdSample
        '
        Me.KdSample.Text = "Kode Sample"
        Me.KdSample.Width = 100
        '
        'NmPasien
        '
        Me.NmPasien.Text = "Pasien"
        Me.NmPasien.Width = 160
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.txtTglEstimasi)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Controls.Add(Me.LabelX5)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Controls.Add(Me.LabelX4)
        Me.PanelEx1.Controls.Add(Me.txtKotaRujuk)
        Me.PanelEx1.Controls.Add(Me.txtAlmRujuk2)
        Me.PanelEx1.Controls.Add(Me.txtAlmRujuk1)
        Me.PanelEx1.Controls.Add(Me.txtNmRujuk)
        Me.PanelEx1.Controls.Add(Me.txtJamUji)
        Me.PanelEx1.Controls.Add(Me.txtTglUji)
        Me.PanelEx1.Controls.Add(Me.txtKdReg)
        Me.PanelEx1.Location = New System.Drawing.Point(7, 6)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(860, 119)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 20
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(22, 63)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 21
        Me.LabelX2.Text = "Estimasi"
        '
        'txtTglEstimasi
        '
        Me.txtTglEstimasi.AllowEmptyState = False
        '
        '
        '
        Me.txtTglEstimasi.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtTglEstimasi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTglEstimasi.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.txtTglEstimasi.ButtonDropDown.Visible = True
        Me.txtTglEstimasi.CustomFormat = "dd-MM-yyyy"
        Me.txtTglEstimasi.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTglEstimasi.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.txtTglEstimasi.Location = New System.Drawing.Point(101, 66)
        Me.txtTglEstimasi.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.txtTglEstimasi.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txtTglEstimasi.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.txtTglEstimasi.MonthCalendar.BackgroundStyle.Class = ""
        Me.txtTglEstimasi.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTglEstimasi.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.txtTglEstimasi.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.txtTglEstimasi.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.txtTglEstimasi.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.txtTglEstimasi.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtTglEstimasi.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.txtTglEstimasi.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.txtTglEstimasi.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.txtTglEstimasi.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTglEstimasi.MonthCalendar.DisplayMonth = New Date(2011, 9, 1, 0, 0, 0, 0)
        Me.txtTglEstimasi.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.txtTglEstimasi.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txtTglEstimasi.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.txtTglEstimasi.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.txtTglEstimasi.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.txtTglEstimasi.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.txtTglEstimasi.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTglEstimasi.MonthCalendar.TodayButtonVisible = True
        Me.txtTglEstimasi.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.txtTglEstimasi.Name = "txtTglEstimasi"
        Me.txtTglEstimasi.Size = New System.Drawing.Size(94, 20)
        Me.txtTglEstimasi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txtTglEstimasi.TabIndex = 4
        Me.txtTglEstimasi.Value = New Date(2011, 1, 1, 0, 0, 0, 0)
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(22, 37)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 13
        Me.LabelX3.Text = "Tanggal/Jam"
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(487, 37)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX5.Size = New System.Drawing.Size(75, 23)
        Me.LabelX5.TabIndex = 19
        Me.LabelX5.Text = "Alamat"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(22, 8)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Nomor Lab"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(487, 11)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX4.Size = New System.Drawing.Size(75, 23)
        Me.LabelX4.TabIndex = 18
        Me.LabelX4.Text = "Nama Perujuk"
        '
        'txtKotaRujuk
        '
        '
        '
        '
        Me.txtKotaRujuk.Border.Class = "TextBoxBorder"
        Me.txtKotaRujuk.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKotaRujuk.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKotaRujuk.Location = New System.Drawing.Point(568, 89)
        Me.txtKotaRujuk.MaxLength = 100
        Me.txtKotaRujuk.Name = "txtKotaRujuk"
        Me.txtKotaRujuk.ReadOnly = True
        Me.txtKotaRujuk.Size = New System.Drawing.Size(266, 20)
        Me.txtKotaRujuk.TabIndex = 17
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
        Me.txtAlmRujuk2.Location = New System.Drawing.Point(568, 63)
        Me.txtAlmRujuk2.MaxLength = 100
        Me.txtAlmRujuk2.Name = "txtAlmRujuk2"
        Me.txtAlmRujuk2.ReadOnly = True
        Me.txtAlmRujuk2.Size = New System.Drawing.Size(266, 20)
        Me.txtAlmRujuk2.TabIndex = 16
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
        Me.txtAlmRujuk1.Location = New System.Drawing.Point(568, 37)
        Me.txtAlmRujuk1.MaxLength = 100
        Me.txtAlmRujuk1.Name = "txtAlmRujuk1"
        Me.txtAlmRujuk1.ReadOnly = True
        Me.txtAlmRujuk1.Size = New System.Drawing.Size(266, 20)
        Me.txtAlmRujuk1.TabIndex = 15
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
        Me.txtNmRujuk.Location = New System.Drawing.Point(568, 11)
        Me.txtNmRujuk.MaxLength = 100
        Me.txtNmRujuk.Name = "txtNmRujuk"
        Me.txtNmRujuk.ReadOnly = True
        Me.txtNmRujuk.Size = New System.Drawing.Size(266, 20)
        Me.txtNmRujuk.TabIndex = 14
        Me.txtNmRujuk.TabStop = False
        '
        'txtJamUji
        '
        '
        '
        '
        Me.txtJamUji.Border.Class = "TextBoxBorder"
        Me.txtJamUji.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtJamUji.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJamUji.Location = New System.Drawing.Point(198, 40)
        Me.txtJamUji.MaxLength = 10
        Me.txtJamUji.Name = "txtJamUji"
        Me.txtJamUji.Size = New System.Drawing.Size(64, 20)
        Me.txtJamUji.TabIndex = 3
        Me.txtJamUji.Text = "24:00:00"
        '
        'txtTglUji
        '
        Me.txtTglUji.AllowEmptyState = False
        '
        '
        '
        Me.txtTglUji.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtTglUji.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTglUji.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.txtTglUji.ButtonDropDown.Visible = True
        Me.txtTglUji.CustomFormat = "dd-MM-yyyy"
        Me.txtTglUji.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTglUji.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.txtTglUji.Location = New System.Drawing.Point(101, 40)
        Me.txtTglUji.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.txtTglUji.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txtTglUji.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.txtTglUji.MonthCalendar.BackgroundStyle.Class = ""
        Me.txtTglUji.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTglUji.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.txtTglUji.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.txtTglUji.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.txtTglUji.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.txtTglUji.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtTglUji.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.txtTglUji.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.txtTglUji.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.txtTglUji.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTglUji.MonthCalendar.DisplayMonth = New Date(2011, 9, 1, 0, 0, 0, 0)
        Me.txtTglUji.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.txtTglUji.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txtTglUji.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.txtTglUji.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.txtTglUji.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.txtTglUji.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.txtTglUji.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTglUji.MonthCalendar.TodayButtonVisible = True
        Me.txtTglUji.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.txtTglUji.Name = "txtTglUji"
        Me.txtTglUji.Size = New System.Drawing.Size(94, 20)
        Me.txtTglUji.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txtTglUji.TabIndex = 2
        Me.txtTglUji.Value = New Date(2011, 1, 1, 0, 0, 0, 0)
        '
        'txtKdReg
        '
        '
        '
        '
        Me.txtKdReg.Border.Class = "TextBoxBorder"
        Me.txtKdReg.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKdReg.ButtonCustom.Visible = True
        Me.txtKdReg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKdReg.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKdReg.Location = New System.Drawing.Point(101, 11)
        Me.txtKdReg.MaxLength = 10
        Me.txtKdReg.Name = "txtKdReg"
        Me.txtKdReg.Size = New System.Drawing.Size(94, 20)
        Me.txtKdReg.TabIndex = 1
        '
        'xTimer
        '
        Me.xTimer.Enabled = True
        Me.xTimer.Interval = 1000
        '
        'btnExit
        '
        Me.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExit.Location = New System.Drawing.Point(809, 463)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 29)
        Me.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "&Exit"
        '
        'btnVoid
        '
        Me.btnVoid.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnVoid.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnVoid.Location = New System.Drawing.Point(728, 463)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(75, 29)
        Me.btnVoid.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnVoid.TabIndex = 2
        Me.btnVoid.Text = "&Void"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Location = New System.Drawing.Point(647, 463)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 29)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save"
        '
        'txtTotal
        '
        Me.txtTotal.AllowEmptyState = False
        '
        '
        '
        Me.txtTotal.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTotal.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtTotal.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotal.DisabledForeColor = System.Drawing.Color.Black
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Increment = 1.0R
        Me.txtTotal.Location = New System.Drawing.Point(394, 460)
        Me.txtTotal.MinValue = 0.0R
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(213, 38)
        Me.txtTotal.TabIndex = 4
        '
        'frmTrsUji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 498)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnVoid)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupPanel1)
        Me.DoubleBuffered = True
        Me.Name = "frmTrsUji"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Permohonan Uji"
        Me.GroupPanel1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.txtTglEstimasi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTglUji, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtKdReg As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtJamUji As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtTglUji As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents xTimer As System.Windows.Forms.Timer
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtKotaRujuk As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtAlmRujuk2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtAlmRujuk1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNmRujuk As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents grid As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lstSample As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents KdSample As System.Windows.Forms.ColumnHeader
    Friend WithEvents NmPasien As System.Windows.Forms.ColumnHeader
    Friend WithEvents KodeTarif As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NmTarif As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn
    Friend WithEvents Tarif As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents btnExit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnVoid As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtTotal As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTglEstimasi As DevComponents.Editors.DateTimeAdv.DateTimeInput
End Class

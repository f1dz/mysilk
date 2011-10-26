<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrsKasir
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
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.txtKembali = New DevComponents.Editors.DoubleInput()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.txtBayar = New DevComponents.Editors.DoubleInput()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtTotal = New DevComponents.Editors.DoubleInput()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.txtKdBayarNew = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtKdBayar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtKotaRujuk = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtAlmRujuk2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtAlmRujuk1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNmRujuk = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtJamBayar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtTglBayar = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtKdReg = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.btnExit = New DevComponents.DotNetBar.ButtonX()
        Me.btnVoid = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.xTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupPanel1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKembali, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBayar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        CType(Me.txtTglBayar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.PanelEx2)
        Me.GroupPanel1.Controls.Add(Me.PanelEx1)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(819, 369)
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
        Me.PanelEx2.Location = New System.Drawing.Point(3, 135)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(807, 225)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 5
        Me.PanelEx2.Text = "PanelEx2"
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelX8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtKembali)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelX7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtBayar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelX6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtTotal)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(807, 225)
        Me.SplitContainer1.SplitterDistance = 537
        Me.SplitContainer1.TabIndex = 0
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
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
        Me.grid.ReadOnly = True
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grid.Size = New System.Drawing.Size(537, 225)
        Me.grid.TabIndex = 1
        '
        'KodeTarif
        '
        Me.KodeTarif.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.KodeTarif.HeaderText = "Kode"
        Me.KodeTarif.Name = "KodeTarif"
        Me.KodeTarif.ReadOnly = True
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
        DataGridViewCellStyle1.Format = "#,###.00"
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
        DataGridViewCellStyle2.Format = "#,###.00"
        Me.Tarif.DefaultCellStyle = DataGridViewCellStyle2
        Me.Tarif.HeaderText = "Tarif"
        Me.Tarif.Increment = 1.0R
        Me.Tarif.MinValue = 0.0R
        Me.Tarif.Name = "Tarif"
        Me.Tarif.ReadOnly = True
        Me.Tarif.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tarif.Width = 110
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.Class = ""
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(22, 120)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX8.Size = New System.Drawing.Size(70, 23)
        Me.LabelX8.TabIndex = 30
        Me.LabelX8.Text = "Kembali"
        '
        'txtKembali
        '
        Me.txtKembali.AllowEmptyState = False
        '
        '
        '
        Me.txtKembali.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtKembali.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKembali.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtKembali.DisabledBackColor = System.Drawing.Color.White
        Me.txtKembali.DisabledForeColor = System.Drawing.Color.Black
        Me.txtKembali.DisplayFormat = "#,###.00"
        Me.txtKembali.Enabled = False
        Me.txtKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKembali.Increment = 1.0R
        Me.txtKembali.Location = New System.Drawing.Point(98, 114)
        Me.txtKembali.MinValue = 0.0R
        Me.txtKembali.Name = "txtKembali"
        Me.txtKembali.Size = New System.Drawing.Size(156, 29)
        Me.txtKembali.TabIndex = 29
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.Class = ""
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(22, 61)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX7.Size = New System.Drawing.Size(70, 23)
        Me.LabelX7.TabIndex = 28
        Me.LabelX7.Text = "Bayar"
        '
        'txtBayar
        '
        Me.txtBayar.AllowEmptyState = False
        '
        '
        '
        Me.txtBayar.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtBayar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBayar.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtBayar.DisplayFormat = "#,###.00"
        Me.txtBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBayar.Increment = 1.0R
        Me.txtBayar.Location = New System.Drawing.Point(98, 55)
        Me.txtBayar.MinValue = 0.0R
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(156, 29)
        Me.txtBayar.TabIndex = 4
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(46, 20)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX6.Size = New System.Drawing.Size(46, 23)
        Me.LabelX6.TabIndex = 26
        Me.LabelX6.Text = "Total"
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
        Me.txtTotal.DisplayFormat = "#,###.00"
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Increment = 1.0R
        Me.txtTotal.Location = New System.Drawing.Point(98, 14)
        Me.txtTotal.MinValue = 0.0R
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(156, 29)
        Me.txtTotal.TabIndex = 0
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(266, 225)
        Me.ShapeContainer1.TabIndex = 31
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 16
        Me.LineShape1.X2 = 252
        Me.LineShape1.Y1 = 100
        Me.LineShape1.Y2 = 100
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.txtKdBayarNew)
        Me.PanelEx1.Controls.Add(Me.txtKdBayar)
        Me.PanelEx1.Controls.Add(Me.LabelX5)
        Me.PanelEx1.Controls.Add(Me.LabelX4)
        Me.PanelEx1.Controls.Add(Me.txtKotaRujuk)
        Me.PanelEx1.Controls.Add(Me.txtAlmRujuk2)
        Me.PanelEx1.Controls.Add(Me.txtAlmRujuk1)
        Me.PanelEx1.Controls.Add(Me.txtNmRujuk)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Controls.Add(Me.txtJamBayar)
        Me.PanelEx1.Controls.Add(Me.txtTglBayar)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.txtKdReg)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Location = New System.Drawing.Point(3, 3)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(807, 126)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 4
        '
        'txtKdBayarNew
        '
        '
        '
        '
        Me.txtKdBayarNew.Border.Class = "TextBoxBorder"
        Me.txtKdBayarNew.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKdBayarNew.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKdBayarNew.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKdBayarNew.Location = New System.Drawing.Point(177, 17)
        Me.txtKdBayarNew.MaxLength = 10
        Me.txtKdBayarNew.Name = "txtKdBayarNew"
        Me.txtKdBayarNew.ReadOnly = True
        Me.txtKdBayarNew.Size = New System.Drawing.Size(78, 20)
        Me.txtKdBayarNew.TabIndex = 26
        '
        'txtKdBayar
        '
        '
        '
        '
        Me.txtKdBayar.Border.Class = "TextBoxBorder"
        Me.txtKdBayar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKdBayar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKdBayar.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKdBayar.Location = New System.Drawing.Point(93, 17)
        Me.txtKdBayar.MaxLength = 10
        Me.txtKdBayar.Name = "txtKdBayar"
        Me.txtKdBayar.Size = New System.Drawing.Size(78, 20)
        Me.txtKdBayar.TabIndex = 1
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(447, 40)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX5.Size = New System.Drawing.Size(75, 23)
        Me.LabelX5.TabIndex = 25
        Me.LabelX5.Text = "Alamat"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(447, 14)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX4.Size = New System.Drawing.Size(75, 23)
        Me.LabelX4.TabIndex = 24
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
        Me.txtKotaRujuk.Location = New System.Drawing.Point(528, 92)
        Me.txtKotaRujuk.MaxLength = 100
        Me.txtKotaRujuk.Name = "txtKotaRujuk"
        Me.txtKotaRujuk.ReadOnly = True
        Me.txtKotaRujuk.Size = New System.Drawing.Size(266, 20)
        Me.txtKotaRujuk.TabIndex = 23
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
        Me.txtAlmRujuk2.Location = New System.Drawing.Point(528, 66)
        Me.txtAlmRujuk2.MaxLength = 100
        Me.txtAlmRujuk2.Name = "txtAlmRujuk2"
        Me.txtAlmRujuk2.ReadOnly = True
        Me.txtAlmRujuk2.Size = New System.Drawing.Size(266, 20)
        Me.txtAlmRujuk2.TabIndex = 22
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
        Me.txtAlmRujuk1.Location = New System.Drawing.Point(528, 40)
        Me.txtAlmRujuk1.MaxLength = 100
        Me.txtAlmRujuk1.Name = "txtAlmRujuk1"
        Me.txtAlmRujuk1.ReadOnly = True
        Me.txtAlmRujuk1.Size = New System.Drawing.Size(266, 20)
        Me.txtAlmRujuk1.TabIndex = 21
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
        Me.txtNmRujuk.Location = New System.Drawing.Point(528, 14)
        Me.txtNmRujuk.MaxLength = 100
        Me.txtNmRujuk.Name = "txtNmRujuk"
        Me.txtNmRujuk.ReadOnly = True
        Me.txtNmRujuk.Size = New System.Drawing.Size(266, 20)
        Me.txtNmRujuk.TabIndex = 20
        Me.txtNmRujuk.TabStop = False
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(14, 66)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 16
        Me.LabelX3.Text = "Tanggal/Jam"
        '
        'txtJamBayar
        '
        '
        '
        '
        Me.txtJamBayar.Border.Class = "TextBoxBorder"
        Me.txtJamBayar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtJamBayar.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJamBayar.Location = New System.Drawing.Point(190, 69)
        Me.txtJamBayar.MaxLength = 10
        Me.txtJamBayar.Name = "txtJamBayar"
        Me.txtJamBayar.Size = New System.Drawing.Size(64, 20)
        Me.txtJamBayar.TabIndex = 3
        Me.txtJamBayar.Text = "24:00:00"
        '
        'txtTglBayar
        '
        Me.txtTglBayar.AllowEmptyState = False
        '
        '
        '
        Me.txtTglBayar.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtTglBayar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTglBayar.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.txtTglBayar.ButtonDropDown.Visible = True
        Me.txtTglBayar.CustomFormat = "dd-MM-yyyy"
        Me.txtTglBayar.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTglBayar.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.txtTglBayar.Location = New System.Drawing.Point(93, 69)
        Me.txtTglBayar.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.txtTglBayar.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txtTglBayar.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.txtTglBayar.MonthCalendar.BackgroundStyle.Class = ""
        Me.txtTglBayar.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTglBayar.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.txtTglBayar.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.txtTglBayar.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.txtTglBayar.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.txtTglBayar.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtTglBayar.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.txtTglBayar.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.txtTglBayar.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.txtTglBayar.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTglBayar.MonthCalendar.DisplayMonth = New Date(2011, 9, 1, 0, 0, 0, 0)
        Me.txtTglBayar.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.txtTglBayar.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txtTglBayar.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.txtTglBayar.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.txtTglBayar.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.txtTglBayar.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.txtTglBayar.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTglBayar.MonthCalendar.TodayButtonVisible = True
        Me.txtTglBayar.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.txtTglBayar.Name = "txtTglBayar"
        Me.txtTglBayar.Size = New System.Drawing.Size(94, 20)
        Me.txtTglBayar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txtTglBayar.TabIndex = 2
        Me.txtTglBayar.Value = New Date(2011, 1, 1, 0, 0, 0, 0)
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(14, 40)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "Nomor Lab"
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
        Me.txtKdReg.Location = New System.Drawing.Point(93, 43)
        Me.txtKdReg.MaxLength = 10
        Me.txtKdReg.Name = "txtKdReg"
        Me.txtKdReg.Size = New System.Drawing.Size(78, 20)
        Me.txtKdReg.TabIndex = 1
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(14, 14)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Kode Bayar"
        '
        'btnExit
        '
        Me.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExit.Location = New System.Drawing.Point(756, 389)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 35)
        Me.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        '
        'btnVoid
        '
        Me.btnVoid.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnVoid.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnVoid.Location = New System.Drawing.Point(675, 389)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(75, 35)
        Me.btnVoid.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnVoid.TabIndex = 6
        Me.btnVoid.Text = "&Void"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Location = New System.Drawing.Point(594, 389)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 35)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "&Save"
        '
        'xTimer
        '
        Me.xTimer.Enabled = True
        Me.xTimer.Interval = 1000
        '
        'frmTrsKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 424)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnVoid)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupPanel1)
        Me.DoubleBuffered = True
        Me.Name = "frmTrsKasir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kasir"
        Me.GroupPanel1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKembali, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBayar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.txtTglBayar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtKdReg As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtJamBayar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtTglBayar As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtKotaRujuk As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtAlmRujuk2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtAlmRujuk1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNmRujuk As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents grid As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTotal As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtKembali As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBayar As DevComponents.Editors.DoubleInput
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btnExit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnVoid As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents xTimer As System.Windows.Forms.Timer
    Friend WithEvents txtKdBayar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtKdBayarNew As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents KodeTarif As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NmTarif As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn
    Friend WithEvents Tarif As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
End Class

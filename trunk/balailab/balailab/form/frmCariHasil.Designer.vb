<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCariHasil
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
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.btnExit = New DevComponents.DotNetBar.ButtonX()
        Me.btnOK = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.grid = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.txtQuery = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.TglReg1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.TglReg2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.TglEst2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.TglEst1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TglReg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TglReg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TglEst2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TglEst1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.PanelEx3)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Location = New System.Drawing.Point(3, 4)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(621, 294)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        Me.PanelEx1.Text = "PanelEx1"
        '
        'btnExit
        '
        Me.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExit.Location = New System.Drawing.Point(543, 304)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 25)
        Me.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        '
        'btnOK
        '
        Me.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOK.Location = New System.Drawing.Point(456, 304)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(81, 25)
        Me.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.LabelX4)
        Me.PanelEx2.Controls.Add(Me.LabelX5)
        Me.PanelEx2.Controls.Add(Me.TglEst2)
        Me.PanelEx2.Controls.Add(Me.TglEst1)
        Me.PanelEx2.Controls.Add(Me.LabelX3)
        Me.PanelEx2.Controls.Add(Me.LabelX2)
        Me.PanelEx2.Controls.Add(Me.TglReg2)
        Me.PanelEx2.Controls.Add(Me.TglReg1)
        Me.PanelEx2.Controls.Add(Me.LabelX1)
        Me.PanelEx2.Controls.Add(Me.txtQuery)
        Me.PanelEx2.Location = New System.Drawing.Point(3, 3)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(615, 91)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 0
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.grid)
        Me.PanelEx3.Location = New System.Drawing.Point(3, 100)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(615, 191)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 1
        Me.PanelEx3.Text = "PanelEx3"
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
        Me.grid.Size = New System.Drawing.Size(615, 191)
        Me.grid.TabIndex = 0
        '
        'txtQuery
        '
        '
        '
        '
        Me.txtQuery.Border.Class = "TextBoxBorder"
        Me.txtQuery.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtQuery.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuery.Location = New System.Drawing.Point(80, 5)
        Me.txtQuery.Name = "txtQuery"
        Me.txtQuery.Size = New System.Drawing.Size(252, 22)
        Me.txtQuery.TabIndex = 0
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(14, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX1.Size = New System.Drawing.Size(60, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Keyword"
        '
        'TglReg1
        '
        Me.TglReg1.AllowEmptyState = False
        '
        '
        '
        Me.TglReg1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TglReg1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TglReg1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.TglReg1.ButtonDropDown.Visible = True
        Me.TglReg1.CustomFormat = "yyyy-MM-dd"
        Me.TglReg1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TglReg1.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.TglReg1.IsPopupCalendarOpen = False
        Me.TglReg1.Location = New System.Drawing.Point(80, 33)
        '
        '
        '
        Me.TglReg1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.TglReg1.MonthCalendar.BackgroundStyle.Class = ""
        Me.TglReg1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TglReg1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.TglReg1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.TglReg1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.TglReg1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.TglReg1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TglReg1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.TglReg1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.TglReg1.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.TglReg1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TglReg1.MonthCalendar.DisplayMonth = New Date(2011, 11, 1, 0, 0, 0, 0)
        Me.TglReg1.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.TglReg1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.TglReg1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.TglReg1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.TglReg1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.TglReg1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.TglReg1.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.TglReg1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TglReg1.MonthCalendar.TodayButtonVisible = True
        Me.TglReg1.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.TglReg1.Name = "TglReg1"
        Me.TglReg1.Size = New System.Drawing.Size(94, 20)
        Me.TglReg1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.TglReg1.TabIndex = 2
        Me.TglReg1.Value = New Date(2011, 1, 1, 0, 0, 0, 0)
        '
        'TglReg2
        '
        Me.TglReg2.AllowEmptyState = False
        '
        '
        '
        Me.TglReg2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TglReg2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TglReg2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.TglReg2.ButtonDropDown.Visible = True
        Me.TglReg2.CustomFormat = "yyyy-MM-dd"
        Me.TglReg2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TglReg2.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.TglReg2.IsPopupCalendarOpen = False
        Me.TglReg2.Location = New System.Drawing.Point(199, 33)
        '
        '
        '
        Me.TglReg2.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.TglReg2.MonthCalendar.BackgroundStyle.Class = ""
        Me.TglReg2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TglReg2.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.TglReg2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.TglReg2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.TglReg2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.TglReg2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TglReg2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.TglReg2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.TglReg2.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.TglReg2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TglReg2.MonthCalendar.DisplayMonth = New Date(2011, 11, 1, 0, 0, 0, 0)
        Me.TglReg2.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.TglReg2.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.TglReg2.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.TglReg2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.TglReg2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.TglReg2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.TglReg2.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.TglReg2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TglReg2.MonthCalendar.TodayButtonVisible = True
        Me.TglReg2.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.TglReg2.Name = "TglReg2"
        Me.TglReg2.Size = New System.Drawing.Size(94, 20)
        Me.TglReg2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.TglReg2.TabIndex = 3
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(184, 30)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(10, 23)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "-"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(14, 30)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX3.Size = New System.Drawing.Size(60, 23)
        Me.LabelX3.TabIndex = 5
        Me.LabelX3.Text = "Tgl Reg"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(14, 56)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX4.Size = New System.Drawing.Size(60, 23)
        Me.LabelX4.TabIndex = 9
        Me.LabelX4.Text = "Tgl Estimasi"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(184, 56)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(10, 23)
        Me.LabelX5.TabIndex = 8
        Me.LabelX5.Text = "-"
        '
        'TglEst2
        '
        Me.TglEst2.AllowEmptyState = False
        '
        '
        '
        Me.TglEst2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TglEst2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TglEst2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.TglEst2.ButtonDropDown.Visible = True
        Me.TglEst2.CustomFormat = "yyyy-MM-dd"
        Me.TglEst2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TglEst2.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.TglEst2.IsPopupCalendarOpen = False
        Me.TglEst2.Location = New System.Drawing.Point(199, 59)
        '
        '
        '
        Me.TglEst2.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.TglEst2.MonthCalendar.BackgroundStyle.Class = ""
        Me.TglEst2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TglEst2.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.TglEst2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.TglEst2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.TglEst2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.TglEst2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TglEst2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.TglEst2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.TglEst2.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.TglEst2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TglEst2.MonthCalendar.DisplayMonth = New Date(2011, 11, 1, 0, 0, 0, 0)
        Me.TglEst2.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.TglEst2.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.TglEst2.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.TglEst2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.TglEst2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.TglEst2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.TglEst2.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.TglEst2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TglEst2.MonthCalendar.TodayButtonVisible = True
        Me.TglEst2.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.TglEst2.Name = "TglEst2"
        Me.TglEst2.Size = New System.Drawing.Size(94, 20)
        Me.TglEst2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.TglEst2.TabIndex = 7
        '
        'TglEst1
        '
        Me.TglEst1.AllowEmptyState = False
        '
        '
        '
        Me.TglEst1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TglEst1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TglEst1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.TglEst1.ButtonDropDown.Visible = True
        Me.TglEst1.CustomFormat = "yyyy-MM-dd"
        Me.TglEst1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TglEst1.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.TglEst1.IsPopupCalendarOpen = False
        Me.TglEst1.Location = New System.Drawing.Point(80, 59)
        '
        '
        '
        Me.TglEst1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.TglEst1.MonthCalendar.BackgroundStyle.Class = ""
        Me.TglEst1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TglEst1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.TglEst1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.TglEst1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.TglEst1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.TglEst1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TglEst1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.TglEst1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.TglEst1.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.TglEst1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TglEst1.MonthCalendar.DisplayMonth = New Date(2011, 11, 1, 0, 0, 0, 0)
        Me.TglEst1.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.TglEst1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.TglEst1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.TglEst1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.TglEst1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.TglEst1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.TglEst1.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.TglEst1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TglEst1.MonthCalendar.TodayButtonVisible = True
        Me.TglEst1.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.TglEst1.Name = "TglEst1"
        Me.TglEst1.Size = New System.Drawing.Size(94, 20)
        Me.TglEst1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.TglEst1.TabIndex = 6
        Me.TglEst1.Value = New Date(2011, 1, 1, 0, 0, 0, 0)
        '
        'frmCariHasil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 341)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.PanelEx1)
        Me.Name = "frmCariHasil"
        Me.Text = "Cari Hasil"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TglReg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TglReg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TglEst2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TglEst1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnExit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnOK As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents grid As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtQuery As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TglReg1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TglEst2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents TglEst1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TglReg2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
End Class

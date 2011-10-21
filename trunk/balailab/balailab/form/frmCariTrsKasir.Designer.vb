<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCariTrsKasir
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtTgl2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.txtTgl1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtQuery = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.grid = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        CType(Me.txtTgl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTgl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.txtTgl2)
        Me.PanelEx1.Controls.Add(Me.txtTgl1)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Controls.Add(Me.txtQuery)
        Me.PanelEx1.Location = New System.Drawing.Point(1, 8)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(564, 36)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(420, 6)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(23, 23)
        Me.LabelX2.TabIndex = 17
        Me.LabelX2.Text = "s/d"
        '
        'txtTgl2
        '
        Me.txtTgl2.AllowEmptyState = False
        Me.txtTgl2.AutoSelectDate = True
        '
        '
        '
        Me.txtTgl2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtTgl2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTgl2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.txtTgl2.ButtonDropDown.Visible = True
        Me.txtTgl2.CustomFormat = "yyyy-MM-dd"
        Me.txtTgl2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTgl2.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.txtTgl2.Location = New System.Drawing.Point(453, 8)
        Me.txtTgl2.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.txtTgl2.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txtTgl2.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.txtTgl2.MonthCalendar.BackgroundStyle.Class = ""
        Me.txtTgl2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTgl2.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.txtTgl2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.txtTgl2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.txtTgl2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.txtTgl2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtTgl2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.txtTgl2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.txtTgl2.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.txtTgl2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTgl2.MonthCalendar.DisplayMonth = New Date(2011, 9, 1, 0, 0, 0, 0)
        Me.txtTgl2.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.txtTgl2.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txtTgl2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.txtTgl2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.txtTgl2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.txtTgl2.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.txtTgl2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTgl2.MonthCalendar.TodayButtonVisible = True
        Me.txtTgl2.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.txtTgl2.Name = "txtTgl2"
        Me.txtTgl2.Size = New System.Drawing.Size(94, 20)
        Me.txtTgl2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txtTgl2.TabIndex = 16
        Me.txtTgl2.Value = New Date(2011, 1, 1, 0, 0, 0, 0)
        '
        'txtTgl1
        '
        Me.txtTgl1.AllowEmptyState = False
        Me.txtTgl1.AutoSelectDate = True
        '
        '
        '
        Me.txtTgl1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtTgl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTgl1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.txtTgl1.ButtonDropDown.Visible = True
        Me.txtTgl1.CustomFormat = "yyyy-MM-dd"
        Me.txtTgl1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTgl1.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.txtTgl1.Location = New System.Drawing.Point(314, 8)
        Me.txtTgl1.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.txtTgl1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txtTgl1.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.txtTgl1.MonthCalendar.BackgroundStyle.Class = ""
        Me.txtTgl1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTgl1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.txtTgl1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.txtTgl1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.txtTgl1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.txtTgl1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtTgl1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.txtTgl1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.txtTgl1.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.txtTgl1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTgl1.MonthCalendar.DisplayMonth = New Date(2011, 9, 1, 0, 0, 0, 0)
        Me.txtTgl1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.txtTgl1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txtTgl1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.txtTgl1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.txtTgl1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.txtTgl1.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.txtTgl1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTgl1.MonthCalendar.TodayButtonVisible = True
        Me.txtTgl1.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.txtTgl1.Name = "txtTgl1"
        Me.txtTgl1.Size = New System.Drawing.Size(94, 20)
        Me.txtTgl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txtTgl1.TabIndex = 15
        Me.txtTgl1.Value = New Date(2011, 1, 1, 0, 0, 0, 0)
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(11, 6)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX1.Size = New System.Drawing.Size(51, 23)
        Me.LabelX1.TabIndex = 3
        Me.LabelX1.Text = "Keyword"
        '
        'txtQuery
        '
        '
        '
        '
        Me.txtQuery.Border.Class = "TextBoxBorder"
        Me.txtQuery.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtQuery.Location = New System.Drawing.Point(68, 8)
        Me.txtQuery.MaxLength = 30
        Me.txtQuery.Name = "txtQuery"
        Me.txtQuery.Size = New System.Drawing.Size(208, 20)
        Me.txtQuery.TabIndex = 0
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.grid)
        Me.PanelEx2.Location = New System.Drawing.Point(1, 50)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(564, 290)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 2
        Me.PanelEx2.Text = "PanelEx2"
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle1
        Me.grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.grid.Location = New System.Drawing.Point(0, 0)
        Me.grid.MultiSelect = False
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(564, 290)
        Me.grid.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Location = New System.Drawing.Point(490, 346)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        '
        'frmCariTrsKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 380)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCariTrsKasir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cari Transaksi Pembayaran"
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.txtTgl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTgl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtQuery As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents grid As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtTgl1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTgl2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
End Class

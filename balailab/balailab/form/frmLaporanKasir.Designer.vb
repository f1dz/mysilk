<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporanKasir
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
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.crViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.TxtTgl2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.TxtTgl1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.TxtKdPetugas = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BtnProses = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.TxtTgl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTgl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.PanelEx3)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Location = New System.Drawing.Point(1, 6)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(849, 448)
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
        'PanelEx3
        '
        Me.PanelEx3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.crViewer)
        Me.PanelEx3.Location = New System.Drawing.Point(3, 70)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(843, 375)
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
        'crViewer
        '
        Me.crViewer.ActiveViewIndex = -1
        Me.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crViewer.Location = New System.Drawing.Point(0, 0)
        Me.crViewer.Name = "crViewer"
        Me.crViewer.Size = New System.Drawing.Size(843, 375)
        Me.crViewer.TabIndex = 0
        Me.crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'PanelEx2
        '
        Me.PanelEx2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.BtnProses)
        Me.PanelEx2.Controls.Add(Me.TxtTgl2)
        Me.PanelEx2.Controls.Add(Me.TxtTgl1)
        Me.PanelEx2.Controls.Add(Me.TxtKdPetugas)
        Me.PanelEx2.Location = New System.Drawing.Point(3, 3)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(843, 61)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 0
        '
        'TxtTgl2
        '
        Me.TxtTgl2.AllowEmptyState = False
        '
        '
        '
        Me.TxtTgl2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TxtTgl2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtTgl2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.TxtTgl2.ButtonDropDown.Visible = True
        Me.TxtTgl2.CustomFormat = "dd-MM-yyyy"
        Me.TxtTgl2.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.TxtTgl2.IsPopupCalendarOpen = False
        Me.TxtTgl2.Location = New System.Drawing.Point(187, 38)
        '
        '
        '
        Me.TxtTgl2.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.TxtTgl2.MonthCalendar.BackgroundStyle.Class = ""
        Me.TxtTgl2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtTgl2.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.TxtTgl2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.TxtTgl2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.TxtTgl2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.TxtTgl2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtTgl2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.TxtTgl2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.TxtTgl2.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.TxtTgl2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtTgl2.MonthCalendar.DisplayMonth = New Date(2011, 12, 1, 0, 0, 0, 0)
        Me.TxtTgl2.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.TxtTgl2.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.TxtTgl2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.TxtTgl2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.TxtTgl2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.TxtTgl2.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.TxtTgl2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtTgl2.MonthCalendar.TodayButtonVisible = True
        Me.TxtTgl2.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.TxtTgl2.Name = "TxtTgl2"
        Me.TxtTgl2.Size = New System.Drawing.Size(89, 20)
        Me.TxtTgl2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.TxtTgl2.TabIndex = 2
        '
        'TxtTgl1
        '
        Me.TxtTgl1.AllowEmptyState = False
        '
        '
        '
        Me.TxtTgl1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TxtTgl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtTgl1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.TxtTgl1.ButtonDropDown.Visible = True
        Me.TxtTgl1.CustomFormat = "dd-MM-yyyy"
        Me.TxtTgl1.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.TxtTgl1.IsPopupCalendarOpen = False
        Me.TxtTgl1.Location = New System.Drawing.Point(81, 38)
        '
        '
        '
        Me.TxtTgl1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.TxtTgl1.MonthCalendar.BackgroundStyle.Class = ""
        Me.TxtTgl1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtTgl1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.TxtTgl1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.TxtTgl1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.TxtTgl1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.TxtTgl1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtTgl1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.TxtTgl1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.TxtTgl1.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.TxtTgl1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtTgl1.MonthCalendar.DisplayMonth = New Date(2011, 12, 1, 0, 0, 0, 0)
        Me.TxtTgl1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.TxtTgl1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.TxtTgl1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.TxtTgl1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.TxtTgl1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.TxtTgl1.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.TxtTgl1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtTgl1.MonthCalendar.TodayButtonVisible = True
        Me.TxtTgl1.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.TxtTgl1.Name = "TxtTgl1"
        Me.TxtTgl1.Size = New System.Drawing.Size(100, 20)
        Me.TxtTgl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.TxtTgl1.TabIndex = 1
        '
        'TxtKdPetugas
        '
        '
        '
        '
        Me.TxtKdPetugas.Border.Class = "TextBoxBorder"
        Me.TxtKdPetugas.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtKdPetugas.Location = New System.Drawing.Point(81, 12)
        Me.TxtKdPetugas.Name = "TxtKdPetugas"
        Me.TxtKdPetugas.Size = New System.Drawing.Size(100, 20)
        Me.TxtKdPetugas.TabIndex = 0
        '
        'BtnProses
        '
        Me.BtnProses.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnProses.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnProses.Location = New System.Drawing.Point(282, 35)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(75, 23)
        Me.BtnProses.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnProses.TabIndex = 3
        Me.BtnProses.Text = "Proses"
        '
        'frmLaporanKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 494)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Name = "frmLaporanKasir"
        Me.Text = "Laporan Kasir"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.TxtTgl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTgl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents crViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptLapKasir As Global.balailab.rptLapKasir
    Friend WithEvents TxtKdPetugas As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TxtTgl2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents TxtTgl1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents BtnProses As DevComponents.DotNetBar.ButtonX
End Class

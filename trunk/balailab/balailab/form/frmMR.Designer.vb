<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMR
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
        Me.cbSex = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtTempatLahir = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.txtNoMR = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtTglLahir = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.txtTelp = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtKota = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtAlm2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtAlm1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNama = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        CType(Me.txtTglLahir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.cbSex)
        Me.PanelEx1.Controls.Add(Me.txtTempatLahir)
        Me.PanelEx1.Controls.Add(Me.LabelX7)
        Me.PanelEx1.Controls.Add(Me.txtNoMR)
        Me.PanelEx1.Controls.Add(Me.LabelX6)
        Me.PanelEx1.Controls.Add(Me.LabelX5)
        Me.PanelEx1.Controls.Add(Me.LabelX4)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Controls.Add(Me.txtTglLahir)
        Me.PanelEx1.Controls.Add(Me.txtTelp)
        Me.PanelEx1.Controls.Add(Me.txtKota)
        Me.PanelEx1.Controls.Add(Me.txtAlm2)
        Me.PanelEx1.Controls.Add(Me.txtAlm1)
        Me.PanelEx1.Controls.Add(Me.txtNama)
        Me.PanelEx1.Location = New System.Drawing.Point(12, 12)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(447, 218)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'cbSex
        '
        Me.cbSex.DisplayMember = "Text"
        Me.cbSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSex.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSex.FormattingEnabled = True
        Me.cbSex.ItemHeight = 14
        Me.cbSex.Location = New System.Drawing.Point(98, 187)
        Me.cbSex.Name = "cbSex"
        Me.cbSex.Size = New System.Drawing.Size(115, 20)
        Me.cbSex.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbSex.TabIndex = 8
        '
        'txtTempatLahir
        '
        '
        '
        '
        Me.txtTempatLahir.Border.Class = "TextBoxBorder"
        Me.txtTempatLahir.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTempatLahir.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTempatLahir.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempatLahir.Location = New System.Drawing.Point(198, 60)
        Me.txtTempatLahir.MaxLength = 20
        Me.txtTempatLahir.Name = "txtTempatLahir"
        Me.txtTempatLahir.Size = New System.Drawing.Size(156, 20)
        Me.txtTempatLahir.TabIndex = 3
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.Class = ""
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(17, 187)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX7.Size = New System.Drawing.Size(75, 23)
        Me.LabelX7.TabIndex = 19
        Me.LabelX7.Text = "Jenis Kelamin"
        '
        'txtNoMR
        '
        '
        '
        '
        Me.txtNoMR.Border.Class = "TextBoxBorder"
        Me.txtNoMR.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNoMR.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoMR.Location = New System.Drawing.Point(98, 8)
        Me.txtNoMR.MaxLength = 10
        Me.txtNoMR.Name = "txtNoMR"
        Me.txtNoMR.ReadOnly = True
        Me.txtNoMR.Size = New System.Drawing.Size(78, 20)
        Me.txtNoMR.TabIndex = 0
        Me.txtNoMR.WatermarkText = "BARU"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(17, 161)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX6.Size = New System.Drawing.Size(75, 23)
        Me.LabelX6.TabIndex = 16
        Me.LabelX6.Text = "Telepon"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(17, 138)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX5.Size = New System.Drawing.Size(75, 23)
        Me.LabelX5.TabIndex = 15
        Me.LabelX5.Text = "Kota"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(17, 86)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX4.Size = New System.Drawing.Size(75, 23)
        Me.LabelX4.TabIndex = 14
        Me.LabelX4.Text = "Alamat"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(17, 31)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 13
        Me.LabelX3.Text = "Nama"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(3, 57)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX2.Size = New System.Drawing.Size(89, 23)
        Me.LabelX2.TabIndex = 12
        Me.LabelX2.Text = "Tgl/Tempat Lahir"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(17, 8)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 11
        Me.LabelX1.Text = "Nomor MR"
        '
        'txtTglLahir
        '
        Me.txtTglLahir.AllowEmptyState = False
        '
        '
        '
        Me.txtTglLahir.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtTglLahir.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTglLahir.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.txtTglLahir.ButtonDropDown.Visible = True
        Me.txtTglLahir.CustomFormat = "dd-MM-yyyy"
        Me.txtTglLahir.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTglLahir.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.txtTglLahir.IsPopupCalendarOpen = False
        Me.txtTglLahir.Location = New System.Drawing.Point(98, 60)
        Me.txtTglLahir.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.txtTglLahir.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txtTglLahir.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.txtTglLahir.MonthCalendar.BackgroundStyle.Class = ""
        Me.txtTglLahir.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTglLahir.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.txtTglLahir.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.txtTglLahir.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.txtTglLahir.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.txtTglLahir.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtTglLahir.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.txtTglLahir.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.txtTglLahir.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.txtTglLahir.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTglLahir.MonthCalendar.DisplayMonth = New Date(2011, 9, 1, 0, 0, 0, 0)
        Me.txtTglLahir.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.txtTglLahir.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txtTglLahir.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.txtTglLahir.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.txtTglLahir.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.txtTglLahir.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.txtTglLahir.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTglLahir.MonthCalendar.TodayButtonVisible = True
        Me.txtTglLahir.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.txtTglLahir.Name = "txtTglLahir"
        Me.txtTglLahir.Size = New System.Drawing.Size(94, 20)
        Me.txtTglLahir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txtTglLahir.TabIndex = 2
        Me.txtTglLahir.Value = New Date(3000, 1, 1, 0, 0, 0, 0)
        '
        'txtTelp
        '
        '
        '
        '
        Me.txtTelp.Border.Class = "TextBoxBorder"
        Me.txtTelp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTelp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelp.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelp.Location = New System.Drawing.Point(98, 164)
        Me.txtTelp.MaxLength = 50
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(256, 20)
        Me.txtTelp.TabIndex = 7
        '
        'txtKota
        '
        '
        '
        '
        Me.txtKota.Border.Class = "TextBoxBorder"
        Me.txtKota.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKota.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKota.Location = New System.Drawing.Point(98, 138)
        Me.txtKota.MaxLength = 30
        Me.txtKota.Name = "txtKota"
        Me.txtKota.Size = New System.Drawing.Size(144, 20)
        Me.txtKota.TabIndex = 6
        '
        'txtAlm2
        '
        '
        '
        '
        Me.txtAlm2.Border.Class = "TextBoxBorder"
        Me.txtAlm2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAlm2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAlm2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlm2.Location = New System.Drawing.Point(98, 112)
        Me.txtAlm2.MaxLength = 50
        Me.txtAlm2.Name = "txtAlm2"
        Me.txtAlm2.Size = New System.Drawing.Size(256, 20)
        Me.txtAlm2.TabIndex = 5
        '
        'txtAlm1
        '
        '
        '
        '
        Me.txtAlm1.Border.Class = "TextBoxBorder"
        Me.txtAlm1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAlm1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAlm1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlm1.Location = New System.Drawing.Point(98, 86)
        Me.txtAlm1.MaxLength = 50
        Me.txtAlm1.Name = "txtAlm1"
        Me.txtAlm1.Size = New System.Drawing.Size(256, 20)
        Me.txtAlm1.TabIndex = 4
        '
        'txtNama
        '
        '
        '
        '
        Me.txtNama.Border.Class = "TextBoxBorder"
        Me.txtNama.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNama.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNama.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(98, 34)
        Me.txtNama.MaxLength = 100
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(346, 20)
        Me.txtNama.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Location = New System.Drawing.Point(384, 236)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "&Cancel"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Location = New System.Drawing.Point(303, 236)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "&Save"
        '
        'frmMR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 266)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medical Record"
        Me.TopMost = True
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.txtTglLahir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtTelp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtKota As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtAlm2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtAlm1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNama As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtTglLahir As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtNoMR As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTempatLahir As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cbSex As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class

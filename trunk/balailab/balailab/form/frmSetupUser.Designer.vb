<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetupUser
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
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.grid = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtPassword2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txtPassword1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNmInstalasi = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtKdInstalasi = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtNIP = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtNmPetugas = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.CbAktif = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtKdPetugas = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BtnSave = New DevComponents.DotNetBar.ButtonX()
        Me.BtnExit = New DevComponents.DotNetBar.ButtonX()
        Me.Kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xMenu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Akses = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.PanelEx3)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Location = New System.Drawing.Point(6, 7)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(576, 351)
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
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.grid)
        Me.PanelEx3.Location = New System.Drawing.Point(3, 130)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(570, 218)
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
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kode, Me.Grup, Me.xMenu, Me.Akses})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle1
        Me.grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.grid.Location = New System.Drawing.Point(0, 0)
        Me.grid.Name = "grid"
        Me.grid.Size = New System.Drawing.Size(570, 218)
        Me.grid.TabIndex = 0
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.LabelX6)
        Me.PanelEx2.Controls.Add(Me.txtPassword2)
        Me.PanelEx2.Controls.Add(Me.LabelX5)
        Me.PanelEx2.Controls.Add(Me.txtPassword1)
        Me.PanelEx2.Controls.Add(Me.txtNmInstalasi)
        Me.PanelEx2.Controls.Add(Me.LabelX4)
        Me.PanelEx2.Controls.Add(Me.txtKdInstalasi)
        Me.PanelEx2.Controls.Add(Me.LabelX3)
        Me.PanelEx2.Controls.Add(Me.txtNIP)
        Me.PanelEx2.Controls.Add(Me.LabelX2)
        Me.PanelEx2.Controls.Add(Me.txtNmPetugas)
        Me.PanelEx2.Controls.Add(Me.CbAktif)
        Me.PanelEx2.Controls.Add(Me.LabelX1)
        Me.PanelEx2.Controls.Add(Me.txtKdPetugas)
        Me.PanelEx2.Location = New System.Drawing.Point(3, 3)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(570, 121)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 0
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(305, 29)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX6.Size = New System.Drawing.Size(105, 23)
        Me.LabelX6.TabIndex = 13
        Me.LabelX6.Text = "Re-Type Password"
        '
        'txtPassword2
        '
        '
        '
        '
        Me.txtPassword2.Border.Class = "TextBoxBorder"
        Me.txtPassword2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPassword2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword2.Location = New System.Drawing.Point(416, 32)
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword2.Size = New System.Drawing.Size(150, 20)
        Me.txtPassword2.TabIndex = 12
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(335, 3)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX5.Size = New System.Drawing.Size(75, 23)
        Me.LabelX5.TabIndex = 11
        Me.LabelX5.Text = "Password"
        '
        'txtPassword1
        '
        '
        '
        '
        Me.txtPassword1.Border.Class = "TextBoxBorder"
        Me.txtPassword1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPassword1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword1.Location = New System.Drawing.Point(416, 6)
        Me.txtPassword1.Name = "txtPassword1"
        Me.txtPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword1.Size = New System.Drawing.Size(150, 20)
        Me.txtPassword1.TabIndex = 10
        '
        'txtNmInstalasi
        '
        '
        '
        '
        Me.txtNmInstalasi.Border.Class = "TextBoxBorder"
        Me.txtNmInstalasi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNmInstalasi.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNmInstalasi.Location = New System.Drawing.Point(136, 84)
        Me.txtNmInstalasi.Name = "txtNmInstalasi"
        Me.txtNmInstalasi.Size = New System.Drawing.Size(139, 20)
        Me.txtNmInstalasi.TabIndex = 9
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(3, 81)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX4.Size = New System.Drawing.Size(75, 23)
        Me.LabelX4.TabIndex = 8
        Me.LabelX4.Text = "Instalasi"
        '
        'txtKdInstalasi
        '
        '
        '
        '
        Me.txtKdInstalasi.Border.Class = "TextBoxBorder"
        Me.txtKdInstalasi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKdInstalasi.ButtonCustom.Visible = True
        Me.txtKdInstalasi.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKdInstalasi.Location = New System.Drawing.Point(84, 84)
        Me.txtKdInstalasi.MaxLength = 2
        Me.txtKdInstalasi.Name = "txtKdInstalasi"
        Me.txtKdInstalasi.Size = New System.Drawing.Size(48, 20)
        Me.txtKdInstalasi.TabIndex = 7
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(3, 55)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "NIP"
        '
        'txtNIP
        '
        '
        '
        '
        Me.txtNIP.Border.Class = "TextBoxBorder"
        Me.txtNIP.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNIP.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNIP.Location = New System.Drawing.Point(84, 58)
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Size = New System.Drawing.Size(150, 20)
        Me.txtNIP.TabIndex = 5
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(3, 29)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "Nama"
        '
        'txtNmPetugas
        '
        '
        '
        '
        Me.txtNmPetugas.Border.Class = "TextBoxBorder"
        Me.txtNmPetugas.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNmPetugas.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNmPetugas.Location = New System.Drawing.Point(84, 32)
        Me.txtNmPetugas.Name = "txtNmPetugas"
        Me.txtNmPetugas.Size = New System.Drawing.Size(215, 20)
        Me.txtNmPetugas.TabIndex = 3
        '
        'CbAktif
        '
        '
        '
        '
        Me.CbAktif.BackgroundStyle.Class = ""
        Me.CbAktif.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CbAktif.Checked = True
        Me.CbAktif.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbAktif.CheckValue = "1"
        Me.CbAktif.CheckValueChecked = "1"
        Me.CbAktif.CheckValueUnchecked = "0"
        Me.CbAktif.Location = New System.Drawing.Point(217, 6)
        Me.CbAktif.Name = "CbAktif"
        Me.CbAktif.Size = New System.Drawing.Size(62, 23)
        Me.CbAktif.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CbAktif.TabIndex = 2
        Me.CbAktif.Text = "Aktif"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(3, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Username"
        '
        'txtKdPetugas
        '
        '
        '
        '
        Me.txtKdPetugas.Border.Class = "TextBoxBorder"
        Me.txtKdPetugas.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKdPetugas.ButtonCustom.Visible = True
        Me.txtKdPetugas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKdPetugas.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKdPetugas.Location = New System.Drawing.Point(84, 6)
        Me.txtKdPetugas.Name = "txtKdPetugas"
        Me.txtKdPetugas.Size = New System.Drawing.Size(127, 20)
        Me.txtKdPetugas.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSave.Location = New System.Drawing.Point(426, 364)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "&Save"
        '
        'BtnExit
        '
        Me.BtnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnExit.Location = New System.Drawing.Point(507, 364)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "E&xit"
        '
        'Kode
        '
        Me.Kode.HeaderText = "Kode"
        Me.Kode.Name = "Kode"
        Me.Kode.Visible = False
        '
        'Grup
        '
        Me.Grup.HeaderText = "Grup"
        Me.Grup.Name = "Grup"
        Me.Grup.ReadOnly = True
        '
        'xMenu
        '
        Me.xMenu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.xMenu.HeaderText = "Menu"
        Me.xMenu.Name = "xMenu"
        Me.xMenu.ReadOnly = True
        '
        'Akses
        '
        Me.Akses.FalseValue = "0"
        Me.Akses.HeaderText = "Akses"
        Me.Akses.Name = "Akses"
        Me.Akses.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Akses.TrueValue = "1"
        '
        'frmSetupUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 397)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmSetupUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setup User"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents grid As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtKdPetugas As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNmPetugas As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CbAktif As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNIP As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNmInstalasi As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtKdInstalasi As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPassword2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPassword1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BtnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnExit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Kode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Grup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents xMenu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Akses As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class

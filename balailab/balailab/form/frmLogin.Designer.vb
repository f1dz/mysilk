<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.txtPassword = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.txtUser = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.btnLogin = New DevComponents.DotNetBar.ButtonX()
        Me.txtNmUser = New DevComponents.DotNetBar.Controls.TextBoxX()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(325, 139)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "&Cancel"
        '
        'txtPassword
        '
        '
        '
        '
        Me.txtPassword.Border.Class = "TextBoxBorder"
        Me.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPassword.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(70, 68)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(148, 20)
        Me.txtPassword.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.balailab.My.Resources.Resources.Log_off
        Me.PictureBox1.Location = New System.Drawing.Point(6, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.txtUser)
        Me.PanelEx1.Controls.Add(Me.txtNmUser)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.txtPassword)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Location = New System.Drawing.Point(133, 6)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(273, 122)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 11
        '
        'txtUser
        '
        '
        '
        '
        Me.txtUser.Border.Class = "TextBoxBorder"
        Me.txtUser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUser.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(70, 16)
        Me.txtUser.MaxLength = 50
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(148, 20)
        Me.txtUser.TabIndex = 0
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(3, 68)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX2.Size = New System.Drawing.Size(61, 23)
        Me.LabelX2.TabIndex = 99
        Me.LabelX2.Text = "Password"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(3, 16)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX1.Size = New System.Drawing.Size(61, 23)
        Me.LabelX1.TabIndex = 99
        Me.LabelX1.Text = "Username"
        '
        'btnLogin
        '
        Me.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnLogin.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnLogin.Location = New System.Drawing.Point(244, 139)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "&Login"
        '
        'txtNmUser
        '
        '
        '
        '
        Me.txtNmUser.Border.Class = "TextBoxBorder"
        Me.txtNmUser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNmUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNmUser.Enabled = False
        Me.txtNmUser.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNmUser.Location = New System.Drawing.Point(70, 42)
        Me.txtNmUser.Name = "txtNmUser"
        Me.txtNmUser.ReadOnly = True
        Me.txtNmUser.Size = New System.Drawing.Size(196, 20)
        Me.txtNmUser.TabIndex = 1
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(411, 174)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login LISK"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtUser As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnLogin As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtNmUser As DevComponents.DotNetBar.Controls.TextBoxX
End Class

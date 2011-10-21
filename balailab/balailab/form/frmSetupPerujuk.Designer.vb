<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetupPerujuk
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
        Me.txtKode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtNama = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtTelpon = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtAlm1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtAlm2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtKota = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.LabelX6)
        Me.PanelEx1.Controls.Add(Me.txtKota)
        Me.PanelEx1.Controls.Add(Me.txtAlm2)
        Me.PanelEx1.Controls.Add(Me.LabelX4)
        Me.PanelEx1.Controls.Add(Me.txtAlm1)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.txtTelpon)
        Me.PanelEx1.Controls.Add(Me.txtKode)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Controls.Add(Me.txtNama)
        Me.PanelEx1.Location = New System.Drawing.Point(12, 12)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(370, 185)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'txtKode
        '
        Me.txtKode.AcceptsReturn = True
        '
        '
        '
        Me.txtKode.Border.Class = "TextBoxBorder"
        Me.txtKode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKode.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKode.Location = New System.Drawing.Point(94, 15)
        Me.txtKode.MaxLength = 10
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(78, 20)
        Me.txtKode.TabIndex = 1
        Me.txtKode.WatermarkText = "BARU"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(13, 38)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 17
        Me.LabelX3.Text = "Nama"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(13, 15)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 16
        Me.LabelX1.Text = "Kode Perujuk"
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
        Me.txtNama.Location = New System.Drawing.Point(94, 41)
        Me.txtNama.MaxLength = 30
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(256, 20)
        Me.txtNama.TabIndex = 2
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(13, 64)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 19
        Me.LabelX2.Text = "Telpon / Fax"
        '
        'txtTelpon
        '
        '
        '
        '
        Me.txtTelpon.Border.Class = "TextBoxBorder"
        Me.txtTelpon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTelpon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelpon.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelpon.Location = New System.Drawing.Point(94, 67)
        Me.txtTelpon.MaxLength = 50
        Me.txtTelpon.Name = "txtTelpon"
        Me.txtTelpon.Size = New System.Drawing.Size(256, 20)
        Me.txtTelpon.TabIndex = 3
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(13, 90)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX4.Size = New System.Drawing.Size(75, 23)
        Me.LabelX4.TabIndex = 21
        Me.LabelX4.Text = "Alamat"
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
        Me.txtAlm1.Location = New System.Drawing.Point(94, 93)
        Me.txtAlm1.MaxLength = 50
        Me.txtAlm1.Name = "txtAlm1"
        Me.txtAlm1.Size = New System.Drawing.Size(256, 20)
        Me.txtAlm1.TabIndex = 4
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
        Me.txtAlm2.Location = New System.Drawing.Point(94, 119)
        Me.txtAlm2.MaxLength = 50
        Me.txtAlm2.Name = "txtAlm2"
        Me.txtAlm2.Size = New System.Drawing.Size(256, 20)
        Me.txtAlm2.TabIndex = 5
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(13, 142)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX6.Size = New System.Drawing.Size(75, 23)
        Me.LabelX6.TabIndex = 25
        Me.LabelX6.Text = "Kota"
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
        Me.txtKota.Location = New System.Drawing.Point(94, 145)
        Me.txtKota.MaxLength = 20
        Me.txtKota.Name = "txtKota"
        Me.txtKota.Size = New System.Drawing.Size(167, 20)
        Me.txtKota.TabIndex = 6
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Location = New System.Drawing.Point(307, 209)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "&Cancel"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Location = New System.Drawing.Point(226, 209)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&Save"
        '
        'frmSetupPerujuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 244)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSetupPerujuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setup Perujuk"
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtKode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNama As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtKota As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtAlm2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtAlm1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTelpon As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
End Class

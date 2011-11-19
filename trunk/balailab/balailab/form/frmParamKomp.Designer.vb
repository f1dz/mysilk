<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParamKomp
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
        Me.txtNmInstalasi = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtKdInstalasi = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtKdKomp = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtKdCurKomp = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BtnExit = New DevComponents.DotNetBar.ButtonX()
        Me.BtnSave = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.txtNmInstalasi)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Controls.Add(Me.txtKdInstalasi)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.txtKdKomp)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Controls.Add(Me.txtKdCurKomp)
        Me.PanelEx1.Location = New System.Drawing.Point(3, 3)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(353, 231)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'txtNmInstalasi
        '
        '
        '
        '
        Me.txtNmInstalasi.Border.Class = "TextBoxBorder"
        Me.txtNmInstalasi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNmInstalasi.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNmInstalasi.Location = New System.Drawing.Point(153, 61)
        Me.txtNmInstalasi.Name = "txtNmInstalasi"
        Me.txtNmInstalasi.Size = New System.Drawing.Size(139, 20)
        Me.txtNmInstalasi.TabIndex = 6
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(20, 58)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 5
        Me.LabelX3.Text = "Def. Instalasi"
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
        Me.txtKdInstalasi.Location = New System.Drawing.Point(101, 61)
        Me.txtKdInstalasi.Name = "txtKdInstalasi"
        Me.txtKdInstalasi.Size = New System.Drawing.Size(48, 20)
        Me.txtKdInstalasi.TabIndex = 4
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(3, 32)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX2.Size = New System.Drawing.Size(92, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Nama Komputer"
        '
        'txtKdKomp
        '
        '
        '
        '
        Me.txtKdKomp.Border.Class = "TextBoxBorder"
        Me.txtKdKomp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKdKomp.ButtonCustom.Visible = True
        Me.txtKdKomp.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKdKomp.Location = New System.Drawing.Point(101, 35)
        Me.txtKdKomp.Name = "txtKdKomp"
        Me.txtKdKomp.Size = New System.Drawing.Size(191, 20)
        Me.txtKdKomp.TabIndex = 2
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(20, 6)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Current"
        '
        'txtKdCurKomp
        '
        '
        '
        '
        Me.txtKdCurKomp.Border.Class = "TextBoxBorder"
        Me.txtKdCurKomp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKdCurKomp.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKdCurKomp.Location = New System.Drawing.Point(101, 9)
        Me.txtKdCurKomp.Name = "txtKdCurKomp"
        Me.txtKdCurKomp.Size = New System.Drawing.Size(175, 20)
        Me.txtKdCurKomp.TabIndex = 0
        '
        'BtnExit
        '
        Me.BtnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnExit.Location = New System.Drawing.Point(281, 240)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnExit.TabIndex = 1
        Me.BtnExit.Text = "E&xit"
        '
        'BtnSave
        '
        Me.BtnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSave.Location = New System.Drawing.Point(200, 240)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "&Save"
        '
        'frmParamKomp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 273)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.PanelEx1)
        Me.Name = "frmParamKomp"
        Me.Text = "Parameter Komputer"
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtKdCurKomp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtKdKomp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtKdInstalasi As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNmInstalasi As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BtnExit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnSave As DevComponents.DotNetBar.ButtonX
End Class

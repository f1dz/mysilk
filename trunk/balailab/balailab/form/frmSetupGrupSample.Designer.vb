<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetupGrupSample
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
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtNmGrupSample = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtKdGrupSample = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BtnSave = New DevComponents.DotNetBar.ButtonX()
        Me.BtnExit = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Controls.Add(Me.txtNmGrupSample)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Controls.Add(Me.txtKdGrupSample)
        Me.PanelEx1.Location = New System.Drawing.Point(7, 8)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(427, 157)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(17, 45)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 10
        Me.LabelX1.Text = "Grup Sample"
        '
        'txtNmGrupSample
        '
        '
        '
        '
        Me.txtNmGrupSample.Border.Class = "TextBoxBorder"
        Me.txtNmGrupSample.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNmGrupSample.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNmGrupSample.Location = New System.Drawing.Point(98, 45)
        Me.txtNmGrupSample.Name = "txtNmGrupSample"
        Me.txtNmGrupSample.Size = New System.Drawing.Size(191, 20)
        Me.txtNmGrupSample.TabIndex = 9
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(17, 16)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 8
        Me.LabelX3.Text = "Kode"
        '
        'txtKdGrupSample
        '
        '
        '
        '
        Me.txtKdGrupSample.Border.Class = "TextBoxBorder"
        Me.txtKdGrupSample.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKdGrupSample.ButtonCustom.Visible = True
        Me.txtKdGrupSample.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKdGrupSample.Location = New System.Drawing.Point(98, 19)
        Me.txtKdGrupSample.Name = "txtKdGrupSample"
        Me.txtKdGrupSample.Size = New System.Drawing.Size(59, 20)
        Me.txtKdGrupSample.TabIndex = 7
        '
        'BtnSave
        '
        Me.BtnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSave.Location = New System.Drawing.Point(278, 171)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnSave.TabIndex = 6
        Me.BtnSave.Text = "&Save"
        '
        'BtnExit
        '
        Me.BtnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnExit.Location = New System.Drawing.Point(359, 171)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnExit.TabIndex = 5
        Me.BtnExit.Text = "E&xit"
        '
        'frmSetupGrupSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 199)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.PanelEx1)
        Me.Name = "frmSetupGrupSample"
        Me.Text = "Grup Sample"
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNmGrupSample As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtKdGrupSample As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BtnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnExit As DevComponents.DotNetBar.ButtonX
End Class

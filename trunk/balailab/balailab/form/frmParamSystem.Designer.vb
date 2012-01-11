<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParamSystem
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
        Me.txtNipDirektur = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX()
        Me.txtNmDirektur = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
        Me.BtnSave = New DevComponents.DotNetBar.ButtonX()
        Me.BtnExit = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.txtNipDirektur)
        Me.PanelEx1.Controls.Add(Me.LabelX18)
        Me.PanelEx1.Controls.Add(Me.txtNmDirektur)
        Me.PanelEx1.Controls.Add(Me.LabelX17)
        Me.PanelEx1.Location = New System.Drawing.Point(2, 9)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(453, 213)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'txtNipDirektur
        '
        '
        '
        '
        Me.txtNipDirektur.Border.Class = "TextBoxBorder"
        Me.txtNipDirektur.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNipDirektur.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNipDirektur.Location = New System.Drawing.Point(115, 32)
        Me.txtNipDirektur.MaxLength = 30
        Me.txtNipDirektur.Name = "txtNipDirektur"
        Me.txtNipDirektur.Size = New System.Drawing.Size(222, 20)
        Me.txtNipDirektur.TabIndex = 2
        '
        'LabelX18
        '
        Me.LabelX18.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX18.BackgroundStyle.Class = ""
        Me.LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX18.Location = New System.Drawing.Point(43, 31)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX18.Size = New System.Drawing.Size(66, 23)
        Me.LabelX18.TabIndex = 49
        Me.LabelX18.Text = "NIP Direktur"
        '
        'txtNmDirektur
        '
        '
        '
        '
        Me.txtNmDirektur.Border.Class = "TextBoxBorder"
        Me.txtNmDirektur.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNmDirektur.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNmDirektur.Location = New System.Drawing.Point(115, 9)
        Me.txtNmDirektur.MaxLength = 30
        Me.txtNmDirektur.Name = "txtNmDirektur"
        Me.txtNmDirektur.Size = New System.Drawing.Size(222, 20)
        Me.txtNmDirektur.TabIndex = 1
        '
        'LabelX17
        '
        Me.LabelX17.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX17.BackgroundStyle.Class = ""
        Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX17.Location = New System.Drawing.Point(10, 8)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX17.Size = New System.Drawing.Size(99, 23)
        Me.LabelX17.TabIndex = 47
        Me.LabelX17.Text = "Nama Direktur"
        '
        'BtnSave
        '
        Me.BtnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSave.Location = New System.Drawing.Point(299, 228)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnSave.TabIndex = 3
        Me.BtnSave.Text = "&Save"
        '
        'BtnExit
        '
        Me.BtnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnExit.Location = New System.Drawing.Point(380, 228)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnExit.TabIndex = 4
        Me.BtnExit.Text = "E&xit"
        '
        'frmParamSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 262)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "frmParamSystem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parameter Sistem"
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtNipDirektur As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNmDirektur As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnExit As DevComponents.DotNetBar.ButtonX
End Class

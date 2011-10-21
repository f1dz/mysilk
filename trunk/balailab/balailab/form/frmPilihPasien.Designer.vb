<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPilihPasien
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
        Me.lstSample = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.KdSample = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NmPasien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.txtNmTarif = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtKdTarif = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnOK = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.PanelEx3)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Location = New System.Drawing.Point(5, 5)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(371, 245)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.lstSample)
        Me.PanelEx3.Location = New System.Drawing.Point(7, 44)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(358, 193)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 1
        '
        'lstSample
        '
        '
        '
        '
        Me.lstSample.Border.Class = "ListViewBorder"
        Me.lstSample.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lstSample.CheckBoxes = True
        Me.lstSample.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.KdSample, Me.NmPasien})
        Me.lstSample.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstSample.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSample.FullRowSelect = True
        Me.lstSample.GridLines = True
        Me.lstSample.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstSample.Location = New System.Drawing.Point(0, 0)
        Me.lstSample.Name = "lstSample"
        Me.lstSample.Size = New System.Drawing.Size(358, 193)
        Me.lstSample.TabIndex = 1
        Me.lstSample.UseCompatibleStateImageBehavior = False
        Me.lstSample.View = System.Windows.Forms.View.Details
        '
        'KdSample
        '
        Me.KdSample.Text = "Kode Sample"
        Me.KdSample.Width = 100
        '
        'NmPasien
        '
        Me.NmPasien.Text = "Pasien"
        Me.NmPasien.Width = 250
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.txtNmTarif)
        Me.PanelEx2.Controls.Add(Me.txtKdTarif)
        Me.PanelEx2.Location = New System.Drawing.Point(7, 7)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(358, 31)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 0
        '
        'txtNmTarif
        '
        Me.txtNmTarif.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtNmTarif.Border.Class = "TextBoxBorder"
        Me.txtNmTarif.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNmTarif.Enabled = False
        Me.txtNmTarif.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNmTarif.Location = New System.Drawing.Point(109, 5)
        Me.txtNmTarif.Name = "txtNmTarif"
        Me.txtNmTarif.ReadOnly = True
        Me.txtNmTarif.Size = New System.Drawing.Size(244, 20)
        Me.txtNmTarif.TabIndex = 1
        '
        'txtKdTarif
        '
        Me.txtKdTarif.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtKdTarif.Border.Class = "TextBoxBorder"
        Me.txtKdTarif.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKdTarif.Enabled = False
        Me.txtKdTarif.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKdTarif.Location = New System.Drawing.Point(5, 5)
        Me.txtKdTarif.Name = "txtKdTarif"
        Me.txtKdTarif.ReadOnly = True
        Me.txtKdTarif.Size = New System.Drawing.Size(100, 20)
        Me.txtKdTarif.TabIndex = 0
        '
        'btnOK
        '
        Me.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOK.Location = New System.Drawing.Point(301, 256)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "&OK"
        '
        'frmPilihPasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 283)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPilihPasien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pilih Sample"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnOK As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtKdTarif As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNmTarif As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lstSample As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents KdSample As System.Windows.Forms.ColumnHeader
    Friend WithEvents NmPasien As System.Windows.Forms.ColumnHeader
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetupKomponen
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.GridKomp = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.komponen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.txtNmKomp = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtKdKomp = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.btnExit = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnDelete = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        CType(Me.GridKomp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.PanelEx3)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Location = New System.Drawing.Point(2, 7)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(357, 289)
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
        Me.PanelEx3.Controls.Add(Me.GridKomp)
        Me.PanelEx3.Location = New System.Drawing.Point(3, 79)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(351, 207)
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
        'GridKomp
        '
        Me.GridKomp.AllowUserToAddRows = False
        Me.GridKomp.AllowUserToDeleteRows = False
        Me.GridKomp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridKomp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kode, Me.komponen})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridKomp.DefaultCellStyle = DataGridViewCellStyle2
        Me.GridKomp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridKomp.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GridKomp.Location = New System.Drawing.Point(0, 0)
        Me.GridKomp.Name = "GridKomp"
        Me.GridKomp.ReadOnly = True
        Me.GridKomp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridKomp.Size = New System.Drawing.Size(351, 207)
        Me.GridKomp.TabIndex = 0
        '
        'kode
        '
        Me.kode.HeaderText = "Kode"
        Me.kode.Name = "kode"
        Me.kode.ReadOnly = True
        '
        'komponen
        '
        Me.komponen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.komponen.HeaderText = "Komponen"
        Me.komponen.Name = "komponen"
        Me.komponen.ReadOnly = True
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.txtNmKomp)
        Me.PanelEx2.Controls.Add(Me.LabelX2)
        Me.PanelEx2.Controls.Add(Me.txtKdKomp)
        Me.PanelEx2.Controls.Add(Me.LabelX1)
        Me.PanelEx2.Location = New System.Drawing.Point(3, 3)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(351, 70)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 0
        '
        'txtNmKomp
        '
        '
        '
        '
        Me.txtNmKomp.Border.Class = "TextBoxBorder"
        Me.txtNmKomp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNmKomp.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNmKomp.Location = New System.Drawing.Point(88, 36)
        Me.txtNmKomp.MaxLength = 50
        Me.txtNmKomp.Name = "txtNmKomp"
        Me.txtNmKomp.Size = New System.Drawing.Size(219, 20)
        Me.txtNmKomp.TabIndex = 6
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(7, 36)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LabelX2.TabIndex = 7
        Me.LabelX2.Text = "Komponen"
        '
        'txtKdKomp
        '
        '
        '
        '
        Me.txtKdKomp.Border.Class = "TextBoxBorder"
        Me.txtKdKomp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKdKomp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKdKomp.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKdKomp.Location = New System.Drawing.Point(88, 7)
        Me.txtKdKomp.MaxLength = 3
        Me.txtKdKomp.Name = "txtKdKomp"
        Me.txtKdKomp.Size = New System.Drawing.Size(33, 20)
        Me.txtKdKomp.TabIndex = 4
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(7, 7)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LabelX1.TabIndex = 5
        Me.LabelX1.Text = "Kode"
        '
        'btnExit
        '
        Me.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExit.Location = New System.Drawing.Point(284, 302)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Location = New System.Drawing.Point(122, 302)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDelete.Location = New System.Drawing.Point(203, 302)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "&Delete"
        '
        'frmSetupKomponen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 326)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Name = "frmSetupKomponen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setup Komponen Tarif"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        CType(Me.GridKomp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GridKomp As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents kode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents komponen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtNmKomp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtKdKomp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnExit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnDelete As DevComponents.DotNetBar.ButtonX
End Class

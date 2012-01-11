<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits DevComponents.DotNetBar.Office2007RibbonForm
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub
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
    Friend WithEvents DotNetBarManager As DevComponents.DotNetBar.DotNetBarManager
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.StyleManager = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.RbnMain = New DevComponents.DotNetBar.RibbonControl()
        Me.RibbonPanel3 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RbnControlPanel = New DevComponents.DotNetBar.RibbonBar()
        Me.btnSetupParam = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuParamSystem = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuParamKomp = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuSetupUser = New DevComponents.DotNetBar.ButtonItem()
        Me.RbnPanelTrs = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBarLaporan = New DevComponents.DotNetBar.RibbonBar()
        Me.mnuLapKasir = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBarBO = New DevComponents.DotNetBar.RibbonBar()
        Me.mnuEntryHasil = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuCetakHasil = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBarFO = New DevComponents.DotNetBar.RibbonBar()
        Me.mnuTrsRegistrasi = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuTrsUji = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuTrsKasir = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonPanel2 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RbnSetupMaster = New DevComponents.DotNetBar.RibbonBar()
        Me.mnuTarif = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuNamaTarif = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuKompTarif = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuSetupUji = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuGrupUji = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuJenisUji = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuMasterSample = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuGrupSample = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuJenisSample = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonTabItem1 = New DevComponents.DotNetBar.RibbonTabItem()
        Me.RibbonTabItem2 = New DevComponents.DotNetBar.RibbonTabItem()
        Me.rbnCP = New DevComponents.DotNetBar.RibbonTabItem()
        Me.Office2007StartButton1 = New DevComponents.DotNetBar.Office2007StartButton()
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer2 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer3 = New DevComponents.DotNetBar.ItemContainer()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem6 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem7 = New DevComponents.DotNetBar.ButtonItem()
        Me.GalleryContainer1 = New DevComponents.DotNetBar.GalleryContainer()
        Me.labelItem8 = New DevComponents.DotNetBar.LabelItem()
        Me.ButtonItem8 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem9 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem10 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem11 = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer4 = New DevComponents.DotNetBar.ItemContainer()
        Me.ButtonItem12 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem13 = New DevComponents.DotNetBar.ButtonItem()
        Me.QatCustomizeItem1 = New DevComponents.DotNetBar.QatCustomizeItem()
        Me.DotNetBarManager = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite8 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite5 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite6 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite7 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.xTglJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.xServer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.xVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.xUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.xTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RbnMain.SuspendLayout()
        Me.RibbonPanel3.SuspendLayout()
        Me.RbnPanelTrs.SuspendLayout()
        Me.RibbonPanel2.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'StyleManager
        '
        Me.StyleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue
        Me.StyleManager.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
        '
        'RbnMain
        '
        '
        '
        '
        Me.RbnMain.BackgroundStyle.Class = ""
        Me.RbnMain.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RbnMain.CaptionVisible = True
        Me.RbnMain.Controls.Add(Me.RibbonPanel3)
        Me.RbnMain.Controls.Add(Me.RbnPanelTrs)
        Me.RbnMain.Controls.Add(Me.RibbonPanel2)
        Me.RbnMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.RbnMain.Expanded = False
        Me.RbnMain.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.RibbonTabItem1, Me.RibbonTabItem2, Me.rbnCP})
        Me.RbnMain.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.RbnMain.Location = New System.Drawing.Point(5, 1)
        Me.RbnMain.MdiSystemItemVisible = False
        Me.RbnMain.Name = "RbnMain"
        Me.RbnMain.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.RbnMain.QuickToolbarItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Office2007StartButton1, Me.QatCustomizeItem1})
        Me.RbnMain.Size = New System.Drawing.Size(998, 172)
        Me.RbnMain.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RbnMain.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
        Me.RbnMain.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
        Me.RbnMain.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
        Me.RbnMain.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
        Me.RbnMain.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
        Me.RbnMain.SystemText.QatDialogAddButton = "&Add >>"
        Me.RbnMain.SystemText.QatDialogCancelButton = "Cancel"
        Me.RbnMain.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
        Me.RbnMain.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
        Me.RbnMain.SystemText.QatDialogOkButton = "OK"
        Me.RbnMain.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
        Me.RbnMain.SystemText.QatDialogRemoveButton = "&Remove"
        Me.RbnMain.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
        Me.RbnMain.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
        Me.RbnMain.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
        Me.RbnMain.TabGroupHeight = 14
        Me.RbnMain.TabGroupsVisible = True
        Me.RbnMain.TabIndex = 9
        Me.RbnMain.Text = "RibbonControl1"
        '
        'RibbonPanel3
        '
        Me.RibbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel3.Controls.Add(Me.RbnControlPanel)
        Me.RibbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel3.Location = New System.Drawing.Point(0, 57)
        Me.RibbonPanel3.Name = "RibbonPanel3"
        Me.RibbonPanel3.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel3.Size = New System.Drawing.Size(998, 113)
        '
        '
        '
        Me.RibbonPanel3.Style.Class = ""
        Me.RibbonPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel3.StyleMouseDown.Class = ""
        Me.RibbonPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel3.StyleMouseOver.Class = ""
        Me.RibbonPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel3.TabIndex = 3
        '
        'RbnControlPanel
        '
        Me.RbnControlPanel.AutoOverflowEnabled = True
        '
        '
        '
        Me.RbnControlPanel.BackgroundMouseOverStyle.Class = ""
        Me.RbnControlPanel.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RbnControlPanel.BackgroundStyle.Class = ""
        Me.RbnControlPanel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RbnControlPanel.ContainerControlProcessDialogKey = True
        Me.RbnControlPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.RbnControlPanel.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnSetupParam, Me.mnuSetupUser})
        Me.RbnControlPanel.Location = New System.Drawing.Point(3, 0)
        Me.RbnControlPanel.Name = "RbnControlPanel"
        Me.RbnControlPanel.Size = New System.Drawing.Size(143, 110)
        Me.RbnControlPanel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RbnControlPanel.TabIndex = 0
        Me.RbnControlPanel.Text = "Control Panel"
        '
        '
        '
        Me.RbnControlPanel.TitleStyle.Class = ""
        Me.RbnControlPanel.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RbnControlPanel.TitleStyleMouseOver.Class = ""
        Me.RbnControlPanel.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'btnSetupParam
        '
        Me.btnSetupParam.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnSetupParam.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSetupParam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSetupParam.Image = Global.balailab.My.Resources.Resources.param_komp
        Me.btnSetupParam.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnSetupParam.Name = "btnSetupParam"
        Me.btnSetupParam.PopupSide = DevComponents.DotNetBar.ePopupSide.Bottom
        Me.btnSetupParam.RibbonWordWrap = False
        Me.btnSetupParam.Stretch = True
        Me.btnSetupParam.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuParamSystem, Me.mnuParamKomp})
        Me.btnSetupParam.SubItemsExpandWidth = 20
        Me.btnSetupParam.Text = "Parameter"
        '
        'mnuParamSystem
        '
        Me.mnuParamSystem.Name = "mnuParamSystem"
        Me.mnuParamSystem.Text = "System"
        '
        'mnuParamKomp
        '
        Me.mnuParamKomp.Name = "mnuParamKomp"
        Me.mnuParamKomp.Text = "Komputer"
        '
        'mnuSetupUser
        '
        Me.mnuSetupUser.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuSetupUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.mnuSetupUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuSetupUser.Image = Global.balailab.My.Resources.Resources.user
        Me.mnuSetupUser.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuSetupUser.Name = "mnuSetupUser"
        Me.mnuSetupUser.SubItemsExpandWidth = 14
        Me.mnuSetupUser.Text = "User"
        '
        'RbnPanelTrs
        '
        Me.RbnPanelTrs.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RbnPanelTrs.Controls.Add(Me.RibbonBarLaporan)
        Me.RbnPanelTrs.Controls.Add(Me.RibbonBarBO)
        Me.RbnPanelTrs.Controls.Add(Me.RibbonBarFO)
        Me.RbnPanelTrs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RbnPanelTrs.Location = New System.Drawing.Point(0, 57)
        Me.RbnPanelTrs.Name = "RbnPanelTrs"
        Me.RbnPanelTrs.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RbnPanelTrs.Size = New System.Drawing.Size(998, 113)
        '
        '
        '
        Me.RbnPanelTrs.Style.Class = ""
        Me.RbnPanelTrs.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RbnPanelTrs.StyleMouseDown.Class = ""
        Me.RbnPanelTrs.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RbnPanelTrs.StyleMouseOver.Class = ""
        Me.RbnPanelTrs.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RbnPanelTrs.TabIndex = 1
        Me.RbnPanelTrs.Visible = False
        '
        'RibbonBarLaporan
        '
        Me.RibbonBarLaporan.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBarLaporan.BackgroundMouseOverStyle.Class = ""
        Me.RibbonBarLaporan.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBarLaporan.BackgroundStyle.Class = ""
        Me.RibbonBarLaporan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBarLaporan.ContainerControlProcessDialogKey = True
        Me.RibbonBarLaporan.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuLapKasir})
        Me.RibbonBarLaporan.Location = New System.Drawing.Point(379, 0)
        Me.RibbonBarLaporan.Name = "RibbonBarLaporan"
        Me.RibbonBarLaporan.ResizeItemsToFit = False
        Me.RibbonBarLaporan.Size = New System.Drawing.Size(176, 92)
        Me.RibbonBarLaporan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBarLaporan.TabIndex = 2
        Me.RibbonBarLaporan.Text = "Laporan"
        '
        '
        '
        Me.RibbonBarLaporan.TitleStyle.Class = ""
        Me.RibbonBarLaporan.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBarLaporan.TitleStyleMouseOver.Class = ""
        Me.RibbonBarLaporan.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBarLaporan.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
        '
        'mnuLapKasir
        '
        Me.mnuLapKasir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuLapKasir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.mnuLapKasir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuLapKasir.Image = Global.balailab.My.Resources.Resources.report_kasir
        Me.mnuLapKasir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuLapKasir.Name = "mnuLapKasir"
        Me.mnuLapKasir.RibbonWordWrap = False
        Me.mnuLapKasir.SubItemsExpandWidth = 14
        Me.mnuLapKasir.Text = "Laporan Kasir"
        '
        'RibbonBarBO
        '
        Me.RibbonBarBO.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBarBO.BackgroundMouseOverStyle.Class = ""
        Me.RibbonBarBO.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBarBO.BackgroundStyle.Class = ""
        Me.RibbonBarBO.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBarBO.ContainerControlProcessDialogKey = True
        Me.RibbonBarBO.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuEntryHasil, Me.mnuCetakHasil})
        Me.RibbonBarBO.Location = New System.Drawing.Point(197, 0)
        Me.RibbonBarBO.Name = "RibbonBarBO"
        Me.RibbonBarBO.ResizeItemsToFit = False
        Me.RibbonBarBO.Size = New System.Drawing.Size(176, 92)
        Me.RibbonBarBO.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBarBO.TabIndex = 1
        Me.RibbonBarBO.Text = "Back Office"
        '
        '
        '
        Me.RibbonBarBO.TitleStyle.Class = ""
        Me.RibbonBarBO.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBarBO.TitleStyleMouseOver.Class = ""
        Me.RibbonBarBO.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBarBO.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
        '
        'mnuEntryHasil
        '
        Me.mnuEntryHasil.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuEntryHasil.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.mnuEntryHasil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuEntryHasil.Image = Global.balailab.My.Resources.Resources.microscope_icon_50x50
        Me.mnuEntryHasil.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuEntryHasil.Name = "mnuEntryHasil"
        Me.mnuEntryHasil.SubItemsExpandWidth = 14
        Me.mnuEntryHasil.Text = "Hasil Uji"
        '
        'mnuCetakHasil
        '
        Me.mnuCetakHasil.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuCetakHasil.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.mnuCetakHasil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuCetakHasil.Image = Global.balailab.My.Resources.Resources.cetak_hasil_50x50
        Me.mnuCetakHasil.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuCetakHasil.Name = "mnuCetakHasil"
        Me.mnuCetakHasil.RibbonWordWrap = False
        Me.mnuCetakHasil.SubItemsExpandWidth = 14
        Me.mnuCetakHasil.Text = "Cetak Hasil"
        '
        'RibbonBarFO
        '
        Me.RibbonBarFO.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBarFO.BackgroundMouseOverStyle.Class = ""
        Me.RibbonBarFO.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBarFO.BackgroundStyle.Class = ""
        Me.RibbonBarFO.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBarFO.ContainerControlProcessDialogKey = True
        Me.RibbonBarFO.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuTrsRegistrasi, Me.mnuTrsUji, Me.mnuTrsKasir})
        Me.RibbonBarFO.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBarFO.Name = "RibbonBarFO"
        Me.RibbonBarFO.ResizeItemsToFit = False
        Me.RibbonBarFO.Size = New System.Drawing.Size(192, 92)
        Me.RibbonBarFO.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBarFO.TabIndex = 0
        Me.RibbonBarFO.Text = "Front Office"
        '
        '
        '
        Me.RibbonBarFO.TitleStyle.Class = ""
        Me.RibbonBarFO.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBarFO.TitleStyleMouseOver.Class = ""
        Me.RibbonBarFO.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBarFO.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
        '
        'mnuTrsRegistrasi
        '
        Me.mnuTrsRegistrasi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuTrsRegistrasi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.mnuTrsRegistrasi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuTrsRegistrasi.GlobalName = "mnuTrsRegistrasi"
        Me.mnuTrsRegistrasi.Image = Global.balailab.My.Resources.Resources._1282709929_PatientFile_50x50
        Me.mnuTrsRegistrasi.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.[Default]
        Me.mnuTrsRegistrasi.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuTrsRegistrasi.Name = "mnuTrsRegistrasi"
        Me.mnuTrsRegistrasi.SubItemsExpandWidth = 14
        Me.mnuTrsRegistrasi.Text = "Sampling"
        '
        'mnuTrsUji
        '
        Me.mnuTrsUji.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuTrsUji.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.mnuTrsUji.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuTrsUji.Image = Global.balailab.My.Resources.Resources._1282710427_laboratory_50x50
        Me.mnuTrsUji.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuTrsUji.Name = "mnuTrsUji"
        Me.mnuTrsUji.SubItemsExpandWidth = 14
        Me.mnuTrsUji.Text = "Billing"
        '
        'mnuTrsKasir
        '
        Me.mnuTrsKasir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuTrsKasir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.mnuTrsKasir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuTrsKasir.Image = Global.balailab.My.Resources.Resources._1282710390_Money_Bag_50x50
        Me.mnuTrsKasir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuTrsKasir.Name = "mnuTrsKasir"
        Me.mnuTrsKasir.SubItemsExpandWidth = 14
        Me.mnuTrsKasir.Text = "Kasir"
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel2.Controls.Add(Me.RbnSetupMaster)
        Me.RibbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel2.Location = New System.Drawing.Point(0, 57)
        Me.RibbonPanel2.Name = "RibbonPanel2"
        Me.RibbonPanel2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel2.Size = New System.Drawing.Size(998, 113)
        '
        '
        '
        Me.RibbonPanel2.Style.Class = ""
        Me.RibbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel2.StyleMouseDown.Class = ""
        Me.RibbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel2.StyleMouseOver.Class = ""
        Me.RibbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel2.TabIndex = 2
        Me.RibbonPanel2.Visible = False
        '
        'RbnSetupMaster
        '
        Me.RbnSetupMaster.AutoOverflowEnabled = True
        '
        '
        '
        Me.RbnSetupMaster.BackgroundMouseOverStyle.Class = ""
        Me.RbnSetupMaster.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RbnSetupMaster.BackgroundStyle.Class = ""
        Me.RbnSetupMaster.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RbnSetupMaster.ContainerControlProcessDialogKey = True
        Me.RbnSetupMaster.Dock = System.Windows.Forms.DockStyle.Left
        Me.RbnSetupMaster.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuTarif, Me.mnuSetupUji, Me.mnuMasterSample})
        Me.RbnSetupMaster.Location = New System.Drawing.Point(3, 0)
        Me.RbnSetupMaster.Name = "RbnSetupMaster"
        Me.RbnSetupMaster.Size = New System.Drawing.Size(200, 110)
        Me.RbnSetupMaster.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RbnSetupMaster.TabIndex = 0
        Me.RbnSetupMaster.Text = "Setup Master"
        '
        '
        '
        Me.RbnSetupMaster.TitleStyle.Class = ""
        Me.RbnSetupMaster.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RbnSetupMaster.TitleStyleMouseOver.Class = ""
        Me.RbnSetupMaster.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'mnuTarif
        '
        Me.mnuTarif.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuTarif.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.mnuTarif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuTarif.Image = Global.balailab.My.Resources.Resources._1282710390_Money_Bag_50x50
        Me.mnuTarif.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuTarif.Name = "mnuTarif"
        Me.mnuTarif.PopupSide = DevComponents.DotNetBar.ePopupSide.Bottom
        Me.mnuTarif.RibbonWordWrap = False
        Me.mnuTarif.Stretch = True
        Me.mnuTarif.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuNamaTarif, Me.mnuKompTarif})
        Me.mnuTarif.SubItemsExpandWidth = 20
        Me.mnuTarif.Text = "Tarif"
        '
        'mnuNamaTarif
        '
        Me.mnuNamaTarif.Name = "mnuNamaTarif"
        Me.mnuNamaTarif.Text = "Nama Tarif"
        '
        'mnuKompTarif
        '
        Me.mnuKompTarif.Name = "mnuKompTarif"
        Me.mnuKompTarif.Text = "Komponen Tarif"
        '
        'mnuSetupUji
        '
        Me.mnuSetupUji.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuSetupUji.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.mnuSetupUji.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuSetupUji.Image = Global.balailab.My.Resources.Resources.lab_50x50
        Me.mnuSetupUji.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuSetupUji.Name = "mnuSetupUji"
        Me.mnuSetupUji.PopupSide = DevComponents.DotNetBar.ePopupSide.Bottom
        Me.mnuSetupUji.RibbonWordWrap = False
        Me.mnuSetupUji.Stretch = True
        Me.mnuSetupUji.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuGrupUji, Me.mnuJenisUji})
        Me.mnuSetupUji.SubItemsExpandWidth = 20
        Me.mnuSetupUji.Text = "Uji"
        '
        'mnuGrupUji
        '
        Me.mnuGrupUji.Name = "mnuGrupUji"
        Me.mnuGrupUji.Text = "Grup Jenis Uji"
        '
        'mnuJenisUji
        '
        Me.mnuJenisUji.Name = "mnuJenisUji"
        Me.mnuJenisUji.Text = "Jenis Uji"
        '
        'mnuMasterSample
        '
        Me.mnuMasterSample.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuMasterSample.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.mnuMasterSample.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuMasterSample.Image = Global.balailab.My.Resources.Resources.sample2
        Me.mnuMasterSample.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuMasterSample.Name = "mnuMasterSample"
        Me.mnuMasterSample.PopupSide = DevComponents.DotNetBar.ePopupSide.Bottom
        Me.mnuMasterSample.RibbonWordWrap = False
        Me.mnuMasterSample.Stretch = True
        Me.mnuMasterSample.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuGrupSample, Me.mnuJenisSample})
        Me.mnuMasterSample.SubItemsExpandWidth = 20
        Me.mnuMasterSample.Text = "Sampling"
        '
        'mnuGrupSample
        '
        Me.mnuGrupSample.Name = "mnuGrupSample"
        Me.mnuGrupSample.Text = "Grup Sample"
        '
        'mnuJenisSample
        '
        Me.mnuJenisSample.Name = "mnuJenisSample"
        Me.mnuJenisSample.Text = "Jenis Sample"
        '
        'RibbonTabItem1
        '
        Me.RibbonTabItem1.Name = "RibbonTabItem1"
        Me.RibbonTabItem1.Panel = Me.RbnPanelTrs
        Me.RibbonTabItem1.Text = "Transaksi"
        '
        'RibbonTabItem2
        '
        Me.RibbonTabItem2.Name = "RibbonTabItem2"
        Me.RibbonTabItem2.Panel = Me.RibbonPanel2
        Me.RibbonTabItem2.Text = "Master"
        '
        'rbnCP
        '
        Me.rbnCP.Checked = True
        Me.rbnCP.Name = "rbnCP"
        Me.rbnCP.Panel = Me.RibbonPanel3
        Me.rbnCP.Text = "Control Panel"
        '
        'Office2007StartButton1
        '
        Me.Office2007StartButton1.AutoExpandOnClick = True
        Me.Office2007StartButton1.CanCustomize = False
        Me.Office2007StartButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image
        Me.Office2007StartButton1.ImagePaddingHorizontal = 2
        Me.Office2007StartButton1.ImagePaddingVertical = 2
        Me.Office2007StartButton1.Name = "Office2007StartButton1"
        Me.Office2007StartButton1.ShowSubItems = False
        Me.Office2007StartButton1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer1})
        Me.Office2007StartButton1.Text = "&File"
        '
        'ItemContainer1
        '
        '
        '
        '
        Me.ItemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer"
        Me.ItemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer1.Name = "ItemContainer1"
        Me.ItemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer2, Me.ItemContainer4})
        Me.ItemContainer1.Visible = False
        '
        'ItemContainer2
        '
        '
        '
        '
        Me.ItemContainer2.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer"
        Me.ItemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer2.ItemSpacing = 0
        Me.ItemContainer2.Name = "ItemContainer2"
        Me.ItemContainer2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer3, Me.GalleryContainer1})
        Me.ItemContainer2.Visible = False
        '
        'ItemContainer3
        '
        '
        '
        '
        Me.ItemContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer"
        Me.ItemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer3.MinimumSize = New System.Drawing.Size(120, 0)
        Me.ItemContainer3.Name = "ItemContainer3"
        Me.ItemContainer3.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem2, Me.ButtonItem3, Me.ButtonItem4, Me.ButtonItem5, Me.ButtonItem6, Me.ButtonItem7})
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.SubItemsExpandWidth = 24
        Me.ButtonItem2.Text = "&New"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.SubItemsExpandWidth = 24
        Me.ButtonItem3.Text = "&Open..."
        '
        'ButtonItem4
        '
        Me.ButtonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.SubItemsExpandWidth = 24
        Me.ButtonItem4.Text = "&Save..."
        '
        'ButtonItem5
        '
        Me.ButtonItem5.BeginGroup = True
        Me.ButtonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.SubItemsExpandWidth = 24
        Me.ButtonItem5.Text = "S&hare..."
        '
        'ButtonItem6
        '
        Me.ButtonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem6.Name = "ButtonItem6"
        Me.ButtonItem6.SubItemsExpandWidth = 24
        Me.ButtonItem6.Text = "&Print..."
        '
        'ButtonItem7
        '
        Me.ButtonItem7.BeginGroup = True
        Me.ButtonItem7.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem7.Name = "ButtonItem7"
        Me.ButtonItem7.SubItemsExpandWidth = 24
        Me.ButtonItem7.Text = "&Close"
        '
        'GalleryContainer1
        '
        '
        '
        '
        Me.GalleryContainer1.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer"
        Me.GalleryContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GalleryContainer1.EnableGalleryPopup = False
        Me.GalleryContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.GalleryContainer1.MinimumSize = New System.Drawing.Size(180, 240)
        Me.GalleryContainer1.MultiLine = False
        Me.GalleryContainer1.Name = "GalleryContainer1"
        Me.GalleryContainer1.PopupUsesStandardScrollbars = False
        Me.GalleryContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.labelItem8, Me.ButtonItem8, Me.ButtonItem9, Me.ButtonItem10, Me.ButtonItem11})
        Me.GalleryContainer1.Visible = False
        '
        'labelItem8
        '
        Me.labelItem8.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.labelItem8.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.labelItem8.CanCustomize = False
        Me.labelItem8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelItem8.Name = "labelItem8"
        Me.labelItem8.PaddingBottom = 2
        Me.labelItem8.PaddingTop = 2
        Me.labelItem8.Stretch = True
        Me.labelItem8.Text = "Recent Documents"
        '
        'ButtonItem8
        '
        Me.ButtonItem8.Name = "ButtonItem8"
        Me.ButtonItem8.Text = "&1. Short News 5-7.rtf"
        '
        'ButtonItem9
        '
        Me.ButtonItem9.Name = "ButtonItem9"
        Me.ButtonItem9.Text = "&2. Prospect Email.rtf"
        '
        'ButtonItem10
        '
        Me.ButtonItem10.Name = "ButtonItem10"
        Me.ButtonItem10.Text = "&3. Customer Email.rtf"
        '
        'ButtonItem11
        '
        Me.ButtonItem11.Name = "ButtonItem11"
        Me.ButtonItem11.Text = "&4. example.rtf"
        '
        'ItemContainer4
        '
        '
        '
        '
        Me.ItemContainer4.BackgroundStyle.Class = "RibbonFileMenuBottomContainer"
        Me.ItemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer4.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right
        Me.ItemContainer4.Name = "ItemContainer4"
        Me.ItemContainer4.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem12, Me.ButtonItem13})
        '
        'ButtonItem12
        '
        Me.ButtonItem12.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem12.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonItem12.Name = "ButtonItem12"
        Me.ButtonItem12.SubItemsExpandWidth = 24
        Me.ButtonItem12.Text = "Opt&ions"
        '
        'ButtonItem13
        '
        Me.ButtonItem13.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem13.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonItem13.Name = "ButtonItem13"
        Me.ButtonItem13.SubItemsExpandWidth = 24
        Me.ButtonItem13.Text = "E&xit"
        '
        'QatCustomizeItem1
        '
        Me.QatCustomizeItem1.Name = "QatCustomizeItem1"
        '
        'DotNetBarManager
        '
        Me.DotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1)
        Me.DotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC)
        Me.DotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.DotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV)
        Me.DotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX)
        Me.DotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ)
        Me.DotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY)
        Me.DotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del)
        Me.DotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins)
        Me.DotNetBarManager.BottomDockSite = Me.DockSite4
        Me.DotNetBarManager.EnableFullSizeDock = False
        Me.DotNetBarManager.LeftDockSite = Me.DockSite1
        Me.DotNetBarManager.ParentForm = Me
        Me.DotNetBarManager.RightDockSite = Me.DockSite2
        Me.DotNetBarManager.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.DotNetBarManager.ToolbarBottomDockSite = Me.DockSite8
        Me.DotNetBarManager.ToolbarLeftDockSite = Me.DockSite5
        Me.DotNetBarManager.ToolbarRightDockSite = Me.DockSite6
        Me.DotNetBarManager.ToolbarTopDockSite = Me.DockSite7
        Me.DotNetBarManager.TopDockSite = Me.DockSite3
        '
        'DockSite4
        '
        Me.DockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite4.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite4.Location = New System.Drawing.Point(5, 548)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(998, 0)
        Me.DockSite4.TabIndex = 14
        Me.DockSite4.TabStop = False
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite1.Location = New System.Drawing.Point(5, 173)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 375)
        Me.DockSite1.TabIndex = 11
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite2.Location = New System.Drawing.Point(1003, 173)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 375)
        Me.DockSite2.TabIndex = 12
        Me.DockSite2.TabStop = False
        '
        'DockSite8
        '
        Me.DockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite8.Location = New System.Drawing.Point(5, 548)
        Me.DockSite8.Name = "DockSite8"
        Me.DockSite8.Size = New System.Drawing.Size(998, 0)
        Me.DockSite8.TabIndex = 18
        Me.DockSite8.TabStop = False
        '
        'DockSite5
        '
        Me.DockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite5.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite5.Location = New System.Drawing.Point(5, 1)
        Me.DockSite5.Name = "DockSite5"
        Me.DockSite5.Size = New System.Drawing.Size(0, 547)
        Me.DockSite5.TabIndex = 15
        Me.DockSite5.TabStop = False
        '
        'DockSite6
        '
        Me.DockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite6.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite6.Location = New System.Drawing.Point(1003, 1)
        Me.DockSite6.Name = "DockSite6"
        Me.DockSite6.Size = New System.Drawing.Size(0, 547)
        Me.DockSite6.TabIndex = 16
        Me.DockSite6.TabStop = False
        '
        'DockSite7
        '
        Me.DockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite7.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite7.Location = New System.Drawing.Point(5, 1)
        Me.DockSite7.Name = "DockSite7"
        Me.DockSite7.Size = New System.Drawing.Size(998, 0)
        Me.DockSite7.TabIndex = 17
        Me.DockSite7.TabStop = False
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite3.Location = New System.Drawing.Point(5, 1)
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(998, 0)
        Me.DockSite3.TabIndex = 13
        Me.DockSite3.TabStop = False
        '
        'StatusStrip
        '
        Me.StatusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.xTglJam, Me.xServer, Me.xVersion, Me.xUser})
        Me.StatusStrip.Location = New System.Drawing.Point(5, 524)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StatusStrip.ShowItemToolTips = True
        Me.StatusStrip.Size = New System.Drawing.Size(998, 24)
        Me.StatusStrip.TabIndex = 20
        '
        'xTglJam
        '
        Me.xTglJam.BackColor = System.Drawing.Color.Transparent
        Me.xTglJam.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.xTglJam.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.xTglJam.Name = "xTglJam"
        Me.xTglJam.Size = New System.Drawing.Size(54, 19)
        Me.xTglJam.Text = "xTglJam"
        '
        'xServer
        '
        Me.xServer.BackColor = System.Drawing.Color.Transparent
        Me.xServer.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.xServer.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.xServer.Name = "xServer"
        Me.xServer.Size = New System.Drawing.Size(52, 19)
        Me.xServer.Text = "Server : "
        '
        'xVersion
        '
        Me.xVersion.BackColor = System.Drawing.Color.Transparent
        Me.xVersion.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.xVersion.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.xVersion.Name = "xVersion"
        Me.xVersion.Size = New System.Drawing.Size(34, 19)
        Me.xVersion.Text = "Ver :"
        '
        'xUser
        '
        Me.xUser.BackColor = System.Drawing.Color.Transparent
        Me.xUser.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.xUser.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.xUser.Name = "xUser"
        Me.xUser.Size = New System.Drawing.Size(62, 19)
        Me.xUser.Text = "Petugas : "
        '
        'xTimer
        '
        Me.xTimer.Enabled = True
        Me.xTimer.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.balailab.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1008, 550)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.DockSite2)
        Me.Controls.Add(Me.DockSite1)
        Me.Controls.Add(Me.RbnMain)
        Me.Controls.Add(Me.DockSite3)
        Me.Controls.Add(Me.DockSite4)
        Me.Controls.Add(Me.DockSite5)
        Me.Controls.Add(Me.DockSite6)
        Me.Controls.Add(Me.DockSite7)
        Me.Controls.Add(Me.DockSite8)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balai Besar Lab & Kesehatan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.RbnMain.ResumeLayout(False)
        Me.RbnMain.PerformLayout()
        Me.RibbonPanel3.ResumeLayout(False)
        Me.RbnPanelTrs.ResumeLayout(False)
        Me.RibbonPanel2.ResumeLayout(False)
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StyleManager As DevComponents.DotNetBar.StyleManager
    Friend WithEvents RbnMain As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents RibbonPanel2 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents Office2007StartButton1 As DevComponents.DotNetBar.Office2007StartButton
    Friend WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer2 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer3 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem6 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem7 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents GalleryContainer1 As DevComponents.DotNetBar.GalleryContainer
    Friend WithEvents labelItem8 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ButtonItem8 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem9 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem10 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem11 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ItemContainer4 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonItem12 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem13 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonTabItem1 As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents RibbonTabItem2 As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents QatCustomizeItem1 As DevComponents.DotNetBar.QatCustomizeItem
    Friend WithEvents mnuTrsRegistrasi As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuTrsUji As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuTrsKasir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite5 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite6 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite7 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite8 As DevComponents.DotNetBar.DockSite
    Friend WithEvents RbnPanelTrs As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonBarFO As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents xUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents xServer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents xTglJam As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents xTimer As System.Windows.Forms.Timer
    Friend WithEvents RibbonBarBO As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents mnuEntryHasil As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents xVersion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnuCetakHasil As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RbnSetupMaster As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents mnuTarif As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuNamaTarif As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuKompTarif As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonPanel3 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RbnControlPanel As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents btnSetupParam As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuParamSystem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuParamKomp As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents rbnCP As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents mnuSetupUji As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuGrupUji As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuJenisUji As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuSetupUser As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuMasterSample As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuJenisSample As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuGrupSample As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBarLaporan As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents mnuLapKasir As DevComponents.DotNetBar.ButtonItem

End Class

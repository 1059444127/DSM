namespace DSMUI
{
  partial class FrmMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
      this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
      this.pageSales = new DevExpress.XtraNavBar.NavBarGroup();
      this.itemSales = new DevExpress.XtraNavBar.NavBarItem();
      this.itemSaleBill = new DevExpress.XtraNavBar.NavBarItem();
      this.pageSys = new DevExpress.XtraNavBar.NavBarGroup();
      this.itemUser = new DevExpress.XtraNavBar.NavBarItem();
      this.itemRole = new DevExpress.XtraNavBar.NavBarItem();
      this.itemModel = new DevExpress.XtraNavBar.NavBarItem();
      this.itemParm = new DevExpress.XtraNavBar.NavBarItem();
      this.pageBasics = new DevExpress.XtraNavBar.NavBarGroup();
      this.itemDrugInfo = new DevExpress.XtraNavBar.NavBarItem();
      this.itemPayService = new DevExpress.XtraNavBar.NavBarItem();
      this.itemMedicalUint = new DevExpress.XtraNavBar.NavBarItem();
      this.itemVender = new DevExpress.XtraNavBar.NavBarItem();
      this.itemDrugState = new DevExpress.XtraNavBar.NavBarItem();
      this.itemBarcode = new DevExpress.XtraNavBar.NavBarItem();
      this.pageHouse = new DevExpress.XtraNavBar.NavBarGroup();
      this.itemHouseStorage = new DevExpress.XtraNavBar.NavBarItem();
      this.itemInStore = new DevExpress.XtraNavBar.NavBarItem();
      this.itemOutStore = new DevExpress.XtraNavBar.NavBarItem();
      this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
      this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
      this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
      this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
      ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
      this.xtraTabControl1.SuspendLayout();
      this.SuspendLayout();
      // 
      // navBarControl1
      // 
      this.navBarControl1.ActiveGroup = this.pageSys;
      this.navBarControl1.Appearance.GroupHeader.Font = new System.Drawing.Font("Tahoma", 12F);
      this.navBarControl1.Appearance.GroupHeader.Options.UseFont = true;
      this.navBarControl1.Appearance.GroupHeaderActive.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
      this.navBarControl1.Appearance.GroupHeaderActive.Options.UseFont = true;
      this.navBarControl1.Appearance.Item.Font = new System.Drawing.Font("Tahoma", 10F);
      this.navBarControl1.Appearance.Item.Options.UseFont = true;
      this.navBarControl1.Appearance.ItemActive.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
      this.navBarControl1.Appearance.ItemActive.Options.UseFont = true;
      this.navBarControl1.Appearance.ItemPressed.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
      this.navBarControl1.Appearance.ItemPressed.Options.UseFont = true;
      this.navBarControl1.Appearance.NavigationPaneHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
      this.navBarControl1.Appearance.NavigationPaneHeader.Options.UseFont = true;
      this.navBarControl1.Appearance.NavigationPaneHeader.Options.UseTextOptions = true;
      this.navBarControl1.Appearance.NavigationPaneHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.navBarControl1.Appearance.NavigationPaneHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
      this.navBarControl1.Font = new System.Drawing.Font("Tahoma", 9F);
      this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.pageSys,
            this.pageBasics,
            this.pageHouse,
            this.pageSales});
      this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.itemUser,
            this.itemRole,
            this.itemModel,
            this.itemDrugInfo,
            this.itemPayService,
            this.itemMedicalUint,
            this.itemParm,
            this.itemVender,
            this.itemDrugState,
            this.itemBarcode,
            this.itemHouseStorage,
            this.itemInStore,
            this.itemOutStore,
            this.itemSales,
            this.itemSaleBill});
      this.navBarControl1.Location = new System.Drawing.Point(0, 25);
      this.navBarControl1.MenuManager = this.ribbonControl1;
      this.navBarControl1.Name = "navBarControl1";
      this.navBarControl1.OptionsNavPane.ExpandedWidth = 206;
      this.navBarControl1.Size = new System.Drawing.Size(206, 484);
      this.navBarControl1.TabIndex = 0;
      this.navBarControl1.Text = "navBarControl1";
      this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneViewInfoRegistrator();
      // 
      // pageSales
      // 
      this.pageSales.Caption = "零售";
      this.pageSales.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemSales),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemSaleBill)});
      this.pageSales.LargeImage = ((System.Drawing.Image)(resources.GetObject("pageSales.LargeImage")));
      this.pageSales.Name = "pageSales";
      // 
      // itemSales
      // 
      this.itemSales.Caption = "零售收费";
      this.itemSales.Name = "itemSales";
      this.itemSales.SmallImage = ((System.Drawing.Image)(resources.GetObject("itemSales.SmallImage")));
      // 
      // itemSaleBill
      // 
      this.itemSaleBill.Caption = "零售账单";
      this.itemSaleBill.Name = "itemSaleBill";
      this.itemSaleBill.SmallImage = ((System.Drawing.Image)(resources.GetObject("itemSaleBill.SmallImage")));
      // 
      // pageSys
      // 
      this.pageSys.Caption = "系统";
      this.pageSys.Expanded = true;
      this.pageSys.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemUser),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemRole),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemModel),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemParm)});
      this.pageSys.LargeImage = ((System.Drawing.Image)(resources.GetObject("pageSys.LargeImage")));
      this.pageSys.Name = "pageSys";
      // 
      // itemUser
      // 
      this.itemUser.Caption = "用户管理";
      this.itemUser.Name = "itemUser";
      this.itemUser.SmallImage = ((System.Drawing.Image)(resources.GetObject("itemUser.SmallImage")));
      // 
      // itemRole
      // 
      this.itemRole.Caption = "角色管理";
      this.itemRole.Name = "itemRole";
      this.itemRole.SmallImage = ((System.Drawing.Image)(resources.GetObject("itemRole.SmallImage")));
      // 
      // itemModel
      // 
      this.itemModel.Caption = "模块管理";
      this.itemModel.Name = "itemModel";
      this.itemModel.SmallImage = ((System.Drawing.Image)(resources.GetObject("itemModel.SmallImage")));
      // 
      // itemParm
      // 
      this.itemParm.Caption = "系统设置";
      this.itemParm.Name = "itemParm";
      this.itemParm.SmallImage = ((System.Drawing.Image)(resources.GetObject("itemParm.SmallImage")));
      // 
      // pageBasics
      // 
      this.pageBasics.Caption = "基础";
      this.pageBasics.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemDrugInfo),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemPayService),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemMedicalUint),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemVender),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemDrugState),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemBarcode)});
      this.pageBasics.LargeImage = ((System.Drawing.Image)(resources.GetObject("pageBasics.LargeImage")));
      this.pageBasics.Name = "pageBasics";
      // 
      // itemDrugInfo
      // 
      this.itemDrugInfo.Caption = "药品字典";
      this.itemDrugInfo.Name = "itemDrugInfo";
      this.itemDrugInfo.SmallImage = ((System.Drawing.Image)(resources.GetObject("itemDrugInfo.SmallImage")));
      // 
      // itemPayService
      // 
      this.itemPayService.Caption = "收费项目";
      this.itemPayService.Name = "itemPayService";
      this.itemPayService.SmallImage = ((System.Drawing.Image)(resources.GetObject("itemPayService.SmallImage")));
      // 
      // itemMedicalUint
      // 
      this.itemMedicalUint.Caption = "医嘱单元";
      this.itemMedicalUint.Name = "itemMedicalUint";
      this.itemMedicalUint.SmallImage = ((System.Drawing.Image)(resources.GetObject("itemMedicalUint.SmallImage")));
      // 
      // itemVender
      // 
      this.itemVender.Caption = "药品厂家";
      this.itemVender.Name = "itemVender";
      this.itemVender.SmallImage = ((System.Drawing.Image)(resources.GetObject("itemVender.SmallImage")));
      // 
      // itemDrugState
      // 
      this.itemDrugState.Caption = "药品启禁";
      this.itemDrugState.Name = "itemDrugState";
      this.itemDrugState.SmallImage = ((System.Drawing.Image)(resources.GetObject("itemDrugState.SmallImage")));
      // 
      // itemBarcode
      // 
      this.itemBarcode.Caption = "条码信息";
      this.itemBarcode.Name = "itemBarcode";
      this.itemBarcode.SmallImage = ((System.Drawing.Image)(resources.GetObject("itemBarcode.SmallImage")));
      // 
      // pageHouse
      // 
      this.pageHouse.Caption = "药房";
      this.pageHouse.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemHouseStorage),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemInStore),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemOutStore)});
      this.pageHouse.LargeImage = ((System.Drawing.Image)(resources.GetObject("pageHouse.LargeImage")));
      this.pageHouse.Name = "pageHouse";
      // 
      // itemHouseStorage
      // 
      this.itemHouseStorage.Caption = "药房库存";
      this.itemHouseStorage.Name = "itemHouseStorage";
      this.itemHouseStorage.SmallImage = ((System.Drawing.Image)(resources.GetObject("itemHouseStorage.SmallImage")));
      // 
      // itemInStore
      // 
      this.itemInStore.Caption = "入库管理";
      this.itemInStore.Name = "itemInStore";
      this.itemInStore.SmallImage = ((System.Drawing.Image)(resources.GetObject("itemInStore.SmallImage")));
      // 
      // itemOutStore
      // 
      this.itemOutStore.Caption = "出库管理";
      this.itemOutStore.Name = "itemOutStore";
      this.itemOutStore.SmallImage = ((System.Drawing.Image)(resources.GetObject("itemOutStore.SmallImage")));
      // 
      // ribbonControl1
      // 
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
      this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
      this.ribbonControl1.MaxItemId = 1;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
      this.ribbonControl1.Size = new System.Drawing.Size(1060, 25);
      this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
      this.ribbonControl1.Visible = false;
      // 
      // ribbonStatusBar1
      // 
      this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 509);
      this.ribbonStatusBar1.Name = "ribbonStatusBar1";
      this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
      this.ribbonStatusBar1.Size = new System.Drawing.Size(1060, 27);
      // 
      // xtraTabControl1
      // 
      this.xtraTabControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.xtraTabControl1.Location = new System.Drawing.Point(206, 25);
      this.xtraTabControl1.Name = "xtraTabControl1";
      this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
      this.xtraTabControl1.Size = new System.Drawing.Size(854, 484);
      this.xtraTabControl1.TabIndex = 1;
      this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
      // 
      // xtraTabPage1
      // 
      this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(0);
      this.xtraTabPage1.Name = "xtraTabPage1";
      this.xtraTabPage1.Size = new System.Drawing.Size(848, 455);
      this.xtraTabPage1.Text = "xtraTabPage1";
      // 
      // xtraTabPage2
      // 
      this.xtraTabPage2.Name = "xtraTabPage2";
      this.xtraTabPage2.Size = new System.Drawing.Size(848, 455);
      this.xtraTabPage2.Text = "xtraTabPage2";
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1060, 536);
      this.Controls.Add(this.xtraTabControl1);
      this.Controls.Add(this.navBarControl1);
      this.Controls.Add(this.ribbonControl1);
      this.Controls.Add(this.ribbonStatusBar1);
      this.Name = "FrmMain";
      this.Text = "FrmMain";
      ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
      this.xtraTabControl1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraNavBar.NavBarControl navBarControl1;
    private DevExpress.XtraNavBar.NavBarGroup pageSys;
    private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
    private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
    private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
    private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
    private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
    private DevExpress.XtraNavBar.NavBarGroup pageBasics;
    private DevExpress.XtraNavBar.NavBarGroup pageHouse;
    private DevExpress.XtraNavBar.NavBarGroup pageSales;
    private DevExpress.XtraNavBar.NavBarItem itemUser;
    private DevExpress.XtraNavBar.NavBarItem itemRole;
    private DevExpress.XtraNavBar.NavBarItem itemModel;
    private DevExpress.XtraNavBar.NavBarItem itemParm;
    private DevExpress.XtraNavBar.NavBarItem itemDrugInfo;
    private DevExpress.XtraNavBar.NavBarItem itemPayService;
    private DevExpress.XtraNavBar.NavBarItem itemMedicalUint;
    private DevExpress.XtraNavBar.NavBarItem itemVender;
    private DevExpress.XtraNavBar.NavBarItem itemSales;
    private DevExpress.XtraNavBar.NavBarItem itemSaleBill;
    private DevExpress.XtraNavBar.NavBarItem itemDrugState;
    private DevExpress.XtraNavBar.NavBarItem itemBarcode;
    private DevExpress.XtraNavBar.NavBarItem itemHouseStorage;
    private DevExpress.XtraNavBar.NavBarItem itemInStore;
    private DevExpress.XtraNavBar.NavBarItem itemOutStore;


  }
}
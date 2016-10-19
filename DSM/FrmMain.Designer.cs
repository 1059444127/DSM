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
      this.pageSys = new DevExpress.XtraNavBar.NavBarGroup();
      this.pageBasics = new DevExpress.XtraNavBar.NavBarGroup();
      this.pageHouse = new DevExpress.XtraNavBar.NavBarGroup();
      this.pageSales = new DevExpress.XtraNavBar.NavBarGroup();
      this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
      this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
      this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
      this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
      this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
      ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
      this.xtraTabControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
      this.SuspendLayout();
      // 
      // navBarControl1
      // 
      this.navBarControl1.ActiveGroup = this.pageSys;
      this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
      this.navBarControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
      this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.pageSys,
            this.pageBasics,
            this.pageHouse,
            this.pageSales});
      this.navBarControl1.Location = new System.Drawing.Point(0, 25);
      this.navBarControl1.MenuManager = this.ribbonControl1;
      this.navBarControl1.Name = "navBarControl1";
      this.navBarControl1.OptionsNavPane.ExpandedWidth = 206;
      this.navBarControl1.Size = new System.Drawing.Size(206, 484);
      this.navBarControl1.TabIndex = 0;
      this.navBarControl1.Text = "navBarControl1";
      this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneViewInfoRegistrator();
      // 
      // pageSys
      // 
      this.pageSys.Caption = "系统";
      this.pageSys.Expanded = true;
      this.pageSys.LargeImage = ((System.Drawing.Image)(resources.GetObject("pageSys.LargeImage")));
      this.pageSys.Name = "pageSys";
      // 
      // pageBasics
      // 
      this.pageBasics.Caption = "基础";
      this.pageBasics.LargeImage = ((System.Drawing.Image)(resources.GetObject("pageBasics.LargeImage")));
      this.pageBasics.Name = "pageBasics";
      // 
      // pageHouse
      // 
      this.pageHouse.Caption = "药房";
      this.pageHouse.LargeImage = ((System.Drawing.Image)(resources.GetObject("pageHouse.LargeImage")));
      this.pageHouse.Name = "pageHouse";
      // 
      // pageSales
      // 
      this.pageSales.Caption = "零售";
      this.pageSales.LargeImage = ((System.Drawing.Image)(resources.GetObject("pageSales.LargeImage")));
      this.pageSales.Name = "pageSales";
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
      // ribbonStatusBar1
      // 
      this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 509);
      this.ribbonStatusBar1.Name = "ribbonStatusBar1";
      this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
      this.ribbonStatusBar1.Size = new System.Drawing.Size(1060, 27);
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
      ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
      this.xtraTabControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
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


  }
}
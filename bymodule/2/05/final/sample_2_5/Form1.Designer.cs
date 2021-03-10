namespace sample_2_5 {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
      this.bar1 = new DevExpress.XtraBars.Bar();
      this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
      this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
      this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
      this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
      this.bar2 = new DevExpress.XtraBars.Bar();
      this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
      this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
      this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
      this.barToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
      this.bar3 = new DevExpress.XtraBars.Bar();
      this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
      this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
      this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
      this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
      this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
      this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
      this.groupControl1.SuspendLayout();
      this.SuspendLayout();
      // 
      // barManager1
      // 
      this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
      this.barManager1.Form = this;
      this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barButtonItem1,
            this.barSubItem2,
            this.barSubItem3,
            this.barToolbarsListItem1,
            this.barButtonItem2,
            this.barEditItem1,
            this.barButtonItem3});
      this.barManager1.MainMenu = this.bar2;
      this.barManager1.MaxItemId = 8;
      this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
      this.barManager1.StatusBar = this.bar3;
      // 
      // bar1
      // 
      this.bar1.BarName = "Tools";
      this.bar1.DockCol = 0;
      this.bar1.DockRow = 1;
      this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
      this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barEditItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
      this.bar1.Text = "Tools";
      // 
      // barButtonItem2
      // 
      this.barButtonItem2.Caption = "Save";
      this.barButtonItem2.Id = 5;
      this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
      this.barButtonItem2.Name = "barButtonItem2";
      this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
      // 
      // barButtonItem1
      // 
      this.barButtonItem1.Caption = "&Quit";
      this.barButtonItem1.Id = 1;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
      // 
      // barEditItem1
      // 
      this.barEditItem1.Caption = "Search";
      this.barEditItem1.Edit = this.repositoryItemTextEdit1;
      this.barEditItem1.Id = 6;
      this.barEditItem1.Name = "barEditItem1";
      // 
      // repositoryItemTextEdit1
      // 
      this.repositoryItemTextEdit1.AutoHeight = false;
      this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
      // 
      // bar2
      // 
      this.bar2.BarName = "Main menu";
      this.bar2.DockCol = 0;
      this.bar2.DockRow = 0;
      this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
      this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2)});
      this.bar2.OptionsBar.MultiLine = true;
      this.bar2.OptionsBar.UseWholeRow = true;
      this.bar2.Text = "Main menu";
      // 
      // barSubItem1
      // 
      this.barSubItem1.Caption = "&File";
      this.barSubItem1.Id = 0;
      this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
      this.barSubItem1.Name = "barSubItem1";
      // 
      // barSubItem2
      // 
      this.barSubItem2.Caption = "&View";
      this.barSubItem2.Id = 2;
      this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItem1)});
      this.barSubItem2.Name = "barSubItem2";
      // 
      // barSubItem3
      // 
      this.barSubItem3.Caption = "&Toolbars";
      this.barSubItem3.Id = 3;
      this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barToolbarsListItem1)});
      this.barSubItem3.Name = "barSubItem3";
      // 
      // barToolbarsListItem1
      // 
      this.barToolbarsListItem1.Caption = "barToolbarsListItem1";
      this.barToolbarsListItem1.Id = 4;
      this.barToolbarsListItem1.Name = "barToolbarsListItem1";
      // 
      // bar3
      // 
      this.bar3.BarName = "Status bar";
      this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
      this.bar3.DockCol = 0;
      this.bar3.DockRow = 0;
      this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
      this.bar3.OptionsBar.AllowQuickCustomization = false;
      this.bar3.OptionsBar.DrawDragBorder = false;
      this.bar3.OptionsBar.UseWholeRow = true;
      this.bar3.Text = "Status bar";
      // 
      // barDockControlTop
      // 
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
      this.barDockControlTop.Manager = this.barManager1;
      this.barDockControlTop.Size = new System.Drawing.Size(632, 45);
      // 
      // barDockControlBottom
      // 
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.barDockControlBottom.Location = new System.Drawing.Point(0, 258);
      this.barDockControlBottom.Manager = this.barManager1;
      this.barDockControlBottom.Size = new System.Drawing.Size(632, 20);
      // 
      // barDockControlLeft
      // 
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
      this.barDockControlLeft.Manager = this.barManager1;
      this.barDockControlLeft.Size = new System.Drawing.Size(0, 213);
      // 
      // barDockControlRight
      // 
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.barDockControlRight.Location = new System.Drawing.Point(632, 45);
      this.barDockControlRight.Manager = this.barManager1;
      this.barDockControlRight.Size = new System.Drawing.Size(0, 213);
      // 
      // popupMenu1
      // 
      this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
      this.popupMenu1.Manager = this.barManager1;
      this.popupMenu1.Name = "popupMenu1";
      // 
      // barButtonItem3
      // 
      this.barButtonItem3.Caption = "barButtonItem3";
      this.barButtonItem3.Id = 7;
      this.barButtonItem3.Name = "barButtonItem3";
      // 
      // textEdit1
      // 
      this.textEdit1.Location = new System.Drawing.Point(13, 63);
      this.textEdit1.MenuManager = this.barManager1;
      this.textEdit1.Name = "textEdit1";
      this.barManager1.SetPopupContextMenu(this.textEdit1, this.popupMenu1);
      this.textEdit1.Size = new System.Drawing.Size(100, 20);
      this.textEdit1.TabIndex = 4;
      // 
      // groupControl1
      // 
      this.groupControl1.Controls.Add(this.standaloneBarDockControl1);
      this.groupControl1.Location = new System.Drawing.Point(193, 66);
      this.groupControl1.Name = "groupControl1";
      this.groupControl1.Size = new System.Drawing.Size(340, 170);
      this.groupControl1.TabIndex = 5;
      this.groupControl1.Text = "groupControl1";
      // 
      // standaloneBarDockControl1
      // 
      this.standaloneBarDockControl1.CausesValidation = false;
      this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.standaloneBarDockControl1.Location = new System.Drawing.Point(2, 145);
      this.standaloneBarDockControl1.Manager = this.barManager1;
      this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
      this.standaloneBarDockControl1.Size = new System.Drawing.Size(336, 23);
      this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(632, 278);
      this.Controls.Add(this.groupControl1);
      this.Controls.Add(this.textEdit1);
      this.Controls.Add(this.barDockControlLeft);
      this.Controls.Add(this.barDockControlRight);
      this.Controls.Add(this.barDockControlBottom);
      this.Controls.Add(this.barDockControlTop);
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
      this.groupControl1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraBars.BarManager barManager1;
    private DevExpress.XtraBars.Bar bar1;
    private DevExpress.XtraBars.Bar bar2;
    private DevExpress.XtraBars.Bar bar3;
    private DevExpress.XtraBars.BarDockControl barDockControlTop;
    private DevExpress.XtraBars.BarDockControl barDockControlBottom;
    private DevExpress.XtraBars.BarDockControl barDockControlLeft;
    private DevExpress.XtraBars.BarDockControl barDockControlRight;
    private DevExpress.XtraBars.BarSubItem barSubItem1;
    private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    private DevExpress.XtraBars.BarSubItem barSubItem2;
    private DevExpress.XtraBars.BarSubItem barSubItem3;
    private DevExpress.XtraBars.BarToolbarsListItem barToolbarsListItem1;
    private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    private DevExpress.XtraBars.BarEditItem barEditItem1;
    private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    private DevExpress.XtraEditors.TextEdit textEdit1;
    private DevExpress.XtraBars.PopupMenu popupMenu1;
    private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
    private DevExpress.XtraEditors.GroupControl groupControl1;
  }
}


namespace sample_1_9 {
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
      this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
      this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
      this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
      this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
      this.skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
      ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
      this.SuspendLayout();
      // 
      // progressBarControl1
      // 
      this.progressBarControl1.EditValue = 60;
      this.progressBarControl1.Location = new System.Drawing.Point(219, 186);
      this.progressBarControl1.Name = "progressBarControl1";
      this.progressBarControl1.Size = new System.Drawing.Size(239, 18);
      this.progressBarControl1.TabIndex = 0;
      // 
      // textEdit1
      // 
      this.textEdit1.EditValue = "Text here";
      this.textEdit1.Location = new System.Drawing.Point(219, 227);
      this.textEdit1.Name = "textEdit1";
      this.textEdit1.Size = new System.Drawing.Size(239, 20);
      this.textEdit1.TabIndex = 1;
      // 
      // simpleButton1
      // 
      this.simpleButton1.Location = new System.Drawing.Point(383, 278);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.Size = new System.Drawing.Size(75, 23);
      this.simpleButton1.TabIndex = 2;
      this.simpleButton1.Text = "simpleButton1";
      this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
      // 
      // ribbonControl1
      // 
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.skinRibbonGalleryBarItem1,
            this.skinPaletteRibbonGalleryBarItem1});
      this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
      this.ribbonControl1.MaxItemId = 3;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
      this.ribbonControl1.Size = new System.Drawing.Size(639, 158);
      // 
      // ribbonPage1
      // 
      this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      // 
      // ribbonPageGroup1
      // 
      this.ribbonPageGroup1.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
      this.ribbonPageGroup1.ItemLinks.Add(this.skinPaletteRibbonGalleryBarItem1);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup1.Text = "ribbonPageGroup1";
      // 
      // skinRibbonGalleryBarItem1
      // 
      this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
      this.skinRibbonGalleryBarItem1.Id = 1;
      this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
      // 
      // skinPaletteRibbonGalleryBarItem1
      // 
      this.skinPaletteRibbonGalleryBarItem1.Caption = "skinPaletteRibbonGalleryBarItem1";
      this.skinPaletteRibbonGalleryBarItem1.Id = 2;
      this.skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(639, 427);
      this.Controls.Add(this.ribbonControl1);
      this.Controls.Add(this.simpleButton1);
      this.Controls.Add(this.textEdit1);
      this.Controls.Add(this.progressBarControl1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
    private DevExpress.XtraEditors.TextEdit textEdit1;
    private DevExpress.XtraEditors.SimpleButton simpleButton1;
    private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
    private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
    private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
  }
}


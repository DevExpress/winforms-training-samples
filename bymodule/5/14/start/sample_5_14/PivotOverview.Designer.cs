namespace sample_5_14 {
  partial class PivotOverview {
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
      DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding1 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
      DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding2 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
      DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding3 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
      DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding4 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
      DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding5 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
      DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding6 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
      DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding7 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
      DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding8 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
      DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding9 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
      DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding10 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
      DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding11 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
      DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding12 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
      this.roomBookingCollection = new DevExpress.Xpo.XPCollection(this.components);
      this.session = new DevExpress.Xpo.Session(this.components);
      this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
      this.printExportItem = new DevExpress.XtraBars.BarButtonItem();
      this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
      this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
      this.fieldCapacityRequirementName1 = new DevExpress.XtraPivotGrid.PivotGridField();
      this.fieldCapacityRequirementCapacity1 = new DevExpress.XtraPivotGrid.PivotGridField();
      this.fieldCapacityRequirementRoomSetup1 = new DevExpress.XtraPivotGrid.PivotGridField();
      this.fieldCapacityRequirementEventName1 = new DevExpress.XtraPivotGrid.PivotGridField();
      this.fieldCapacityRequirementEventStartDate1 = new DevExpress.XtraPivotGrid.PivotGridField();
      this.fieldCapacityRequirementEventEndDate1 = new DevExpress.XtraPivotGrid.PivotGridField();
      this.fieldCapacityRequirementEventVenueName1 = new DevExpress.XtraPivotGrid.PivotGridField();
      this.fieldCapacityRequirementEventCustomerName1 = new DevExpress.XtraPivotGrid.PivotGridField();
      this.fieldRoomName2 = new DevExpress.XtraPivotGrid.PivotGridField();
      this.fieldStartTime3 = new DevExpress.XtraPivotGrid.PivotGridField();
      this.fieldEndTime3 = new DevExpress.XtraPivotGrid.PivotGridField();
      this.fieldCapacityRequirementCapacity2 = new DevExpress.XtraPivotGrid.PivotGridField();
      ((System.ComponentModel.ISupportInitialize)(this.roomBookingCollection)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.session)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
      this.splitContainerControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
      this.SuspendLayout();
      // 
      // roomBookingCollection
      // 
      this.roomBookingCollection.ObjectType = typeof(EventsDB.RoomBooking);
      this.roomBookingCollection.Session = this.session;
      // 
      // splitContainerControl1
      // 
      this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
      this.splitContainerControl1.Horizontal = false;
      this.splitContainerControl1.Location = new System.Drawing.Point(0, 150);
      this.splitContainerControl1.Name = "splitContainerControl1";
      this.splitContainerControl1.Panel1.Controls.Add(this.pivotGridControl1);
      this.splitContainerControl1.Panel1.Text = "Panel1";
      this.splitContainerControl1.Panel2.Text = "Panel2";
      this.splitContainerControl1.Size = new System.Drawing.Size(1000, 550);
      this.splitContainerControl1.SplitterPosition = 156;
      this.splitContainerControl1.TabIndex = 1;
      this.splitContainerControl1.Text = "splitContainerControl1";
      // 
      // printExportItem
      // 
      this.printExportItem.Caption = "Print && Export";
      this.printExportItem.Id = 0;
      this.printExportItem.ImageOptions.SvgImage = global::sample_5_14.Properties.Resources.printexport;
      this.printExportItem.Name = "printExportItem";
      // 
      // ribbonControl1
      // 
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.printExportItem});
      this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
      this.ribbonControl1.MaxItemId = 1;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
      this.ribbonControl1.Size = new System.Drawing.Size(1000, 150);
      // 
      // ribbonPageCategory1
      // 
      this.ribbonPageCategory1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.ribbonPageCategory1.Appearance.Options.UseBackColor = true;
      this.ribbonPageCategory1.Name = "ribbonPageCategory1";
      this.ribbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
      this.ribbonPageCategory1.Text = "Pivot Overview";
      // 
      // ribbonPage1
      // 
      this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "Data Operations";
      // 
      // ribbonPageGroup1
      // 
      this.ribbonPageGroup1.ItemLinks.Add(this.printExportItem);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup1.Text = "Tools";
      // 
      // pivotGridControl1
      // 
      this.pivotGridControl1.DataSource = this.roomBookingCollection;
      this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCapacityRequirementName1,
            this.fieldCapacityRequirementCapacity1,
            this.fieldCapacityRequirementRoomSetup1,
            this.fieldCapacityRequirementEventName1,
            this.fieldCapacityRequirementEventStartDate1,
            this.fieldCapacityRequirementEventEndDate1,
            this.fieldCapacityRequirementEventVenueName1,
            this.fieldCapacityRequirementEventCustomerName1,
            this.fieldRoomName2,
            this.fieldStartTime3,
            this.fieldEndTime3,
            this.fieldCapacityRequirementCapacity2});
      this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
      this.pivotGridControl1.MenuManager = this.ribbonControl1;
      this.pivotGridControl1.Name = "pivotGridControl1";
      this.pivotGridControl1.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007;
      this.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
      this.pivotGridControl1.OptionsData.RetrieveNestedFields = DevExpress.Utils.DefaultBoolean.True;
      this.pivotGridControl1.OptionsMenu.ShowDateTimeGroupIntervalItems = DevExpress.XtraPivotGrid.DateTimeGroupIntervals.ExtendedIntervals;
      this.pivotGridControl1.Size = new System.Drawing.Size(1000, 384);
      this.pivotGridControl1.TabIndex = 0;
      // 
      // fieldCapacityRequirementName1
      // 
      this.fieldCapacityRequirementName1.AreaIndex = 2;
      this.fieldCapacityRequirementName1.Caption = "CapReq";
      dataSourceColumnBinding1.ColumnName = "CapacityRequirement.Name";
      this.fieldCapacityRequirementName1.DataBinding = dataSourceColumnBinding1;
      this.fieldCapacityRequirementName1.DisplayFolder = "CapacityRequirement";
      this.fieldCapacityRequirementName1.FieldName = "CapacityRequirement.Name";
      this.fieldCapacityRequirementName1.Name = "fieldCapacityRequirementName1";
      this.fieldCapacityRequirementName1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
      // 
      // fieldCapacityRequirementCapacity1
      // 
      this.fieldCapacityRequirementCapacity1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
      this.fieldCapacityRequirementCapacity1.AreaIndex = 1;
      this.fieldCapacityRequirementCapacity1.Caption = "Capacity";
      this.fieldCapacityRequirementCapacity1.CellFormat.FormatString = "n2";
      this.fieldCapacityRequirementCapacity1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      dataSourceColumnBinding2.ColumnName = "CapacityRequirement.Capacity";
      this.fieldCapacityRequirementCapacity1.DataBinding = dataSourceColumnBinding2;
      this.fieldCapacityRequirementCapacity1.DisplayFolder = "CapacityRequirement";
      this.fieldCapacityRequirementCapacity1.FieldName = "CapacityRequirement.Capacity";
      this.fieldCapacityRequirementCapacity1.Name = "fieldCapacityRequirementCapacity1";
      this.fieldCapacityRequirementCapacity1.Options.AllowRunTimeSummaryChange = true;
      this.fieldCapacityRequirementCapacity1.Options.ShowSummaryTypeName = true;
      // 
      // fieldCapacityRequirementRoomSetup1
      // 
      this.fieldCapacityRequirementRoomSetup1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
      this.fieldCapacityRequirementRoomSetup1.AreaIndex = 1;
      this.fieldCapacityRequirementRoomSetup1.Caption = "Room Setup";
      dataSourceColumnBinding3.ColumnName = "CapacityRequirement.RoomSetup";
      this.fieldCapacityRequirementRoomSetup1.DataBinding = dataSourceColumnBinding3;
      this.fieldCapacityRequirementRoomSetup1.DisplayFolder = "CapacityRequirement";
      this.fieldCapacityRequirementRoomSetup1.FieldName = "CapacityRequirement.RoomSetup";
      this.fieldCapacityRequirementRoomSetup1.Name = "fieldCapacityRequirementRoomSetup1";
      this.fieldCapacityRequirementRoomSetup1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
      // 
      // fieldCapacityRequirementEventName1
      // 
      this.fieldCapacityRequirementEventName1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
      this.fieldCapacityRequirementEventName1.AreaIndex = 0;
      this.fieldCapacityRequirementEventName1.Caption = "Event";
      dataSourceColumnBinding4.ColumnName = "CapacityRequirement.Event.Name";
      this.fieldCapacityRequirementEventName1.DataBinding = dataSourceColumnBinding4;
      this.fieldCapacityRequirementEventName1.DisplayFolder = "CapacityRequirement\\Event";
      this.fieldCapacityRequirementEventName1.FieldName = "CapacityRequirement.Event.Name";
      this.fieldCapacityRequirementEventName1.Name = "fieldCapacityRequirementEventName1";
      this.fieldCapacityRequirementEventName1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
      // 
      // fieldCapacityRequirementEventStartDate1
      // 
      this.fieldCapacityRequirementEventStartDate1.AreaIndex = 3;
      this.fieldCapacityRequirementEventStartDate1.Caption = "Event Start";
      dataSourceColumnBinding5.ColumnName = "CapacityRequirement.Event.StartDate";
      this.fieldCapacityRequirementEventStartDate1.DataBinding = dataSourceColumnBinding5;
      this.fieldCapacityRequirementEventStartDate1.DisplayFolder = "CapacityRequirement\\Event";
      this.fieldCapacityRequirementEventStartDate1.FieldName = "CapacityRequirement.Event.StartDate";
      this.fieldCapacityRequirementEventStartDate1.Name = "fieldCapacityRequirementEventStartDate1";
      this.fieldCapacityRequirementEventStartDate1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
      // 
      // fieldCapacityRequirementEventEndDate1
      // 
      this.fieldCapacityRequirementEventEndDate1.AreaIndex = 4;
      this.fieldCapacityRequirementEventEndDate1.Caption = "Event End";
      dataSourceColumnBinding6.ColumnName = "CapacityRequirement.Event.EndDate";
      this.fieldCapacityRequirementEventEndDate1.DataBinding = dataSourceColumnBinding6;
      this.fieldCapacityRequirementEventEndDate1.DisplayFolder = "CapacityRequirement\\Event";
      this.fieldCapacityRequirementEventEndDate1.FieldName = "CapacityRequirement.Event.EndDate";
      this.fieldCapacityRequirementEventEndDate1.Name = "fieldCapacityRequirementEventEndDate1";
      this.fieldCapacityRequirementEventEndDate1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
      // 
      // fieldCapacityRequirementEventVenueName1
      // 
      this.fieldCapacityRequirementEventVenueName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
      this.fieldCapacityRequirementEventVenueName1.AreaIndex = 0;
      this.fieldCapacityRequirementEventVenueName1.Caption = "Venue";
      dataSourceColumnBinding7.ColumnName = "CapacityRequirement.Event.Venue.Name";
      this.fieldCapacityRequirementEventVenueName1.DataBinding = dataSourceColumnBinding7;
      this.fieldCapacityRequirementEventVenueName1.DisplayFolder = "CapacityRequirement\\Event\\Venue";
      this.fieldCapacityRequirementEventVenueName1.FieldName = "CapacityRequirement.Event.Venue.Name";
      this.fieldCapacityRequirementEventVenueName1.Name = "fieldCapacityRequirementEventVenueName1";
      this.fieldCapacityRequirementEventVenueName1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
      // 
      // fieldCapacityRequirementEventCustomerName1
      // 
      this.fieldCapacityRequirementEventCustomerName1.AreaIndex = 5;
      this.fieldCapacityRequirementEventCustomerName1.Caption = "Customer";
      dataSourceColumnBinding8.ColumnName = "CapacityRequirement.Event.Customer.Name";
      this.fieldCapacityRequirementEventCustomerName1.DataBinding = dataSourceColumnBinding8;
      this.fieldCapacityRequirementEventCustomerName1.DisplayFolder = "CapacityRequirement\\Event\\Customer";
      this.fieldCapacityRequirementEventCustomerName1.FieldName = "CapacityRequirement.Event.Customer.Name";
      this.fieldCapacityRequirementEventCustomerName1.Name = "fieldCapacityRequirementEventCustomerName1";
      this.fieldCapacityRequirementEventCustomerName1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
      // 
      // fieldRoomName2
      // 
      this.fieldRoomName2.AreaIndex = 6;
      this.fieldRoomName2.Caption = "Room";
      dataSourceColumnBinding9.ColumnName = "CapacityRequirement.RoomBooking.Room.Name";
      this.fieldRoomName2.DataBinding = dataSourceColumnBinding9;
      this.fieldRoomName2.DisplayFolder = "Room";
      this.fieldRoomName2.FieldName = "Room.Name";
      this.fieldRoomName2.Name = "fieldRoomName2";
      this.fieldRoomName2.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
      // 
      // fieldStartTime3
      // 
      this.fieldStartTime3.AreaIndex = 0;
      this.fieldStartTime3.Caption = "Room Booking Start Time";
      dataSourceColumnBinding10.ColumnName = "StartTime";
      this.fieldStartTime3.DataBinding = dataSourceColumnBinding10;
      this.fieldStartTime3.FieldName = "StartTime";
      this.fieldStartTime3.Name = "fieldStartTime3";
      this.fieldStartTime3.Options.AllowRunTimeSummaryChange = true;
      this.fieldStartTime3.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
      // 
      // fieldEndTime3
      // 
      this.fieldEndTime3.AreaIndex = 1;
      this.fieldEndTime3.Caption = "Room Booking End Time";
      dataSourceColumnBinding11.ColumnName = "EndTime";
      this.fieldEndTime3.DataBinding = dataSourceColumnBinding11;
      this.fieldEndTime3.FieldName = "EndTime";
      this.fieldEndTime3.Name = "fieldEndTime3";
      this.fieldEndTime3.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
      // 
      // fieldCapacityRequirementCapacity2
      // 
      this.fieldCapacityRequirementCapacity2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
      this.fieldCapacityRequirementCapacity2.AreaIndex = 0;
      this.fieldCapacityRequirementCapacity2.Caption = "Capacity";
      this.fieldCapacityRequirementCapacity2.CellFormat.FormatString = "n2";
      this.fieldCapacityRequirementCapacity2.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      dataSourceColumnBinding12.ColumnName = "CapacityRequirement.Capacity";
      this.fieldCapacityRequirementCapacity2.DataBinding = dataSourceColumnBinding12;
      this.fieldCapacityRequirementCapacity2.FieldName = "CapacityRequirement.Capacity";
      this.fieldCapacityRequirementCapacity2.Name = "fieldCapacityRequirementCapacity2";
      this.fieldCapacityRequirementCapacity2.Options.AllowRunTimeSummaryChange = true;
      this.fieldCapacityRequirementCapacity2.Options.ShowSummaryTypeName = true;
      this.fieldCapacityRequirementCapacity2.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
      // 
      // PivotOverview
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainerControl1);
      this.Controls.Add(this.ribbonControl1);
      this.Name = "PivotOverview";
      this.Size = new System.Drawing.Size(1000, 700);
      ((System.ComponentModel.ISupportInitialize)(this.roomBookingCollection)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.session)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
      this.splitContainerControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private DevExpress.Xpo.Session session;
    private DevExpress.Xpo.XPCollection roomBookingCollection;
    private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    private DevExpress.XtraBars.BarButtonItem printExportItem;
    private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
    private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
    private DevExpress.XtraPivotGrid.PivotGridField fieldCapacityRequirementName1;
    private DevExpress.XtraPivotGrid.PivotGridField fieldCapacityRequirementCapacity1;
    private DevExpress.XtraPivotGrid.PivotGridField fieldCapacityRequirementRoomSetup1;
    private DevExpress.XtraPivotGrid.PivotGridField fieldCapacityRequirementEventName1;
    private DevExpress.XtraPivotGrid.PivotGridField fieldCapacityRequirementEventStartDate1;
    private DevExpress.XtraPivotGrid.PivotGridField fieldCapacityRequirementEventEndDate1;
    private DevExpress.XtraPivotGrid.PivotGridField fieldCapacityRequirementEventVenueName1;
    private DevExpress.XtraPivotGrid.PivotGridField fieldCapacityRequirementEventCustomerName1;
    private DevExpress.XtraPivotGrid.PivotGridField fieldRoomName2;
    private DevExpress.XtraPivotGrid.PivotGridField fieldStartTime3;
    private DevExpress.XtraPivotGrid.PivotGridField fieldEndTime3;
    private DevExpress.XtraPivotGrid.PivotGridField fieldCapacityRequirementCapacity2;
  }
}
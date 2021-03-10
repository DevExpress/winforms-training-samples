namespace sample_5_10.DashboardControls {
  partial class VenueDetails {
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
      DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
      DevExpress.XtraCharts.SeriesTitle seriesTitle1 = new DevExpress.XtraCharts.SeriesTitle();
      this.uow = new DevExpress.Xpo.UnitOfWork(this.components);
      this.roomBookingCollection = new DevExpress.Xpo.XPCollection(this.components);
      this.singleVenueChart = new DevExpress.XtraCharts.ChartControl();
      ((System.ComponentModel.ISupportInitialize)(this.uow)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.roomBookingCollection)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.singleVenueChart)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
      this.SuspendLayout();
      // 
      // roomBookingCollection
      // 
      this.roomBookingCollection.ObjectType = typeof(EventsDB.RoomBooking);
      this.roomBookingCollection.Session = this.uow;
      // 
      // singleVenueChart
      // 
      this.singleVenueChart.Dock = System.Windows.Forms.DockStyle.Fill;
      this.singleVenueChart.Legend.Name = "Default Legend";
      this.singleVenueChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
      this.singleVenueChart.Location = new System.Drawing.Point(0, 0);
      this.singleVenueChart.Name = "singleVenueChart";
      this.singleVenueChart.SeriesDataMember = "CapacityRequirement.Event.Name";
      this.singleVenueChart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
      this.singleVenueChart.SeriesTemplate.ArgumentDataMember = "CapacityRequirement.RoomBooking.Room.Name";
      pieSeriesLabel1.TextPattern = "{A} ({V} / {VP:0.00%})";
      this.singleVenueChart.SeriesTemplate.Label = pieSeriesLabel1;
      this.singleVenueChart.SeriesTemplate.QualitativeSummaryOptions.SummaryFunction = "SUM([CapacityRequirement.Capacity])";
      this.singleVenueChart.SeriesTemplate.SeriesDataMember = "CapacityRequirement.Event.Name";
      pieSeriesView1.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle1});
      this.singleVenueChart.SeriesTemplate.View = pieSeriesView1;
      this.singleVenueChart.Size = new System.Drawing.Size(556, 363);
      this.singleVenueChart.TabIndex = 0;
      // 
      // VenueDetails
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.singleVenueChart);
      this.Name = "VenueDetails";
      this.Size = new System.Drawing.Size(556, 363);
      ((System.ComponentModel.ISupportInitialize)(this.uow)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.roomBookingCollection)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.singleVenueChart)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.Xpo.UnitOfWork uow;
    private DevExpress.Xpo.XPCollection roomBookingCollection;
    private DevExpress.XtraCharts.ChartControl singleVenueChart;
  }
}

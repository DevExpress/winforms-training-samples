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
      this.uow = new DevExpress.Xpo.UnitOfWork(this.components);
      this.roomBookingCollection = new DevExpress.Xpo.XPCollection(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.uow)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.roomBookingCollection)).BeginInit();
      this.SuspendLayout();
      // 
      // roomBookingCollection
      // 
      this.roomBookingCollection.ObjectType = typeof(EventsDB.RoomBooking);
      this.roomBookingCollection.Session = this.uow;
      // 
      // VenueDetails
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Name = "VenueDetails";
      this.Size = new System.Drawing.Size(556, 363);
      ((System.ComponentModel.ISupportInitialize)(this.uow)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.roomBookingCollection)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.Xpo.UnitOfWork uow;
    private DevExpress.Xpo.XPCollection roomBookingCollection;
  }
}

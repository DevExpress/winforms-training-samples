using DevExpress.XtraEditors;
using sample_5_10.DashboardControls;
using System.Windows.Forms;

namespace sample_5_10 {
  public partial class Dashboard : XtraUserControl {
    public Dashboard() {
      InitializeComponent();
    }

    private void widgetView_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e) {
      e.Control = e.Document.ControlName switch
      {
        "EventsCurrentYear" => new EventsCurrentYear(),
        "RoomBookingsCurrentYear" => new RoomBookingsCurrentYear(),
        "VenueDetails" => new VenueDetails(),
        "Venues" => new Venues(),
        _ => new Control()
      };
    }

    VenueDetails venueDetailsControl;

    private void VenuesControl_VenueSelected(object sender, Venues.VenueSelectedEventArgs e) {
      venueDetailsControl?.ConfigureSingleVenueChart(e.Venue);
    }

    private void widgetView_ControlShown(object sender, DevExpress.XtraBars.Docking2010.Views.DeferredControlLoadEventArgs e) {
      if (e.Document.ControlName == "Venues" && e.Control is Venues venuesControl) {
        venuesControl.VenueSelected += VenuesControl_VenueSelected;
      }
      if (e.Document.ControlName == "VenueDetails" && e.Control is VenueDetails venueDetailsControl) {
        this.venueDetailsControl = venueDetailsControl;
      }
    }

    private void widgetView_ControlReleased(object sender, DevExpress.XtraBars.Docking2010.Views.DeferredControlLoadEventArgs e) {
      if (e.Document.ControlName == "Venues" && e.Control is Venues venuesControl) {
        venuesControl.VenueSelected -= VenuesControl_VenueSelected;
      }
      if (e.Document.ControlName == "VenueDetails" && e.Control is VenueDetails venueDetailsControl) {
        venueDetailsControl = null;
      }
    }
  }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using EventsDB;
using DevExpress.XtraCharts;
using DevExpress.Xpo;

namespace sample_5_10.DashboardControls {
  public partial class Venues : DevExpress.XtraEditors.XtraUserControl {
    public Venues() {
      InitializeComponent();
    }

    public class VenueSelectedEventArgs : EventArgs {
      public Venue Venue { get; set; }
    }

    public event EventHandler<VenueSelectedEventArgs> VenueSelected;

    protected virtual void OnVenueSelected(Venue selectedVenue) {
      VenueSelected?.Invoke(this, new VenueSelectedEventArgs { Venue = selectedVenue });
    }

    private void venuesChart_ObjectSelected(object sender, DevExpress.XtraCharts.HotTrackEventArgs e) {
      if (e.AdditionalObject is SeriesPoint seriesPoint) {
        var venue = new XPQuery<Venue>(uow).FirstOrDefault(v => v.Name == seriesPoint.Argument);
        if (venue != null)
          OnVenueSelected(venue);
      }
      else
        e.Cancel = true;
    }

    private void venuesChart_ObjectHotTracked(object sender, HotTrackEventArgs e) {
      if (!e.HitInfo.InSeries)
        e.Cancel = true;
    }
  }
}

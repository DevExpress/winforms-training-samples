using DevExpress.LookAndFeel;
using DevExpress.Utils.Svg.Extensions;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample_1_9 {
  public partial class Form1 : DevExpress.XtraEditors.XtraForm {
    public Form1() {
      InitializeComponent();

      UserLookAndFeel.Default.StyleChanged += Default_StyleChanged;
    }

    private void simpleButton1_Click(object sender, EventArgs e) {
      UserLookAndFeel.Default.SetSkinStyle("Springtime");
    }

    private void Default_StyleChanged(object sender, EventArgs e) {
      skinPaletteRibbonGalleryBarItem1.Visibility = UserLookAndFeel.Default.IsSvgSkin() ?
        BarItemVisibility.Always : BarItemVisibility.Never;
    }
  }
}

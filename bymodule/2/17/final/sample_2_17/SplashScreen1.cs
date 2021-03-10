using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace sample_2_17 {
  public partial class SplashScreen1 : SplashScreen {
    public SplashScreen1() {
      InitializeComponent();
      this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
    }

    #region Overrides

    public override void ProcessCommand(Enum cmd, object arg) {
      base.ProcessCommand(cmd, arg);
    }

    #endregion

    public enum SplashScreenCommand {
    }
  }
}
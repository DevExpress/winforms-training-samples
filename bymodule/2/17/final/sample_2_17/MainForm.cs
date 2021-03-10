using DevExpress.Utils.Svg;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample_2_17 {
  public partial class MainForm : DevExpress.XtraEditors.XtraForm {
    public MainForm() {
      InitializeComponent();

      syncContext = SynchronizationContext.Current;
    }

    private void showWaitFormButton_Click(object sender, EventArgs e) {
      splashScreenManager1.ShowWaitForm();
      splashScreenManager1.SetWaitFormCaption("Wait for it");
    }

    private void hideWaitFormButton_Click(object sender, EventArgs e) {
      splashScreenManager1.CloseWaitForm();
    }

    CancellationTokenSource cancellationTokenSource;
    SynchronizationContext syncContext;

    Task BackgroundTask() {
      cancellationTokenSource = new CancellationTokenSource();
      var cancellationToken = cancellationTokenSource.Token;

      int state = 0;

      return Task.Run(() => {
        while (!cancellationToken.IsCancellationRequested) {
          Thread.Sleep(300);
          state++;
          syncContext.Post(new SendOrPostCallback(o => {
            overlayTextPainter.Text = o.ToString();
          }), state);
        }
      }, cancellationToken);
    }

    IOverlaySplashScreenHandle overlayHandle;
    OverlayTextPainter overlayTextPainter;

    private async void showOverlayButton_Click(object sender, EventArgs e) {
      if (overlayHandle == null) {
        overlayTextPainter = new OverlayTextPainter("Starting ...");
        overlayHandle = SplashScreenManager.ShowOverlayForm(grid, customPainter: overlayTextPainter);
        await BackgroundTask();
      }
    }

    private void hideOverlayButton_Click(object sender, EventArgs e) {
      if (overlayHandle != null) {
        cancellationTokenSource.Cancel();
        cancellationTokenSource.Dispose();
        cancellationTokenSource = null;
        overlayHandle.Close();
        overlayHandle.Dispose();
        overlayHandle = null;
      }
    }

    private void showSkinSplashScreenButton_Click(object sender, EventArgs e) {
      SplashScreenManager.ShowSkinSplashScreen(
        title: "Splash Screen Demo",
        subtitle: "DevExpress WinForms Online Training",
        loading: "Just waiting for you...",
        footer: "All things come to those who wait",
        startPos: SplashFormStartPosition.CenterScreen);
    }

    private void hideSplashScreenButton_Click(object sender, EventArgs e) {
      SplashScreenManager.CloseForm();
    }

    private void showCustomSplashScreenButton_Click(object sender, EventArgs e) {
      SplashScreenManager.ShowForm(this, typeof(SplashScreen1), true, true, SplashFormStartPosition.CenterScreen);
    }

    private void showFluentSplashScreenButton_Click(object sender, EventArgs e) {
      SplashScreenManager.ShowFluentSplashScreen(
        title: "Splash Screen Demo",
        subtitle: "DevExpress WinForms Online Training",
        loadingIndicatorType: FluentLoadingIndicatorType.Ring,
        leftFooter: "All things come to those who wait",
        rightFooter: "... hopefully",
        startPos: SplashFormStartPosition.CenterScreen);
    }

    private void showSplashImageButton_Click(object sender, EventArgs e) {
      var image = SvgImage.FromResources("sample_2_17.splash-image.svg", this.GetType().Assembly);
      SplashScreenManager.ShowImage(image, new Size(600, 600), true, true, SplashFormStartPosition.CenterScreen, Point.Empty);
    }

    private void hideSplashScreenWithDelayButton_Click(object sender, EventArgs e) {
      SplashScreenManager.CloseForm(false, 3000, this);
    }

    private void separateFormButton_Click(object sender, EventArgs e) {
      new SeparateForm().Show();
    }
  }
}
using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
namespace CustomBarAnimationExample {
    public partial class MainForm : DevExpress.XtraEditors.XtraForm {
        Series series { get { return chartControl.Series[0]; } }
        SideBySideBarSeriesView view { get { return series.View as SideBySideBarSeriesView; } }

        public MainForm() {
            InitializeComponent();
        }
        
        #region #AnimationConfiguration
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            chartControl.AnimationStartMode = ChartAnimationMode.OnLoad;
            view.Animation = new ZoomInFromCenterBarAnimation {
                BeginTime = new TimeSpan(0, 0, 0),
                Duration = new TimeSpan(0, 0, 2),
                PointDelay = new TimeSpan(0, 0, 0, 0, 250),
                PointOrder = PointAnimationOrder.Random,
                EasingFunction = new SineEasingFunction {
                    EasingMode = EasingMode.Out
                }
            };
        }

        private void OnAnimateClick(object sender, EventArgs e) {
            chartControl.Animate();
        }
        #endregion #AnimationConfiguration
    }
}

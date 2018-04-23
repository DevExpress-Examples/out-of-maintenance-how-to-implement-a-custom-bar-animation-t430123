namespace CustomBarAnimationExample {
    partial class MainForm {
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("Indiana", new object[] {
            ((object)(528.904D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint("Illinois", new object[] {
            ((object)(227.271D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint("Michigan", new object[] {
            ((object)(372.576D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint4 = new DevExpress.XtraCharts.SeriesPoint("Ohio", new object[] {
            ((object)(418.258D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint5 = new DevExpress.XtraCharts.SeriesPoint("Wisconsin", new object[] {
            ((object)(211.727D))});
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            this.btnAnimate = new DevExpress.XtraEditors.SimpleButton();
            this.pnlBtnAnimate = new DevExpress.XtraEditors.PanelControl();
            this.pnlChartControl = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBtnAnimate)).BeginInit();
            this.pnlBtnAnimate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlChartControl)).BeginInit();
            this.pnlChartControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // chartControl
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.Rotated = true;
            this.chartControl.Diagram = xyDiagram1;
            this.chartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.chartControl.Legend.Name = "Default Legend";
            this.chartControl.Location = new System.Drawing.Point(4, 4);
            this.chartControl.Name = "chartControl";
            series1.Name = "2004";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2,
            seriesPoint3,
            seriesPoint4,
            seriesPoint5});
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl.Size = new System.Drawing.Size(562, 269);
            this.chartControl.TabIndex = 0;
            this.chartControl.TabStop = false;
            chartTitle1.Text = "Great Lakes Gross State Product";
            this.chartControl.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // btnAnimate
            // 
            this.btnAnimate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAnimate.Location = new System.Drawing.Point(466, 2);
            this.btnAnimate.Margin = new System.Windows.Forms.Padding(0);
            this.btnAnimate.Name = "btnAnimate";
            this.btnAnimate.Size = new System.Drawing.Size(100, 23);
            this.btnAnimate.TabIndex = 0;
            this.btnAnimate.Text = "Animate";
            this.btnAnimate.Click += new System.EventHandler(this.OnAnimateClick);
            // 
            // pnlBtnAnimate
            // 
            this.pnlBtnAnimate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlBtnAnimate.Controls.Add(this.btnAnimate);
            this.pnlBtnAnimate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBtnAnimate.Location = new System.Drawing.Point(0, 275);
            this.pnlBtnAnimate.Name = "pnlBtnAnimate";
            this.pnlBtnAnimate.Padding = new System.Windows.Forms.Padding(4, 2, 4, 4);
            this.pnlBtnAnimate.Size = new System.Drawing.Size(570, 29);
            this.pnlBtnAnimate.TabIndex = 1;
            // 
            // pnlChartControl
            // 
            this.pnlChartControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlChartControl.Controls.Add(this.chartControl);
            this.pnlChartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChartControl.Location = new System.Drawing.Point(0, 0);
            this.pnlChartControl.Name = "pnlChartControl";
            this.pnlChartControl.Padding = new System.Windows.Forms.Padding(4, 4, 4, 2);
            this.pnlChartControl.Size = new System.Drawing.Size(570, 275);
            this.pnlChartControl.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 304);
            this.Controls.Add(this.pnlChartControl);
            this.Controls.Add(this.pnlBtnAnimate);
            this.Name = "MainForm";
            this.Text = "Custom Bar Animation Example";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBtnAnimate)).EndInit();
            this.pnlBtnAnimate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlChartControl)).EndInit();
            this.pnlChartControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraCharts.ChartControl chartControl;
        private DevExpress.XtraEditors.SimpleButton btnAnimate;
        private DevExpress.XtraEditors.PanelControl pnlBtnAnimate;
        private DevExpress.XtraEditors.PanelControl pnlChartControl;
    }
}


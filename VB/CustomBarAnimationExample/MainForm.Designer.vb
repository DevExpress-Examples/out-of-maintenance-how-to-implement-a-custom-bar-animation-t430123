Namespace CustomBarAnimationExample
    Partial Public Class MainForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("Indiana", New Object() { (DirectCast(528.904R, Object))})
            Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("Illinois", New Object() { (DirectCast(227.271R, Object))})
            Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("Michigan", New Object() { (DirectCast(372.576R, Object))})
            Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("Ohio", New Object() { (DirectCast(418.258R, Object))})
            Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("Wisconsin", New Object() { (DirectCast(211.727R, Object))})
            Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
            Me.defaultLookAndFeel = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.chartControl = New DevExpress.XtraCharts.ChartControl()
            Me.btnAnimate = New DevExpress.XtraEditors.SimpleButton()
            Me.pnlBtnAnimate = New DevExpress.XtraEditors.PanelControl()
            Me.pnlChartControl = New DevExpress.XtraEditors.PanelControl()
            DirectCast(Me.chartControl, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.pnlBtnAnimate, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlBtnAnimate.SuspendLayout()
            DirectCast(Me.pnlChartControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlChartControl.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' defaultLookAndFeel
            ' 
            Me.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' chartControl
            ' 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.Rotated = True
            Me.chartControl.Diagram = xyDiagram1
            Me.chartControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartControl.Legend.Name = "Default Legend"
            Me.chartControl.Location = New System.Drawing.Point(4, 4)
            Me.chartControl.Name = "chartControl"
            series1.Name = "2004"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5})
            Me.chartControl.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            Me.chartControl.Size = New System.Drawing.Size(562, 269)
            Me.chartControl.TabIndex = 0
            Me.chartControl.TabStop = False
            chartTitle1.Text = "Great Lakes Gross State Product"
            Me.chartControl.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
            ' 
            ' btnAnimate
            ' 
            Me.btnAnimate.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnAnimate.Location = New System.Drawing.Point(466, 2)
            Me.btnAnimate.Margin = New System.Windows.Forms.Padding(0)
            Me.btnAnimate.Name = "btnAnimate"
            Me.btnAnimate.Size = New System.Drawing.Size(100, 23)
            Me.btnAnimate.TabIndex = 0
            Me.btnAnimate.Text = "Animate"
            ' 
            ' pnlBtnAnimate
            ' 
            Me.pnlBtnAnimate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlBtnAnimate.Controls.Add(Me.btnAnimate)
            Me.pnlBtnAnimate.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlBtnAnimate.Location = New System.Drawing.Point(0, 275)
            Me.pnlBtnAnimate.Name = "pnlBtnAnimate"
            Me.pnlBtnAnimate.Padding = New System.Windows.Forms.Padding(4, 2, 4, 4)
            Me.pnlBtnAnimate.Size = New System.Drawing.Size(570, 29)
            Me.pnlBtnAnimate.TabIndex = 1
            ' 
            ' pnlChartControl
            ' 
            Me.pnlChartControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlChartControl.Controls.Add(Me.chartControl)
            Me.pnlChartControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlChartControl.Location = New System.Drawing.Point(0, 0)
            Me.pnlChartControl.Name = "pnlChartControl"
            Me.pnlChartControl.Padding = New System.Windows.Forms.Padding(4, 4, 4, 2)
            Me.pnlChartControl.Size = New System.Drawing.Size(570, 275)
            Me.pnlChartControl.TabIndex = 2
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(570, 304)
            Me.Controls.Add(Me.pnlChartControl)
            Me.Controls.Add(Me.pnlBtnAnimate)
            Me.Name = "MainForm"
            Me.Text = "Custom Bar Animation Example"
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.pnlBtnAnimate, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlBtnAnimate.ResumeLayout(False)
            DirectCast(Me.pnlChartControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlChartControl.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Private defaultLookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private chartControl As DevExpress.XtraCharts.ChartControl
        Private WithEvents btnAnimate As DevExpress.XtraEditors.SimpleButton
        Private pnlBtnAnimate As DevExpress.XtraEditors.PanelControl
        Private pnlChartControl As DevExpress.XtraEditors.PanelControl
    End Class
End Namespace


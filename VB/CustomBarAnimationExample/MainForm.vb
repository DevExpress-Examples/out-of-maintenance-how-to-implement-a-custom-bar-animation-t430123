Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Namespace CustomBarAnimationExample
    Partial Public Class MainForm
        Inherits DevExpress.XtraEditors.XtraForm

        Private ReadOnly Property series() As Series
            Get
                Return chartControl.Series(0)
            End Get
        End Property
        Private ReadOnly Property view() As SideBySideBarSeriesView
            Get
                Return TryCast(series.View, SideBySideBarSeriesView)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "#AnimationConfiguration"
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)

            chartControl.AnimationStartMode = ChartAnimationMode.OnLoad
            view.Animation = New ZoomInFromCenterBarAnimation With { _
                .BeginTime = New TimeSpan(0, 0, 0), .Duration = New TimeSpan(0, 0, 2), .PointDelay = New TimeSpan(0, 0, 0, 0, 250), .PointOrder = PointAnimationOrder.Random, .EasingFunction = New SineEasingFunction With {.EasingMode = EasingMode.Out} _
            }
        End Sub

        Private Sub OnAnimateClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnAnimate.Click
            chartControl.Animate()
        End Sub
        #End Region ' #AnimationConfiguration
    End Class
End Namespace

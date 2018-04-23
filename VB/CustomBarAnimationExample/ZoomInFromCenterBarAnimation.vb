#Region "#CustomAnimation"
Imports DevExpress.XtraCharts
Imports System.Drawing

Namespace CustomBarAnimationExample
    Friend Class ZoomInFromCenterBarAnimation
        Inherits BarAnimationBase

        Public Overrides Sub ApplyState(ByVal modifier As SceneModifier, ByVal diagramBounds As RectangleF, ByVal barParameters As BarSeriesPointLayoutParameters, ByVal progress As Single)
            Dim startPositionX As Single = diagramBounds.Left + diagramBounds.Width / 2
            Dim startPositionY As Single = diagramBounds.Top + diagramBounds.Height / 2

            Dim barBounds As RectangleF = barParameters.Bounds
            Dim endPositionX As Single = barBounds.Left + barBounds.Width / 2
            Dim endPositionY As Single = barBounds.Top + barBounds.Height / 2

            ' Moves bar from the diagram center to its position on the diagram.
            modifier.Translate((startPositionX - endPositionX) * (1 - progress), (startPositionY - endPositionY) * (1 - progress))

            ' Scales bar.
            ' Note that methods requiered for correct transform are called in inverse order.
            ' This is a feature of affine transformations.
            modifier.Translate(endPositionX, endPositionY)
            modifier.Scale(progress, progress)
            modifier.Translate(-endPositionX, -endPositionY)
        End Sub

        Protected Overrides Function CreateObjectForClone() As ChartElement
            Return New ZoomInFromCenterBarAnimation()
        End Function
    End Class
End Namespace
#End Region ' #CustomAnimation
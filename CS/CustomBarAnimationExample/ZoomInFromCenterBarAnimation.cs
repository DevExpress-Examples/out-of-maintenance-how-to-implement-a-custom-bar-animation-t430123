#region #CustomAnimation
using DevExpress.XtraCharts;
using System.Drawing;

namespace CustomBarAnimationExample {
    class ZoomInFromCenterBarAnimation : BarAnimationBase {
        public override void ApplyState(
                SceneModifier modifier, 
                RectangleF diagramBounds, 
                BarSeriesPointLayoutParameters barParameters,
                float progress) {
            float startPositionX = diagramBounds.Left + diagramBounds.Width / 2;
            float startPositionY = diagramBounds.Top + diagramBounds.Height / 2;

            RectangleF barBounds = barParameters.Bounds;
            float endPositionX = barBounds.Left + barBounds.Width / 2;
            float endPositionY = barBounds.Top + barBounds.Height / 2;

            // Moves bar from the diagram center to its position on the diagram.
            modifier.Translate(
                    (startPositionX - endPositionX) * (1 - progress), 
                    (startPositionY - endPositionY) * (1 - progress)
            );

            // Scales bar.
            // Note that methods requiered for correct transform are called in inverse order.
            // This is a feature of affine transformations.
            modifier.Translate(endPositionX, endPositionY);
            modifier.Scale(progress, progress);
            modifier.Translate(-endPositionX, -endPositionY);
        }

        protected override ChartElement CreateObjectForClone() {
            return new ZoomInFromCenterBarAnimation();
        }
    }
}
#endregion #CustomAnimation
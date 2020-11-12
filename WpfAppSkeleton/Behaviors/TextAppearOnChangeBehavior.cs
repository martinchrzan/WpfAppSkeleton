using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;
using System.Windows.Media.Animation;

namespace WpfAppSkeleton.Behaviors
{
    public class TextAppearOnChangeBehavior: Behavior<TextBlock>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.TargetUpdated += AssociatedObject_TargetUpdated;
        }

        private void AssociatedObject_TargetUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {
            var opacityAppear = new DoubleAnimation(0, 1.0, new Duration(TimeSpan.FromMilliseconds(400)));
            opacityAppear.EasingFunction = new QuadraticEase() { EasingMode = EasingMode.EaseOut };

            AssociatedObject.BeginAnimation(TextBlock.OpacityProperty, opacityAppear);
        }
    }
}

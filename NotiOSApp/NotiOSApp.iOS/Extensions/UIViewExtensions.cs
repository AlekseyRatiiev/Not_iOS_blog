using CoreAnimation;
using CoreGraphics;
using Foundation;
using MvvmCross.Plugin.Color.Platforms.Ios;
using NotiOSApp.Core.Theme.Helpers;
using System;
using UIKit;

namespace NotiOSApp.iOS.Extensions
{
    public static class UIViewExtensions
    {
        public static void SetGradientBackground(this UIView view, GradientOptions gradientOptions)
        {
            var gradientLayer = new CAGradientLayer
            {
                Frame = view.Bounds,
                Colors = new CGColor[] { gradientOptions.Colors[0].ToNativeColor().CGColor
                    , gradientOptions.Colors[1].ToNativeColor().CGColor },
                Locations = new NSNumber[] { gradientOptions.Positions[0], gradientOptions.Positions[1] },
                StartPoint = new CGPoint(gradientOptions.StartPoint.X, gradientOptions.StartPoint.Y),
                EndPoint = new CGPoint(gradientOptions.EndPoint.X, gradientOptions.EndPoint.Y),
                CornerRadius = view.Layer.CornerRadius,
            };

            foreach (var subView in view.Subviews)
            {
                if (subView.Tag == 100)
                    subView.RemoveFromSuperview();
            }

            var gradientView = new UIView { Frame = view.Bounds, Tag = 100 };
            gradientView.Layer.InsertSublayer(gradientLayer, 0);
            var i = view.Subviews.Length;
            view.InsertSubview(gradientView, 0);
        }
    }
}

using MvvmCross.UI;
using System;
namespace NotiOSApp.Core.Theme.Helpers
{
    public class GradientOptions
    {
        public GradientOptions(GradientCornerPoint startPoint, GradientCornerPoint endPoint, MvxColor[] colors, float[] positions)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            Colors = colors;
            Positions = positions;
        }

        public GradientCornerPoint StartPoint { get; }
        public GradientCornerPoint EndPoint { get; }
        public MvxColor[] Colors { get; }
        public float[] Positions { get; }
    }
}

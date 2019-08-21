using MvvmCross.UI;
using NotiOSApp.Core.Constants;
using NotiOSApp.Core.Theme.Helpers;
using NotiOSApp.Core.Theme.Interfaces;
using System;
namespace NotiOSApp.Core.Theme
{
    public class LightTheme : ITheme
    {
        private GradientOptions _gradientOptions;
        private static Lazy<LightTheme> instance = new Lazy<LightTheme>(() => new LightTheme());
        public static LightTheme Instance => instance.Value;

        public MvxColor BackgroundColor => Colors.LightBlue;
        public MvxColor StartGradientColor => Colors.SilverGray;
        public MvxColor EndGradientColor => Colors.LightGray;
        public GradientOptions GradientOptions => _gradientOptions
            ?? (_gradientOptions = new GradientOptions(
                new GradientCornerPoint(0, 0),
                new GradientCornerPoint(1, 1),
                new MvxColor[] { EndGradientColor, StartGradientColor },
                new float[] { 0, 1 }));

        private LightTheme()
        {
        }
    }
}

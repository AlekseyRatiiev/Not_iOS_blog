using MvvmCross.UI;
using NotiOSApp.Core.Constants;
using NotiOSApp.Core.Theme.Helpers;
using NotiOSApp.Core.Theme.Interfaces;
using System;
namespace NotiOSApp.Core.Theme
{
    public class DarkTheme : ITheme
    {
        private GradientOptions _gradientOptions;
        private static Lazy<DarkTheme> instance = new Lazy<DarkTheme>(() => new DarkTheme());
        public static DarkTheme Instance => instance.Value;

        public MvxColor BackgroundColor => Colors.LightBlue;
        public MvxColor StartGradientColor => Colors.LightBlue;
        public MvxColor EndGradientColor => Colors.DeepBlue;
        public GradientOptions GradientOptions => _gradientOptions
            ?? (_gradientOptions = new GradientOptions(
                new GradientCornerPoint(0, 0),
                new GradientCornerPoint(1, 1),
                new MvxColor[] { StartGradientColor, EndGradientColor },
                new float[] { 0, 1 }));

        private DarkTheme()
        {
        }
    }
}

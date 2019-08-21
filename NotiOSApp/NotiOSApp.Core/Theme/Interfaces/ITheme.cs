using MvvmCross.UI;
using NotiOSApp.Core.Theme.Helpers;
using System;
namespace NotiOSApp.Core.Theme.Interfaces
{
    public interface ITheme
    {
        MvxColor StartGradientColor { get; }
        MvxColor EndGradientColor { get; }
        GradientOptions GradientOptions { get; }
        MvxColor BackgroundColor { get; }
    }
}

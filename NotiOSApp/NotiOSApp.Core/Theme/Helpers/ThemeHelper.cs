using NotiOSApp.Core.Theme.Interfaces;
using System;
namespace NotiOSApp.Core.Theme.Helpers
{
    public class ThemeHelper
    {
        public static ITheme GetThemeInstance(string nameOfTheme)
        {
            switch (nameOfTheme)
            {
                case "Dark":
                    return DarkTheme.Instance;
                case "Light":
                    return LightTheme.Instance;
                default:
                    return DarkTheme.Instance;
            }
        }
    }
}

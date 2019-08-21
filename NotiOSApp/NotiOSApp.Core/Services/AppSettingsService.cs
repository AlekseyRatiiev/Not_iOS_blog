using NotiOSApp.Core.Services.Interfaces;
using System;
using Xamarin.Essentials;

namespace NotiOSApp.Core.Services
{
    public class AppSettingsService : IAppSettingsService
    {
        public string ThemeName
        {
            get => Preferences.Get(nameof(ThemeName), Resources.AppStrings.DarkThemeName);
            set => Preferences.Set(nameof(ThemeName), value);
        }
    }
}

using NotiOSApp.Core.Theme;
using System;
namespace NotiOSApp.Core.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        private bool _isDarkTheme;

        public SettingsViewModel()
        {
            IsDarkTheme = AppSettingsService.ThemeName == Resources.AppStrings.DarkThemeName;
        }

        #region Theme

        public bool IsDarkTheme
        {
            get => _isDarkTheme;
            set
            {
                if (value)
                {
                    ThemeService.CurrentTheme = DarkTheme.Instance;
                    AppSettingsService.ThemeName = nameof(DarkTheme);
                }
                else
                { 
                    ThemeService.CurrentTheme = LightTheme.Instance;
                    AppSettingsService.ThemeName = nameof(LightTheme);
                }

                SetProperty(ref _isDarkTheme, value);
            }
        }

        #endregion
    }
}

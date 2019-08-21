using MvvmCross.ViewModels;
using NotiOSApp.Core.Services.Interfaces;
using NotiOSApp.Core.Theme.Interfaces;
using System;
namespace NotiOSApp.Core.Services
{
    public class ThemeService : MvxNotifyPropertyChanged, IThemeService
    {
        private ITheme _currentTheme;

        public ThemeService()
        {
        }

        public ITheme CurrentTheme
        {
            get => _currentTheme;
            set => SetProperty(ref _currentTheme, value);
        }
    }
}

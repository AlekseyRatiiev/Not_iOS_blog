using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using NotiOSApp.Core.Services.Interfaces;
using NotiOSApp.Core.Theme.Helpers;
using System;
using System.Threading.Tasks;

namespace NotiOSApp.Core.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        #region Protected fields

        protected readonly IMvxNavigationService MvxNavigationService;
        protected readonly IAppSettingsService AppSettingsService;

        #endregion

        public BaseViewModel()
        {
            MvxNavigationService = Mvx.IoCProvider.Resolve<IMvxNavigationService>();
            ThemeService = Mvx.IoCProvider.Resolve<IThemeService>();
            AppSettingsService = Mvx.IoCProvider.Resolve<IAppSettingsService>();

            ThemeService.CurrentTheme = ThemeHelper.GetThemeInstance(AppSettingsService.ThemeName);
        }

        #region Properties

        public IThemeService ThemeService { get; }

        #endregion

        #region Commands

        private IMvxAsyncCommand _settingsButtonClickedCommand;
        public IMvxAsyncCommand SettingsButtonClickedCommand => _settingsButtonClickedCommand
            ?? (_settingsButtonClickedCommand = new MvxAsyncCommand(DoSettingsButtonClick));

        #endregion

        #region Private methods

        private Task DoSettingsButtonClick()
        {
            return MvxNavigationService.Navigate<SettingsViewModel>();
        }

        #endregion
    }
}

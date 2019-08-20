using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Threading.Tasks;

namespace NotiOSApp.Core.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        #region Protected fields

        protected readonly IMvxNavigationService MvxNavigationService;

        #endregion

        public BaseViewModel()
        {
            MvxNavigationService = Mvx.IoCProvider.Resolve<IMvxNavigationService>();
        }

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

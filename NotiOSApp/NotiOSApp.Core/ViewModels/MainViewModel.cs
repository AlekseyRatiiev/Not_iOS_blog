using NotiOSApp.Core.Resources;
using System;
namespace NotiOSApp.Core.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
        }

        #region Properties

        public string Title => AppStrings.MainViewTitle;

        #endregion

    }
}

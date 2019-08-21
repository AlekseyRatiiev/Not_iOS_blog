using MvvmCross.Platforms.Ios.Views;
using MvvmCross.ViewModels;
using System;
namespace NotiOSApp.iOS.Views.Base
{
    public class BaseTableViewController<TViewModel> : MvxTableViewController<TViewModel> where TViewModel
        : MvxViewModel
    {
        public BaseTableViewController(IntPtr handle) : base(handle)
        {
        }
    }
}

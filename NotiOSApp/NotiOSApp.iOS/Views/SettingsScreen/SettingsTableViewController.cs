using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using NotiOSApp.Core.ViewModels;
using NotiOSApp.iOS.Views.Base;
using System;
using UIKit;

namespace NotiOSApp.iOS
{
    [MvxFromStoryboard("SettingsView")]
    public partial class SettingsTableViewController : BaseTableViewController<SettingsViewModel>
    {
        public SettingsTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<SettingsTableViewController, SettingsViewModel>();

            set.Bind(ThemeSwitch)
                .For(v => v.On)
                .To(vm => vm.IsDarkTheme).TwoWay();
            set.Apply();
        }
    }
}
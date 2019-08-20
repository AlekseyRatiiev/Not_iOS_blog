using NotiOSApp.Core.ViewModels;
using System;

using UIKit;

namespace NotiOSApp.iOS.Views
{
    public partial class SettingsView : BaseView<SettingsViewModel>
    {
        public SettingsView() : base("SettingsView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            SettingsButtonVisibility = false;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}


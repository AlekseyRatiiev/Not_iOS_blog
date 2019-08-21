using MvvmCross.Binding.BindingContext;
using NotiOSApp.Core.ViewModels;
using NotiOSApp.iOS.Extensions;
using NotiOSApp.iOS.Views.Base;
using System;

using UIKit;

namespace NotiOSApp.iOS.Views
{
    public partial class MainView : BaseView<MainViewModel>
    {
        public MainView() : base("MainView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            SettingsButtonVisibility = true;

            var set = this.CreateBindingSet<MainView, MainViewModel>();
            set.Bind(this)
                .For("Title")
                .To(vm => vm.Title).OneWay();
            set.Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLayoutSubviews()
        {
            View.SetGradientBackground(CurrentTheme.GradientOptions);
        }

        public override void SetViewStyles()
        {
            base.SetViewStyles();
            View.SetGradientBackground(CurrentTheme.GradientOptions);
        }
    }
}


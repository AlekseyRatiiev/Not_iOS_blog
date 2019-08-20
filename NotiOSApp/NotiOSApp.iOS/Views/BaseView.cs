using Foundation;
using MvvmCross.Platforms.Ios.Views;
using NotiOSApp.Core.ViewModels;
using System;

using UIKit;

namespace NotiOSApp.iOS.Views
{
    public partial class BaseView<TViewModel>
        : MvxViewController where TViewModel :BaseViewModel
    {

        #region Constructors

        public BaseView(string nibName, NSBundle bundle)
            : base(nibName, bundle)
        {
        }

        #endregion

        #region Properties

        public new TViewModel ViewModel
        {
            get => (TViewModel)base.ViewModel;
            set { base.ViewModel = value; }
        }

        #endregion

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            SetViewStyles();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        #region Styling Methods

        public virtual void SetViewStyles()
        {
            NavigationController.NavigationBar.BarStyle = UIBarStyle.Black;
            this.View.BackgroundColor = UIColor.White;
            NavigationController.NavigationBar.BarTintColor = UIColor.Black;
            UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes
            {
                TextColor = UIColor.White
            });
        }
        #endregion
    }
}


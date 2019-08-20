using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using NotiOSApp.Core.ViewModels;
using System;

using UIKit;

namespace NotiOSApp.iOS.Views
{
    public partial class BaseView<TViewModel>
        : MvxViewController where TViewModel : BaseViewModel
    {
        #region Private fields

        private bool _settingsButtonVisibility;
        private UIBarButtonItem settingsButton;

        #endregion

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

        public bool SettingsButtonVisibility
        {
            get => _settingsButtonVisibility;
            set
            {
                if (value)
                    NavigationItem.SetRightBarButtonItem(settingsButton, false);
                else
                    NavigationItem.SetRightBarButtonItem(null, true);

                _settingsButtonVisibility = value;
            }
        }

        #endregion

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            settingsButton = new UIBarButtonItem();

            var set = this.CreateBindingSet<BaseView<TViewModel>, BaseViewModel>();
            set.Bind(settingsButton)
                .To(vm => vm.SettingsButtonClickedCommand).OneWay();
            set.Apply();

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

            SetSettingsButtonStyles();
        }

        protected virtual void SetSettingsButtonStyles()
        {
            settingsButton.Image = UIImage.FromBundle("SettingsButton");
            settingsButton.TintColor = UIColor.White;
            SettingsButtonVisibility = true;
        }

        #endregion
    }
}


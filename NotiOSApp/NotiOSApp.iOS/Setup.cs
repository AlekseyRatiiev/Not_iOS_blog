using MvvmCross;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.IoC;
using MvvmCross.Platforms.Ios.Core;
using MvvmCross.Platforms.Ios.Presenters;
using NotiOSApp.Core;
using System;
namespace NotiOSApp.iOS
{
    public class Setup : MvxIosSetup<App>
    {

        protected override void InitializeLastChance()
        {
            base.InitializeLastChance();
        }

        protected override IMvxIocOptions CreateIocOptions()
        {
            return new MvxIocOptions
            {
                PropertyInjectorOptions = MvxPropertyInjectorOptions.MvxInject
            };
        }
    }
}

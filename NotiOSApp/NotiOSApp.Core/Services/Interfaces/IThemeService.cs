using NotiOSApp.Core.Theme.Interfaces;
using System;
namespace NotiOSApp.Core.Services.Interfaces
{
    public interface IThemeService
    {
        ITheme CurrentTheme { get; set; }
    }
}

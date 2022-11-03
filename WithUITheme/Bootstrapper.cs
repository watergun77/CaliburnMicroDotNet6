using Caliburn.Micro;
using System.Windows;
using WithUITheme.ViewModels;

namespace WithUITheme
{
    internal class Bootstrapper:BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewForAsync<ShellViewModel>();
        }
    }
}

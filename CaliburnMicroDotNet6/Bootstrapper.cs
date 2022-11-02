using Caliburn.Micro;
using CaliburnMicroDotNet6.ViewModels;
using System.Windows;

namespace CaliburnMicroDotNet6
{
    internal class Bootstrapper : BootstrapperBase
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

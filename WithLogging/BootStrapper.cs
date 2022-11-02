using Caliburn.Micro;
using System.Windows;
using WithLogging.ViewModels;

namespace WithLogging;

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

using Caliburn.Micro;
using System.Windows;
using WithLogging.Models;
using WithLogging.ViewModels;

namespace WithLogging;

internal class Bootstrapper : BootstrapperBase
{
	public Bootstrapper()
	{
        Initialize();
        LogManager.GetLog = type => new DebugLogger(type);
    }
    protected override void OnStartup(object sender, StartupEventArgs e)
    {        
        DisplayRootViewForAsync<ShellViewModel>();        
    }
}

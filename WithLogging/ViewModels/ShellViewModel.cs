using Caliburn.Micro;

namespace WithLogging.ViewModels;

internal class ShellViewModel : Conductor<object>
{
	private readonly ILog log = LogManager.GetLog(typeof(ShellViewModel));
	public ShellViewModel()
	{
        log.Info("Start loading ShellViewModel");
    }

	protected override void OnViewLoaded(object view)
	{
        log.Info("End of loading ShellViewModel");
        base.OnViewLoaded(view);
	}
}

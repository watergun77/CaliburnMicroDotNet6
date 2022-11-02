using Caliburn.Micro;
using Microsoft.Extensions.Configuration;

namespace WithAppSettings.ViewModels
{
    internal class ShellViewModel : Conductor<object>
    {
        private IConfiguration config;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ShellViewModel(IConfiguration config)
        {
            this.config = config;

            FirstName = this.config.GetValue<string>("FirstName");
            LastName = this.config.GetValue<string>("LastName");
        }

    }
}

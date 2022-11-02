using Caliburn.Micro;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using WithAppSettings.ViewModels;

namespace WithAppSettings
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

        private IConfiguration AddConfiguration()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            //#if DEBUG
            //            builder.AddJsonFile("appsettings.Debug.json", optional: true, reloadOnChange: true);
            //#else
            //            builder.AddJsonFile("appsettings.Release.json", optional: true, reloadOnChange: true);
            //#endif

            return builder.Build();
        }

        private SimpleContainer container = new SimpleContainer();
        protected override void Configure()
        {
            container.Singleton<IWindowManager, WindowManager>();

            GetType().Assembly.GetTypes()
                .Where(type => type.IsClass)
                .Where(type => type.Name.EndsWith("ViewModel"))
                .ToList()
                .ForEach(viewModelType => container.RegisterPerRequest(
                    viewModelType, viewModelType.ToString(), viewModelType));

            container.RegisterInstance(typeof(IConfiguration), "IConfiguration", AddConfiguration());
        }
        protected override object GetInstance(Type service, string key)
        {
            return container.GetInstance(service, key);
        }
        protected override IEnumerable<object> GetAllInstances(Type serviceType)
        {
            return container.GetAllInstances(serviceType);
        }
        protected override void BuildUp(object instance)
        {
            container.BuildUp(instance);
        }
    }
}

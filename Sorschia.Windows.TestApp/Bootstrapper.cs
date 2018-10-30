using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace Sorschia.Windows.TestApp
{
    internal sealed class Bootstrapper : BootstrapperBase
    {
        protected override void ConfigureServices(IServiceCollection services)
        {
            base.ConfigureServices(services);
            services
                .AddJsonConfigurationProvider(ConfigurationManager.AppSettings["ConfigurationFile"]);
        }
    }
}

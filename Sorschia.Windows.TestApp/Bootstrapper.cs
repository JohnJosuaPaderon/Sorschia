using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace Sorschia.Windows.TestApp
{
    internal sealed class Bootstrapper : BootstrapperBase
    {
        protected override IServiceCollection AddServices(IServiceCollection services)
        {
            return base.AddServices(services)
                .AddJsonConfigurationProvider(ConfigurationManager.AppSettings["ConfigurationFile"]);
        }
    }
}

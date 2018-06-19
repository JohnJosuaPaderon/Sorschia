using Microsoft.Extensions.DependencyInjection;

namespace Sorschia.Plugins
{
    public interface IPluginIntegrator
    {
        void Integrate();
        void IntegrateServices(IServiceCollection services);
    }
}

using Microsoft.Extensions.DependencyInjection;
using Prism.Unity;
using Sorschia.Views;
using System.Windows;

namespace Sorschia
{
    public abstract class BootstrapperBase : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.TryResolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected virtual void ConfigureServices(IServiceCollection services)
        {

        }

        public override void Run(bool runWithDefaultConfiguration)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceStore.Initialize(services.BuildServiceProvider());
            base.Run(runWithDefaultConfiguration);
        }
    }
}

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

        protected virtual IServiceCollection AddServices(IServiceCollection services)
        {
            return services;
        }

        public override void Run(bool runWithDefaultConfiguration)
        {
            ServiceStore.Initialize(AddServices(new ServiceCollection()).BuildServiceProvider());
            base.Run(runWithDefaultConfiguration);
        }
    }
}

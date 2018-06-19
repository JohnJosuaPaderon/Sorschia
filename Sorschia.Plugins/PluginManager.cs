using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;

namespace Sorschia.Plugins
{
    public static class PluginManager
    {
        public static void Integrate(string assemblyDirectoryPath, IServiceCollection services)
        {
            if (string.IsNullOrWhiteSpace(assemblyDirectoryPath))
            {
                throw new ArgumentException("Invalid path.");
            }
            else if (!Directory.Exists(assemblyDirectoryPath))
            {
                throw new DirectoryNotFoundException("Cannot find assembly directory.");
            }

            var assemblies = GetAssemblies(assemblyDirectoryPath);

            if (assemblies != null && assemblies.Any())
            {
                var integrators = GetIntegrators(assemblies);

                foreach (var integrator in integrators)
                {
                    integrator.Integrate();
                    integrator.IntegrateServices(services);
                }
            }
            else
            {
                throw new Exception("No assemblies found.");
            }
        }

        private static IEnumerable<IPluginIntegrator> GetIntegrators(IEnumerable<Assembly> assemblies)
        {
            var configuration = new ContainerConfiguration()
                .WithAssemblies(assemblies);

            using (var container = configuration.CreateContainer())
            {
                return container.GetExports<IPluginIntegrator>();
            }
        }

        private static IEnumerable<Assembly> GetAssemblies(string directoryPath)
        {
            return Directory.GetFiles(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "*.dll", SearchOption.AllDirectories).Select(AssemblyLoadContext.Default.LoadFromAssemblyPath);
        }
    }
}

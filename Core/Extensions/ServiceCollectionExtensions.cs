using System;
using System.Collections.Generic;
using System.Text;
using Core.IOC;
using Core.Utilities.IOC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers
            (this IServiceCollection serviceCollection, ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.load(serviceCollection);

            }
            return ServiceTool.Create(serviceCollection);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Utilities.IOC
{
    public interface ICoreModule
    {
        void load(IServiceCollection serviceCollection);
    }
}

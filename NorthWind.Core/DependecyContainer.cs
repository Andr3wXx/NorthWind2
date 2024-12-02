﻿using Microsoft.Extensions.DependencyInjection;
using NorthWind.ConsoleApp.Services;
using NorthWind2.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependecyContainer
{
    public static IServiceCollection AddServices (
        this IServiceCollection services)
    {
        services.AddSingleton<IAppLogger, AppLogger>();
        services.AddSingleton<IProductService, ProductService>();
        return services;
    }

}
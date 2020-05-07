using CutomApiLib.Middlewares;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CutomApiLib
{
    public static class CustomApiLibRegist
    {
        public static void AddCustomApiLib(this IServiceCollection services)
        {
            services.AddScoped<CustomResponseResult>();
        }
    }
}

using FribraryApi.Services.Impl;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FribraryApi.Services
{
    public static class ConfigureServiceExtension
    {
        public static void AddFribaryApiServices(this IServiceCollection services)
        {
            services.AddTransient<ISongsService, SongsService>();
        }
    }
}

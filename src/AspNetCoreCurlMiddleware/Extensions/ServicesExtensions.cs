﻿using AspNetCoreCurlMiddleware.Builder;
using AspNetCoreCurlMiddleware.Models;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreCurlMiddleware.Extensions
{
    /// <summary>
    /// Service Extensions the save as curl middleware
    /// </summary>
    public static class ServicesExtensions
    {
        /// <summary>
        /// Adds the services for curl middleware
        /// </summary>
        /// <param name="services">Service Collection</param>
        /// <param name="options">Parameters for the curl builder</param>
        /// <returns></returns>
        public static IServiceCollection AddSaveAsCurlMiddlewareServices(this IServiceCollection services, SaveRequestOptions options = null)
        {
            services.AddSingleton<IRequestBuilder>(c => new CurlBuilder(options));
            return services;
        }
    }
}

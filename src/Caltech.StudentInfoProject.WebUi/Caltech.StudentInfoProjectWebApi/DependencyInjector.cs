﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Caltec.StudentInfoProjectWebApi
{
    
    public static class DependencyInjectorExtensions
    {
        public static void AddCalTechDependency(this IServiceCollection services)
        {
            // Register your dependencies here

            // Add more dependencies as needed

            // Register Swagger
            services.AddSwaggerGen();

            // Add MVC services
            services.AddMvc();

            // Add MVC middleware
            services.AddMvcCore().AddApiExplorer();

            // Add MVC routing
            services.AddRouting();

            // Add MVC endpoints
            services.AddControllers();

            // Add Swagger UI middleware
            
        }

        public static IApplicationBuilder UseCaltechDependency(
            this IApplicationBuilder app
          )
        {
            
            app.UseSwagger();
            return app.UseSwaggerUI();
        }
    }
}
﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Middleware
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            
            app.UseDefaultFiles();
             app.UseStaticFiles();

            //app.Use(async (context, next) =>
            //{
            //    // await context.Response.WriteAsync("Hello World!");
            //    logger.LogInformation("mw1 logging");
            //    await next();
            //    logger.LogInformation("mw1 outgoing logging");
            //});
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");

            //});
            //app.Use(async (context, next) =>
            //{
            //    // await context.Response.WriteAsync("Hello World!");
            //    logger.LogInformation("mw2 logging");
            //    await next();
            //    logger.LogInformation("mw2 outgoing logging");
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello from second World!");
            //    logger.LogInformation("mw3 outgoing logging");
            //});
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello from second1 World!");

            });
        }
    }
}

using System;
using LoginDemo.Areas.Identity.Data;
using LoginDemo.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(LoginDemo.Areas.Identity.IdentityHostingStartup))]
namespace LoginDemo.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<LoginDemoContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("LoginDemoContextConnection")));

                services.AddDefaultIdentity<LoginDemoUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<LoginDemoContext>();
            });
        }
    }
}
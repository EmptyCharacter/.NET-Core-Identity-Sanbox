using System;
using Identity_SandBox.Areas.Identity.Data;
using Identity_SandBox.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Identity_SandBox.Areas.Identity.IdentityHostingStartup))]
namespace Identity_SandBox.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Identity_SandBoxContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Identity_SandBoxContextConnection")));

                services.AddDefaultIdentity<Identity_SandBoxUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Identity_SandBoxContext>();
            });
        }
    }
}
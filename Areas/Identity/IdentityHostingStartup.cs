using System;
using ExpressEats.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(ExpressEats.Areas.Identity.IdentityHostingStartup))]
namespace ExpressEats.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ExpressEatsContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ExpressEatsContextConnection")));

    
            });
        }
    }
}
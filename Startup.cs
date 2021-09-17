using ExpressEats.Data;
using ExpressEats.Models;
using ExpressEats.ViewModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressEats
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        //DI
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IFoodRepo, FoodRepo>();
            services.AddScoped<ICategoryRepo, CategoryRepo>();
            services.AddControllersWithViews();
            services.AddDbContext<FoodDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
                                                                    .EnableSensitiveDataLogging());
            services.AddScoped<ShoppingCart>(s => ShoppingCart.GetCart(s));
            services.AddHttpContextAccessor();
            services.AddSession();
            services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<ExpressEatsContext>();

            services.AddAuthentication().AddLinkedIn(options=>
            {
                options.ClientId = Configuration["App:LinkedInClientId"];
                options.ClientSecret = Configuration["App:LinkedinClientSecret"];
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseFileServer();
            app.UseSession();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}

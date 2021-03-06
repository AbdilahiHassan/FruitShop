using FruitShop.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitShop
{
    public class Startup
    {        
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }



        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)

        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))

            );

            //-------Identity-------
            services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<AppDbContext>();
          //  services.AddIdentity<IdentityUser, IdentityRole>()
          //.AddEntityFrameworkStores<AppDbContext>()
          //      .AddDefaultTokenProviders(); That is good

             //-------------
            //services.AddRazorPages();
          //  services.AddControllersWithViews();
            services.AddMvc();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            services.AddScoped<IFruitRepository, FruitRepository>();
            //I am using Static methoth here: when user is comming this site we creating a shoppingCart
            services.AddScoped<ShoppingCart>(sc => ShoppingCart.GetCart(sc));
            services.AddScoped<IOrderRpository, OrderRepository>();
            services.AddHttpContextAccessor();
            services.AddSession();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            //Middle where
            app.UseHttpsRedirection(); //ok
            app.UseStaticFiles(); //ok
            app.UseSession();//middleware

            app.UseRouting(); //ok

           app.UseAuthentication();//  Add this
            app.UseAuthorization();//  Add this too


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages(); // it is helping RazorPages
            });
        }
    }
}

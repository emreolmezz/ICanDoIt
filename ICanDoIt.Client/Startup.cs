using ICanDoIt.Client.EmailServices;
using ICanDoIt.Client.Extensions;
using ICanDoIt.Client.Identity;
using ICanDoIt.Data;
using ICanDoIt.Entity.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace ICanDoIt.Client
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddApplicationServices();
            services.AddDbContext<IdentityContext>(options => options.UseSqlServer(Configuration.GetConnectionString("connectionString")));
            services.AddDbContext<ShopContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("connectionString"), o =>
                {
                    o.MigrationsAssembly("ICanDoIt.Data");
                });
            });
            services.AddScoped<IEmailSender, EmailSender>(i =>
                new EmailSender(
                    Configuration["EmailSender:Host"],
                     Configuration.GetValue<int>("EmailSender:Port"),
                     Configuration.GetValue<bool>("EmailSender:EnableSSL"),
                      Configuration["EmailSender:UserName"],
                      Configuration["EmailSender:Password"]

                    )
                );
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromDays(2);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IConfiguration configuration, UserManager<User> userManager, RoleManager<IdentityRole> roleManager, ICartService cartService)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStatusCodePages();
            app.UseStaticFiles(); // wwwroot
            app.UseRouting();
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();
            app.AddEndPoints();
            SeedIdentity.Seed(userManager, roleManager, cartService, configuration).Wait();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.Material;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Sep3Vacation.Authentication;
using Sep3Vacation.Data;
using Sep3Vacation.Models;

namespace Sep3Vacation
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
  

        services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<IUserService, InMemoryUserService>();
            // services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            services.AddScoped<IPackagesService, CloudPackageService>();
            services.AddScoped<IBoughtPackages, BoughtPackagesService>();
            services.AddScoped<ICryptoService, CryptoService>();
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            services.AddSignalR();
            services.AddAuthorization(options =>
            {

                options.AddPolicy("RoleAdmin", a =>
                    a.RequireAuthenticatedUser().RequireClaim("Role", "admin"));
                options.AddPolicy("RoleUser",a=>
                    a.RequireAuthenticatedUser().RequireClaim("Role","user"));
            
            });
            services.AddBlazorise(options =>
            {
                options.ChangeTextOnKeyPress = true; // optional
            }).AddBootstrapProviders().AddMaterialIcons();

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

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
                endpoints.MapHub<ChatHub>("/chathub");
            });
        }
    }
}
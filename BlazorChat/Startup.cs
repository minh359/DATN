using BlazorChat.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;
using Microsoft.AspNetCore.ResponseCompression;
using BlazorChat.Hubs;
using System.Net.Http;
using BlazorChat.Services;
using MudBlazor.Services;
using MudBlazor;

namespace BlazorChat
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
            services.AddControllersWithViews();
            services.AddServerSideBlazor();
            services.AddMudServices();
            services.AddSingleton<WeatherForecastService>();
            services.AddTransient<IDialogService, DialogService>();
            //add Server API
            services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5001/") });


            services.AddTransient<IAccountServices, AccountServices>();
            services.AddTransient<IBoxChatServices, BoxChatServices>();
            services.AddTransient<IGroupServices, GroupServices>();



            services.AddResponseCompression(opts =>
            {
                opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
                    new[] { "application/octet-stream" });
            });
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseResponseCompression();
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
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapHub<ChatHub>("/chathub");
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}

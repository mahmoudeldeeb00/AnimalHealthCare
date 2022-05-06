using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;

using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;
using ProjectBackEndDemo.Areas.Emergency.EmergencyServices;
using ProjectBackEndDemo.Areas.Identity.Models;
using ProjectBackEndDemo.BL.Helpers;
using ProjectBackEndDemo.BL.IRepository;
using ProjectBackEndDemo.BL.Mapper;
using ProjectBackEndDemo.BL.Repository;
using ProjectBackEndDemo.DAL.DataBase;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using ProjectBackEndDemo.Infrastructure;
using Microsoft.AspNetCore.SignalR;
using ProjectBackEndDemo.Areas.Sensor.SensorRep;
using ProjectBackEndDemo.Areas.Diseases.Rep;
using ProjectBackEndDemo.Areas.Vets.Rep;
using ProjectBackEndDemo.Areas.Care.Rep;
using ProjectBackEndDemo.Areas.Identity.Rep;
using NToastNotify;

namespace ProjectBackEndDemo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc().AddNToastNotifyToastr(new ToastrOptions()
            {
                ProgressBar = true,
                PositionClass = ToastPositions.BottomRight,
                PreventDuplicates = true,
                CloseButton = true,
                TimeOut = 10000

            });
            services.AddControllersWithViews()
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization()
                 .AddNewtonsoftJson(opt =>
                 {
                     opt.SerializerSettings.ContractResolver = new DefaultContractResolver();
                 });
           

            services.AddSignalR();

            services.AddAutoMapper(x => x.AddProfile(new DomainProfile()));
            services.AddScoped<DbContainer>();
            services.AddScoped<IEmergencyRep , EmergencyRep>();
            services.AddScoped<MailHelper>();
            services.AddScoped<SaveFileHelper>();
            services.AddScoped<ISensorRep , SensorRep>();
            services.AddScoped<ISelectHelper, SelectHelper>();
            services.AddScoped<IDiseaseRep,DiseaseRep>();
            services.AddScoped<IVetRep,VetRep>(); 
            services.AddScoped<ILifeStyleRep, LifeStyleRep>();
            services.AddScoped<IAdminRep, AdminRep>();
         

            services.AddTransient<INotificationRep, NotificationRep>();




            services.AddIdentity<AppUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 3;
                options.Password.RequiredUniqueChars = 0;
               
            }).AddEntityFrameworkStores<DbContainer>()
              .AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider); ;
          
            services.AddDbContextPool<DbContainer>(opts => opts.UseSqlServer(Configuration.GetConnectionString("AnimalHealthCare")));


            services.AddRazorPages();
          
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/Identity/Account/Login";
                options.LogoutPath = $"/Identity/Account/Logout";
          
                options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseNToastNotify();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

      
            app.UseAuthentication();
            app.UseAuthorization();
            var supportedCultures = new[] {
                          new CultureInfo("ar-EG"),
                          new CultureInfo("en-US"),
            };
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("en-US"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures,
                //over ride to reach arabic succefully
                RequestCultureProviders = new List<IRequestCultureProvider>
                {
                new QueryStringRequestCultureProvider(),
                new CookieRequestCultureProvider()
                }
            });
          
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<SignalServer>("/signalServer");
            });


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                  endpoints.MapControllerRoute(name: "login",
                     pattern: "{area:exists}/{controller=Account}/{action=Login}/{id?}");
            

            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                    endpoints.MapControllerRoute(name: "login",
                     pattern: "{area:exists}/{controller=Account}/{action=Login}/{id?}");
            });


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}

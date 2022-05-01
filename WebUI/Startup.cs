using CV.Business.IOC.Microsoft;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebUI
{
    public class Startup
    {
        public IConfiguration _configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options => 
            {
                //HTTPOnly document.cookie ile tarayıcıdaki bilgiler dönmesin diye yazdık
                options.Cookie.HttpOnly = true;
                options.Cookie.Name = "Buğrahan SABUNCU";
                //lax diğer web sitelerinin kullanımına açarken strict kapatır.
                options.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict;
                //always seçimini yaparsak bu sadece https'de çalışır SameAsRequest ise her ikisinde
                options.Cookie.SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.SameAsRequest;
                //kullanıcı bilgileri çerezlerde kaç gün kalacak.
                options.ExpireTimeSpan = TimeSpan.FromDays(20);

                options.LoginPath = new PathString("/Auth/Login");
            });
            services.AddCustomDependencies(_configuration);
            //services.AddControllersWithViews().AddFluentValidation();
            services.AddControllersWithViews().AddFluentValidation();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();//wwwroot klasörünü dışarıya açarız
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpointsin içini yazarken = kullanmazsak bu olmak zorunda anlamına gelir.
                //eşittir ifadesi sana herhangi controller girilmediyse sen onu homecontroller olarak algıla demektir.
                endpoints.MapControllerRoute("areas", "{area}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

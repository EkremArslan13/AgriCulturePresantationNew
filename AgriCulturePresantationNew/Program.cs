using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Container;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using System.Net;

namespace AgriCulturePresantationNew
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // DbContext Tanýmlamasý
            builder.Services.AddDbContext<AgriCultureContext>();

            // --- IDENTITY SERVÝSLERÝ (Hatanýn Çözüldüðü Yer) ---
            builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AgriCultureContext>();
            // <--- Eksik olan ve hataya sebep olan satýr buydu!

            // Baðýmlýlýk Enjeksiyonlarý (DI Container)
            // Program.cs içinde builder tanýmlandýktan sonra:
            builder.Services.ContainerDependencies();

            // MVC ve Global Authorization Filtresi
            builder.Services.AddControllersWithViews(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                     .RequireAuthenticatedUser()
                     .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });

            // Login ve Cookie Ayarlarý
            builder.Services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Login/Index/";
            });

            var app = builder.Build();

            // HTTP istek hattý yapýlandýrmasý (Middleware)
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            // --- KÝMLÝK DOÐRULAMA SIRALAMASI (Önemli) ---
            app.UseAuthentication(); // <--- Kim olduðunu kontrol eder (Bunu ekledik)
            app.UseAuthorization();  // <--- Yetkini kontrol eder

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Default}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
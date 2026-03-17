using Microsoft.EntityFrameworkCore;

namespace AcRepairWebsite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


        
        builder.Services.AddControllersWithViews();

            builder.Services.AddSession();
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(
                    builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();

            
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();

            app.MapStaticAssets();

            app.MapControllerRoute(
             name: "home",
             pattern: "",
             defaults: new { controller = "Home", action = "Index" });

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}");
               

            app.Run();
        }
    }


}

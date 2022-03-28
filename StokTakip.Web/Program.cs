using Microsoft.EntityFrameworkCore;
using StokTakip.Data.Concrete.EntityFramework.Contexts;
using StokTakip.Services.AutoMapper.Profiles;
using StokTakip.Services.Extensions;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(MapsProfile));
builder.Services.LoadMyService();
builder.Services.AddDbContext<StokTakipContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"), opt =>
    {
        opt.MigrationsAssembly(Assembly.GetAssembly(typeof(StokTakipContext)).GetName().Name);
    });
});



var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

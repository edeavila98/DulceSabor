using Microsoft.EntityFrameworkCore;
using DulceSabor.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using DulceSabor.Controllers;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DulceSaborDBContex>(options =>
options.UseSqlServer(
    builder.Configuration.GetConnectionString("DulceSaboDB")
    )
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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

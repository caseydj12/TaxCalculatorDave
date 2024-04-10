using Microsoft.EntityFrameworkCore;
using TaxCalc.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
builder.Services.AddMvc().AddRazorRuntimeCompilation();

// EntityFrameworkCore
// In Package Manager Console:
// 1. Add-Migration "migration commit name"
// 2. Update-Database
builder.Services.AddDbContext<ApplicationDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("TaxIdPortal")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "taxcontroller",
    pattern: "{controller=Home}/{action=CalculateTaxes}/{income}");

app.Run();

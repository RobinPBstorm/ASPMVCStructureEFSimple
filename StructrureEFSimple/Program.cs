using Microsoft.EntityFrameworkCore;
using StructrureEFSimple.BLL.Services;
using StructrureEFSimple.BLL.Services.Interfaces;
using StructureEFSimple.DAL.Database;
using StructureEFSimple.DAL.Repositories;
using StructureEFSimple.DAL.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add DB Context
builder.Services.AddDbContext<PersonneContext>(
    b => b.UseSqlServer(builder.Configuration.GetConnectionString("Default"))
);

// Add repository FROM DAL
builder.Services.AddScoped<IPersonneRepository, PersonneRepository>();

// Add servies From BLL
builder.Services.AddScoped<IPersonneService, PersonneService>();

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

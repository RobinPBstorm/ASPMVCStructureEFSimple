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
    // Cette connection string est définit dans appsettings.json
    b => b.UseSqlServer(builder.Configuration.GetConnectionString("Default"))
);

// Pour l'ajout des Services et repositories peut se faire 2 façons:
// couplage fort (directement la classe): AddScoped<PersonneService>()
// couplage faible (donne une interface et une implémentation) AddScoped<Iservice, PersonneService>()

// Add repository FROM DAL
builder.Services.AddScoped<IPersonneRepository, PersonneRepository>();
#region Singleton, Scoped et Transient
// Une instance par périmètre d'action
//builder.Services.AddScoped<IPersonneRepository, PersonneRepository>();
// Une instance par demande
//builder.Services.AddTransient<IPersonneRepository, PersonneRepository>();
// Une instance pour tout le projet
//builder.Services.AddSingleton<IPersonneRepository, PersonneRepository>();
#endregion

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
    pattern: "{controller=Personne}/{action=Index}/{id?}");

app.Run();

using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using PlatformeEntretien;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Connexion>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyConn")));
builder.Services.Configure<FormOptions>(options => {
    options.ValueCountLimit = 4096;
});
// Add services to the container.
builder.Services.AddControllersWithViews();

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
    //pattern: "{controller=Candidature}/{action=Index}/{id?}");
    pattern: "{controller=Admin}/{action=Index}/{id?}");

app.Run();
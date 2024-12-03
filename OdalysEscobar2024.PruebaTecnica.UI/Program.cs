using Microsoft.EntityFrameworkCore;
using OdalysEscobar2024.PruebaTecnica.DAL;
using OdalysEscobar2024.PruebaTecnica.BL;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<ComunDB>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("Conn"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("Conn"))
    ));


builder.Services.AddScoped<CategoriaDAL>();
builder.Services.AddScoped<CategoriasBL>();


builder.Services.AddControllersWithViews();

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

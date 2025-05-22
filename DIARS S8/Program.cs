using DIARS_S8.Data;
using DIARS_S8.Repositories;
using DIARS_S8.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// SI usaremos el patron singleton manualmente
// builder.Services.AddDbContext<AppDbContext>(options =>
//     options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registro del repositorio con opciones
// builder.Services.AddScoped<IClienteRepository>(provider =>
// {
//     var options = provider.GetRequiredService<DbContextOptions<AppDbContext>>();
//     return new ClienteRepository(options);
// });

// Configura la cadena de conexión
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registrar el repositorio
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

// Registrar una estrategia de defecto
builder.Services.AddScoped<IFiltroClienteStrategy, FiltroTodos>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
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
    pattern: "{controller=Cliente}/{action=Index}/{id?}");

app.Run();

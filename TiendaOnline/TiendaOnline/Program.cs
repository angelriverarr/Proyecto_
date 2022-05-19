//using TiendaOnline.Repository;
using TiendaOnline.Data;
//using TiendaOnline.Services;
using Microsoft.EntityFrameworkCore;
//Usamos la libreria de microsoft que trabaja con las cookies
using Microsoft.AspNetCore.Authentication.Cookies;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//cadena de conexion de mysql
var conecctionstring = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<ApplicationDBContext>(options =>
options.UseMySql(conecctionstring, ServerVersion.AutoDetect(conecctionstring)));


//inyecion de la dependencia
//builder.Services.AddTransient<IUsers,UsersRepository>();

//CONFIGURAR NUESTRA COOKIE DE AUTENTICACION
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(option =>
     {//agregamos nueva cookie
         option.LoginPath = "/Presentacion/Index";//Espeficamo la pagina de logeo
         option.ExpireTimeSpan = TimeSpan.FromMinutes(10);//Espeficamos el tiempo de expiracion del logeo 
         option.AccessDeniedPath = "/Presentacion/Index";//Espeficamos a q vista se tiene que dirigir cuando no ha iniciado sesion
     });

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

//Agregamos la autenticacion
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

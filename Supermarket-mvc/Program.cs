var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddControllersWithViews();//injects all the services required by the Map controller method

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();

//all this code is the support for the MVC framework

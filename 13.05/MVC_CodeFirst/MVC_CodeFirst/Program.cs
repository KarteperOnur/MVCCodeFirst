var builder = WebApplication.CreateBuilder(args);
//MVC
builder.Services.AddControllersWithViews();


var app = builder.Build();

//staticfiles
app.UseStaticFiles();
//route
app.UseRouting();
//maproute
app.MapControllerRoute(
    name: "default", 
    pattern: "{Controller=Home}/{Action=Index}/{id?}");
    //https:localhost:7668/Home/Index/5

app.Run();

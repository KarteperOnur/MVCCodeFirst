using AspNetCore_MVC_DependencyInjection.Repositories.Abstracts;
using AspNetCore_MVC_DependencyInjection.Repositories.Concretes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//AddService iþlemi ile birlikte bütün controllerlarda kullanýlmak üzere bir baðýmlýlýk oluþturduk.
builder.Services.AddScoped<IProductService, FakeProductService>(); //dependency

//AddScoped: Her istekle beraber sadece 1 adet instance oluþturur.
//AddSingleton: Bir adet instance alýr her isteðe alýnan instance verilir.
//AddTransient: her istekle beraber ayrý instance verir.








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

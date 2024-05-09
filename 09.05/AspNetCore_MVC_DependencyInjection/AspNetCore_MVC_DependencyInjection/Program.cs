using AspNetCore_MVC_DependencyInjection.Repositories.Abstracts;
using AspNetCore_MVC_DependencyInjection.Repositories.Concretes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//AddService i�lemi ile birlikte b�t�n controllerlarda kullan�lmak �zere bir ba��ml�l�k olu�turduk.
builder.Services.AddScoped<IProductService, FakeProductService>(); //dependency

//AddScoped: Her istekle beraber sadece 1 adet instance olu�turur.
//AddSingleton: Bir adet instance al�r her iste�e al�nan instance verilir.
//AddTransient: her istekle beraber ayr� instance verir.








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

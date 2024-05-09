using TransientSingletonScoped.Repositories;
using TransientSingletonScoped.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//singleton: istek kontrol edilir daha �nce bir instance al�nmam��sa bir kez instance al�n�p her istek ile beraber o instance teslim edilir.
builder.Services.AddSingleton<ISingletonService, OperationService>();

//scoped: Her istek ile birlikte o iste�e ba�l� yeni bir instance al�r.
builder.Services.AddScoped<IScopeService, OperationService>();

//transient: her istek ile beraber her istek i�in ayr� bir instance al�r.
builder.Services.AddTransient<ITransientService, OperationService>();



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

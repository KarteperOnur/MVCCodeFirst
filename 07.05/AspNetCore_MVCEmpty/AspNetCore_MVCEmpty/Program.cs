
//builder: projenin hangi platform �zerinden aya�a kald�r�laca��n�n detay�n� belirler.
var builder = WebApplication.CreateBuilder(args);

//Services
builder.Services.AddMvc(); //projeye mvc'nin dahil edilmesi.


var app = builder.Build();


app.UseRouting();

//app.MapGet("/test", () => "Merhaba MVC");

//Route: Controller'a yap�lacak olan istekleri i�in tna�mlanmas� gereken rotasyonlar� bar�nd�r�r.
app.UseEndpoints(x =>
{
     x.MapDefaultControllerRoute(); //HomeController, Index

    //Home: Varsay�lan Controller
    //Index: Varsay�lan metot


    //ControllerAd/MetotAd
});


app.Run();

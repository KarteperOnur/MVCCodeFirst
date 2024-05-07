
//builder: projenin hangi platform üzerinden ayaða kaldýrýlacaðýnýn detayýný belirler.
var builder = WebApplication.CreateBuilder(args);

//Services
builder.Services.AddMvc(); //projeye mvc'nin dahil edilmesi.


var app = builder.Build();


app.UseRouting();

//app.MapGet("/test", () => "Merhaba MVC");

//Route: Controller'a yapýlacak olan istekleri için tnaýmlanmasý gereken rotasyonlarý barýndýrýr.
app.UseEndpoints(x =>
{
     x.MapDefaultControllerRoute(); //HomeController, Index

    //Home: Varsayýlan Controller
    //Index: Varsayýlan metot


    //ControllerAd/MetotAd
});


app.Run();

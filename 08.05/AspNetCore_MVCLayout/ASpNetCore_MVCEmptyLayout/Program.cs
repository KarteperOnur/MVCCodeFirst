var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

//rotanýn aktif edilmesi. Url'de ilgili controller içerisindeki ilgili view'lara ulaþýlmasý için aktif hale getiriyoruz.
app.UseRouting();

app.UseStaticFiles(); //wwwroot klasörünün dýþarýya açýlmasýný saðlar. Bu klasör içerisinde aþaðýdaki formatlarý doðrudan barýndýrabilir.
//css, javascript, html, txt, image, csv, exel, word, mp3, mp4


app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
    //HomeController/Index
});

app.Run();

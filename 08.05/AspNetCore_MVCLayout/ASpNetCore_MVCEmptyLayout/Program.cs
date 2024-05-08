var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

//rotan�n aktif edilmesi. Url'de ilgili controller i�erisindeki ilgili view'lara ula��lmas� i�in aktif hale getiriyoruz.
app.UseRouting();

app.UseStaticFiles(); //wwwroot klas�r�n�n d��ar�ya a��lmas�n� sa�lar. Bu klas�r i�erisinde a�a��daki formatlar� do�rudan bar�nd�rabilir.
//css, javascript, html, txt, image, csv, exel, word, mp3, mp4


app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
    //HomeController/Index
});

app.Run();

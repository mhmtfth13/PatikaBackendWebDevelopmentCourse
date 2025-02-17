var builder = WebApplication.CreateBuilder(args); // Burada builder olusturuyoruz...
builder.Services.AddControllersWithViews(); // Burada servisler icinden Controller yapilarini ve View yapilarini kullanmak icin ekleme islemi yapiyoruz...
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
// Kendi MapRouterimizi yaziyoruz...


app.UseStaticFiles();// 1. Statik Dosyalarýn Kullanýmý


app.UseRouting(); // 2. Routing Konfigürasyonu

app.MapControllerRoute
    (
    name: "default",
    pattern: "{Controller=home}/{Action=Index}" // Burada uri ustunde hangi sema ile cagri yapacagini ayarliyoruz.. Default olarak sayfanin home controller icinden Index metoduna gitmesini ayarladik...
    );

app.Run();


/*
MVC (Model-View-Controller) Mimarisi Kavramlarý:

1. Controller: 
  - Kullanýcý isteklerini karþýlayan ve yöneten sýnýflardýr
  - URL'lerden gelen istekleri yakalar ve uygun Action'larý çalýþtýrýr
  - View'a gönderilecek verileri hazýrlar

2. Action:
  - Controller sýnýflarý içindeki metotlardýr
  - Belirli URL'lere karþýlýk gelen iþlemleri gerçekleþtirir
  - View'a model gönderir veya yönlendirme yapar

3. Model:
  - Verilerin ve iþ mantýðýnýn tutulduðu sýnýflardýr
  - View'a gönderilecek verileri tutar

4. View:
  - Kullanýcý arayüzünün oluþturulduðu .cshtml dosyalarýdýr
  - Controller'dan gelen model verilerini görüntüler
  - HTML ve C# kodlarýný birlikte kullanýr

5. Razor:
  - View'larda C# kodunu HTML içine gömmeyi saðlayan syntax'týr
  - @ iþareti ile C# kodlarý yazýlýr

6. RazorView:
  - .cshtml uzantýlý dosyalardýr

7. wwwroot:
  - Statik dosyalarýn (css, js, resim) saklandýðý klasördür
  - Doðrudan web üzerinden eriþilebilir
  - app.UseStaticFiles() ile aktif edilir

Önemli Metotlar:

1. builder.Build():
  - Servis konfigürasyonlarýný tamamlar

2. app.Run():
  - Web uygulamasýný baþlatýr
  - HTTP isteklerini dinlemeye baþlar
  - Uygulama kapatýlana kadar çalýþýr
*/
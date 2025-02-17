var builder = WebApplication.CreateBuilder(args); // Burada builder olusturuyoruz...
builder.Services.AddControllersWithViews(); // Burada servisler icinden Controller yapilarini ve View yapilarini kullanmak icin ekleme islemi yapiyoruz...
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
// Kendi MapRouterimizi yaziyoruz...


app.UseStaticFiles();// 1. Statik Dosyalar�n Kullan�m�


app.UseRouting(); // 2. Routing Konfig�rasyonu

app.MapControllerRoute
    (
    name: "default",
    pattern: "{Controller=home}/{Action=Index}" // Burada uri ustunde hangi sema ile cagri yapacagini ayarliyoruz.. Default olarak sayfanin home controller icinden Index metoduna gitmesini ayarladik...
    );

app.Run();


/*
MVC (Model-View-Controller) Mimarisi Kavramlar�:

1. Controller: 
  - Kullan�c� isteklerini kar��layan ve y�neten s�n�flard�r
  - URL'lerden gelen istekleri yakalar ve uygun Action'lar� �al��t�r�r
  - View'a g�nderilecek verileri haz�rlar

2. Action:
  - Controller s�n�flar� i�indeki metotlard�r
  - Belirli URL'lere kar��l�k gelen i�lemleri ger�ekle�tirir
  - View'a model g�nderir veya y�nlendirme yapar

3. Model:
  - Verilerin ve i� mant���n�n tutuldu�u s�n�flard�r
  - View'a g�nderilecek verileri tutar

4. View:
  - Kullan�c� aray�z�n�n olu�turuldu�u .cshtml dosyalar�d�r
  - Controller'dan gelen model verilerini g�r�nt�ler
  - HTML ve C# kodlar�n� birlikte kullan�r

5. Razor:
  - View'larda C# kodunu HTML i�ine g�mmeyi sa�layan syntax't�r
  - @ i�areti ile C# kodlar� yaz�l�r

6. RazorView:
  - .cshtml uzant�l� dosyalard�r

7. wwwroot:
  - Statik dosyalar�n (css, js, resim) sakland��� klas�rd�r
  - Do�rudan web �zerinden eri�ilebilir
  - app.UseStaticFiles() ile aktif edilir

�nemli Metotlar:

1. builder.Build():
  - Servis konfig�rasyonlar�n� tamamlar

2. app.Run():
  - Web uygulamas�n� ba�lat�r
  - HTTP isteklerini dinlemeye ba�lar
  - Uygulama kapat�lana kadar �al���r
*/
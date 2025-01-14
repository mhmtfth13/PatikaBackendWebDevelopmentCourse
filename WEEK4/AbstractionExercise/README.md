# AbstractionExercise

Bu repo, C# dilinde soyutlama (abstraction) kullanımını gösteren bir örnek sunmaktadır. Temel `Employee` sınıfı soyut (abstract) olup, yazılım geliştirici, proje lideri ve satış temsilcisi gibi farklı çalışan türlerini temsil eden sınıflar tarafından genişletilmektedir.

## Genel Bakış

Bu proje, C# dilinde soyut sınıflar ve metotlar kullanımı üzerine bir örnek sunmaktadır. `Employee` sınıfı, ortak özellikleri ve tüm çalışanların implement etmesi gereken bir metodu (`Gorev`) içerir. Her bir spesifik çalışan sınıfı (`SoftwareDeveloper`, `ProjectLead`, `SalesRepresentative`), bu metodu kendi rolüne göre özelleştirerek uygulamaktadır.

## Dosya Yapısı

- **AbstractionExercise/Employee.cs**: Soyut `Employee` sınıfını ve onun alt sınıflarını (SoftwareDeveloper, ProjectLead, SalesRepresentative) içerir.
- **PatikaWeek4.AbstractExercise/Program.cs**: Her bir çalışan türünü örnekleyip, `Gorev` metodunu çağırarak test eder.

## Sınıflar ve Metodlar

### Employee Sınıfı

- **Özellikler**:
  - `Name`: Çalışanın adı.
  - `Surname`: Çalışanın soyadı.
  - `Department`: Çalışanın çalıştığı departman.

- **Metod**:
  - `Gorev(string name, string surname, string department)`: Bu soyut metod, her alt sınıf tarafından implement edilerek çalışanın rolü ve departmanı hakkında bilgi veren bir mesajı ekrana yazdırır.

### SoftwareDeveloper Sınıfı

- `Employee` sınıfından türetilmiştir.
- `Gorev` metodunu override ederek çalışanın yazılım geliştirici olarak görev yaptığını belirten bir mesaj yazdırır.

### ProjectLead Sınıfı

- `Employee` sınıfından türetilmiştir.
- `Gorev` metodunu override ederek çalışanın proje lideri olarak görev yaptığını belirten bir mesaj yazdırır.

### SalesRepresentative Sınıfı

- `Employee` sınıfından türetilmiştir.
- `Gorev` metodunu override ederek çalışanın satış temsilcisi olarak görev yaptığını belirten bir mesaj yazdırır.

## Örnek Kullanım

`Program.cs` dosyasında her bir çalışan türünden nesneler oluşturulmuş ve `Gorev` metodu çağrılarak farklı çalışan rolleri test edilmiştir. Aşağıda örnek bir çıktı yer almaktadır:


## Çalıştırma Adımları

1. Reposunu klonlayın veya proje dosyalarını indirin.
2. Projeyi bir C# IDE’sinde (Visual Studio gibi) açın.
3. `Program.cs` dosyasını derleyip çalıştırın.

## Sonuç

Bu proje, nesne yönelimli programlamada soyutlamanın nasıl kullanılacağını gösteren basit bir örnektir. `Gorev` metodunun davranışı, çalışan türüne göre farklılık gösterirken, sınıf yapısı tutarlıdır.

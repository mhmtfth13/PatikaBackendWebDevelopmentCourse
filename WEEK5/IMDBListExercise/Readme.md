# IMDB List Exercise

Bu proje, kullanıcıların film adı ve IMDB puanı girerek bir film listesi oluşturmasını sağlayan bir uygulamadır. Program, girilen filmleri listeleyerek, belirli filtrelerle (IMDB puanı 4-9 arası ve 'A' ile başlayan filmler) kullanıcılara seçenekler sunar.

## Özellikler

1. **Film Adı ve Puanı Girişi**: 
   - Kullanıcıdan film adı ve 1-10 arası puan alınır.
   - Film adı sadece harflerden ve boşluktan oluşabilir.
   - Puan 1 ile 10 arasında olmalıdır.

2. **Film Listeleme**:
   - Kullanıcı, filmleri ekledikçe sistem bu filmleri listeleyebilir.
   - Program sonunda:
     - Tüm filmleri,
     - IMDB puanı 4 ile 9 arasında olan filmleri,
     - 'A' harfiyle başlayan filmleri listeleyen seçenekler sunar.

3. **Hata Kontrolleri**:
   - Kullanıcı geçersiz film adı veya puan girerse, sistem hata mesajı verir ve tekrar denemeyi ister.

## Kullanıcı Akışı

1. Kullanıcı bir film adı girer.
2. Kullanıcı film için bir puan girer (1-10 arası).
3. Kullanıcıya başka film eklemek isteyip istemediği sorulur.
4. Kullanıcı "E" girerse film eklemeye devam edilir, "H" girerse program sonlanır.
5. Program sonunda belirtilen kriterlere göre film listeleri ekrana yazdırılır.

## Kurulum ve Çalıştırma

1. Visual Studio veya bir IDE kullanarak projeyi açın.
2. Programı çalıştırarak film ekleme ve listeleme işlemlerini gerçekleştirebilirsiniz.

---

Bu uygulama, temel kullanıcı girişi ve hata yönetimiyle ilgili önemli kavramları içerir ve kullanıcıdan gelen verilere göre filtreleme işlemi gerçekleştirir.

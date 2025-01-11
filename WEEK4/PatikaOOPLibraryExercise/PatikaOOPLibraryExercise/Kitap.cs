using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaOOPLibraryExercise
{
    internal class Kitap // Burada Kitap adinda bir class (sinif) olusturduk.
    {
        private string _bookName; // // Burada encapsulation seklinde degisken tanimlama yapildi.
        private string _writerName; // // Burada encapsulation seklinde degisken tanimlama yapildi.
        private string _writerSurname; // // Burada encapsulation seklinde degisken tanimlama yapildi.
        private int _pageNumber; // // Burada encapsulation seklinde degisken tanimlama yapildi.
        private string _publisherName; // // Burada encapsulation seklinde degisken tanimlama yapildi.
        private DateTime _signTime; // // Burada encapsulation seklinde degisken tanimlama yapildi.

        public Kitap() // Burada CTOR yani parametresiz bir constructor olusturuldu. Temel mantik bir Kitap classi icin nesne olusturuldugunda buraya otomatik olarak ugrayacak ve altinda yapmis oldugun datetime degerini en olursa olsun alacak.
        {
            _signTime = DateTime.Now;
        }
        public Kitap(string bookName, string writerName, int pageNumber, string publisher)// Burada parametre alan bir ctor  constructor tanimlanmistir. Burada kisiden kitap adi, yazar adi, kitap sayfasi ve kitap yayinevini bekledigimizi belirtiyoruz. Burada bir override islemi de oluyor.
        {
            _bookName = bookName; // Burada _bookName seklinde private olarak tanimladigimiz degiskenleri public olarak eristigimiz Kitap nesnesinin propertieslerine eristiriyoruz ve atama yapiyoruz..
            _writerName = writerName;
            _pageNumber = pageNumber;
            _publisherName = publisher;
            _signTime= DateTime.Now;
        }

        public string Name // Burasi Kitap sinifi altinda olusturulacak nesnelerinin propertieslerini olusturuyoruz..
        {
            get
                {
                    return  _bookName; // Burada herhangi bir sekilde Name propertiesin kullanilmasi durumunda okunacak deger _bookName degeri olacaktir.
                }
            set
                {
                    _bookName = value; // Burada kullanicinin yazmis oldugu deger _bookName degerine islenecektir.
                }
        }
        public string WriterName
        {
            get { return _writerName; }
            set { _writerName = value; }
        }
        public string WriterSurname
        {
            get
            {
                return _writerSurname;
            }
            set
            {
                _writerSurname = value;
            }

        }
        public int PageNumber
        {
            get { return _pageNumber; }
            set { _pageNumber = value; }
        }
        public string PublisherName
        {
            get { return _publisherName; }
            set { _publisherName = value; }
        }
        public DateTime SignTime
        {
            get { return _signTime; }
            set { _signTime = Convert.ToDateTime(value); }
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4EndTask.Abstract
{
    internal  abstract class BaseMakine
    {
        private DateTime _uretimTarihi; // field tanimlamalari
        private string _seriNumarasi;
        private string _name;
        private string _aciklama;
        private string _isletimSistemi;

        public BaseMakine() // ctor tanimlamasi
        {
            _uretimTarihi = DateTime.Now;
        }

        public DateTime UretimTarihi // properties tanimlamasi
        {
            get => _uretimTarihi; // => tanimlamasi return ifadesinin .NET8.0 daki esitidir.
            
        }
        public string SeriNumarasi // properties tanimlamasi
        {
            get { return _seriNumarasi; }
            set { _seriNumarasi = value; }
        }

        public string Name // properties tanimlamasi
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Aciklama // properties tanimlamasi
        {
            get { return _aciklama; }
            set{_aciklama = value;}
        }
        public string IsletimSistemi // properties tanimlamasi
        {
            get { return _isletimSistemi; }
            set { _isletimSistemi = value; }
        }

        public abstract void BilgileriYazdir(); // Method soyut olarak tanimlanmistir. Burada bir sey yazmanin mantigi yoktur. Method classlarda ezilecektir.
        public  virtual void UrunAdiGetir(string name) // Bu metotla sadece properties'e field atamasi yapiyorum....
        {
            Name = name;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Week4EndTask.Abstract;

namespace Week4EndTask.Concerete
{
    internal class Bilgisayar : BaseMakine
    {
        private int _usbGirisSayisi;
        private bool _isBluetooth;

        public int UsbGirisSayisi
        {
            get { return _usbGirisSayisi; }
            set
            {
                try // hata ayiklama mantigi kullanilmistir.
                {
                    if (Convert.ToInt32(value) != 2 && Convert.ToInt32(value) != 4)
                    {
                        Console.WriteLine("Yanlis deger girildi. Lutfen 2 veyahut 4 degerlerini secebilirsiniz....");
                        _usbGirisSayisi = -1;
                    }
                    else
                    {
                        _usbGirisSayisi = value;
                    }
                }
                catch (FormatException)
                {

                    Console.WriteLine("Lutfen gecerli bir sayi giriniz.");
                    _usbGirisSayisi = -1;
                }
            }
        }
        public bool IsBluetooth
        {
            get => _isBluetooth;
            set => _isBluetooth = value;
        }
        public override void BilgileriYazdir()
        {
            Console.WriteLine($"""
            Bilgisayarinizin ozellikleri
            ---------------------------------------
            Bilgisayarinizin Uretim Tarihi: {UretimTarihi:dd/MM/yyyy}
            Bilgisayarinizin Seri Numarasi: {SeriNumarasi}
            Bilgisayarinizin Adi: {Name}
            Bilgisayarinizin Isletim Sistemi: {IsletimSistemi}
            Bilgisayarinizin Usb Giris Sayisi: {UsbGirisSayisi}
            Bilgisayarinizin Bluetooth Ozelligi: {(IsBluetooth ? "Var" : "Yok")}
            """);
        }
        public override void UrunAdiGetir(string name)
        {
            Console.WriteLine($"Bilgisayarinizin adi : {name}");
        }
        public void IsBluetoothDurumBelirleme(string bluetoothDurumBelirleme)
        {
            IsBluetooth = bluetoothDurumBelirleme.ToLower()
            switch
            {
               "e" => true,
               "h" => false,
               _ => throw new ArgumentException("Gecerli bir secenek giriniz (E/H)"),
            };
        }
    }
}

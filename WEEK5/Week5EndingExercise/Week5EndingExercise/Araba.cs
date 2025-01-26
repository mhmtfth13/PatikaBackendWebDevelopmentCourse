public class Araba
{
    // Private alanlar - Araba ozellikleri tanimlanir
    private DateTime _productionTime;
    private string? _serialNumber;    // Null deger alabilir
    private string? _marka;           // Null deger alabilir
    private string? _model;           // Null deger alabilir
    private string? _renk;            // Null deger alabilir
    private int _doorNumber;

    // Constructor - Nesne olusturuldugunda ilk calisir
    public Araba()
    {
        _productionTime = DateTime.Now;    // Uretim zamani otomatik atanir
        _doorNumber = 4;                   // Varsayilan kapi sayisi
    }

    // Property'ler - Dis erisim icin kullanilir
    public DateTime ProductionTime => _productionTime;    // Sadece okunabilir

    public string? SerialNumber    // Seri no property
    {
        get => _serialNumber;
        set => _serialNumber = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string? Marka    // Marka property
    {
        get => _marka;
        set => _marka = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string? Model    // Model property
    {
        get => _model;
        set => _model = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string? Renk    // Renk property
    {
        get => _renk;
        set => _renk = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int DoorNumber    // Kapi sayisi property
    {
        get => _doorNumber;
        set
        {
            try
            {
                if (value != 2 && value != 4)    // 2 veya 4 kontrolu
                {
                    _doorNumber = 4;    // Gecersiz deger icin varsayilan atama
                    Console.WriteLine("Gecersiz kapi sayisi. Otomatik olarak 4 kapi atandi.");
                }
                else
                {
                    _doorNumber = value;
                }
            }
            catch (FormatException)
            {
                throw new FormatException("Lutfen sayisal bir deger giriniz!");
            }
        }
    }
}
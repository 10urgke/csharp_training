/*
string UserName = Console.ReadLine();
string Password = Console.ReadLine();

if (UserName == "Admin")
{
    if (Password == "Onur123")
    {
        Console.WriteLine("Kullanıcı adı ve parola doğru.");
    }
    else
    {
        Console.WriteLine("Parola yanlış");
    }

}
else
{
    Console.WriteLine("Kullanıcı adı yanlış.");
}

string password = "";
Console.WriteLine("Parolanızı Giriniz");
while (true)
{
    ConsoleKeyInfo passwordChar = Console.ReadKey(true);
    Console.Write("*");
    if (passwordChar.Key == ConsoleKey.Enter)
    {
        break;
    }
    password += passwordChar.KeyChar;

}

Console.WriteLine($"\nSifreniz: {password}");

if (password == password)
{
    Console.WriteLine("Parola doğru.");
    
}
else
{
    Console.WriteLine("parola yanlış.");
}




string[] brands = new string[3];
brands[0] = "BMW";
brands[1] = "AUDI";
brands[2] = "MERCEDES";

List<Invoice> invoiceList = new List<Invoice>();

while (true)
{
    Invoice invoice = new Invoice();
    Console.Write("Lütfen Adınızı Gİriniz:");
    string name = Console.ReadLine();
    invoice.Name = name;
    Console.Write("Lütfen Soyadınızı Girniz: ");
    string surname = Console.ReadLine();
    invoice.Surname = surname;
    Console.Write("Lütfen Yaşınızı Giriniz: ");
    int age = int.Parse(Console.ReadLine());
    invoice.Age = age;
    Console.Write("Lütfen Arac Markasını Giriniz (BMW,MERCEDES,AUDI); ");
    string brand = Console.ReadLine();
    int price = 0;
    if (brand == brands[0]) // BMW
    {
        price = 200000;
        invoice.Brand = brands[0];
    } else if (brand == brands[1])
    {
        price = 110000;
        invoice.Brand = brands[1];
    } else if (brand == brands[2])
    {
        price = 120000;
        invoice.Brand = brands[2];
    }
    else
    {
        invoice = null;
        break;
    }
    invoice.Price = price;

    Console.WriteLine($"Secilen arabanın ücreti: {price} $");


    Console.WriteLine("Yeni Bir Kayıt Eklemek İstiyor Musunuz ?");
    Console.WriteLine("Hayır İse ESC ye bas EVET ise ENTER a basınız");
    var input = Console.ReadKey();
    invoiceList.Add(invoice);

    if (input.Key == ConsoleKey.Backspace)
    {
        break;
    }
    if (input.Key == ConsoleKey.Enter)
    {
        continue;
    }
}


InvoicePrinter printer = new InvoicePrinter();

printer.Print(invoiceList);


public class InvoicePrinter
{
    public void Print(List<Invoice> invoiceList)
    {
        Console.WriteLine("AD | SOYAD | YAŞ | MARKA | ÜCRET");
        Console.WriteLine("--------------------------------");

        int size = 1;
        foreach (var invoice in invoiceList)
        {
            Console.WriteLine($" {size} - {invoice.Name} | {invoice.Surname} | {invoice.Age} | {invoice.Brand} | {invoice.Price}");
            size++;
        }


    }
}




public class Invoice
{
    private int _age;
    private string _name;
    public Invoice()
    {
        Console.WriteLine("Invoice Olusturuldu.");
    }

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            this._name = value;
        }
    }

    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            if (value < 18)
            {
                Console.WriteLine("18 yasından kucuksun, araba kullanmamalısın");
            }

            this._age = value;

        }
    }

    public string Surname;
    public int Price { get; set; }
    public string Brand { get; set; }
    
} 


namespace PolymorphismApp
{
    class Animal
    {
        
        protected string name, sound, info, mark = new string ('-',6);
        public string getInfo
        {
            get { return info; }
        }
        
        
        public Animal()
        {
            this.name = null;
            this.sound = null;
            this.info = null;
        }
        public Animal (String name, String sound)
        {
            this.name = name;
            this.sound = sound;
            this.info = null;
        }
        public Animal (String name, String sound, String info)
        {
            this.name = name;
            this.sound = sound;
            this.info = info;
        }
        
        public void infoText()
        {
            Console.WriteLine("{0}\n < Hayvan Kimliği >\n{1}\n-> Türüm: {2}\n-> İsmim: {3}\n-> Çıkardığım Ses: {4}\n{5}",mark,mark, info,name,sound,mark);
        }
    }
}
namespace PolymorphismApp
{
    class Cat : Animal
    {
        public Cat(String name)
        {
            this.name = name;
            this.sound = "Miyav Miyav";
            this.info = "Kedi";
        }
        public Cat (String name, String info)
        {
            this.name = name;
            this.sound = "Miyav Miyav";
            this.info = info;
        }
    }
}
namespace PolymorphismApp
{
    class Dog : Animal
    {
        public Dog(String name)
        {
            this.name = name;
            this.sound = "Hav Hav";
            this.info = "Köpek";
        }
        public Dog (String name, String info)
        {
            this.name = name;
            this.info = info;
            this.sound = "Hav Hav";
        }
    }
}

using System;
namespace ProjeAdi
{
    class Personel
    {
      
        string isim, soyisim,unvan=null;
        double maas;
        int izinGunu;
        string ayrac = new string ('-',20);
        
        public void setPersonelBilgileri(string isim,string soyisim,double maas)
        {
            if(isim.Length>0 && soyisim.Length > 0)
            {
                if (maas >= 2500)
                {
                    this.isim = isim;
                    this.soyisim = soyisim;
                    this.maas = maas;
                    this.izinGunu = 14;
                    if (maas >= 3000 && maas <= 4000)
                    {
                        this.unvan = "Kıdemli Personel";
                        this.izinGunu = 20;
                    } 
                    else if (maas >= 4001 && maas <= 5500)
                    {
                        this.unvan = "Kıdemli + Personel";
                        this.izinGunu = 24;
                    }
                    else if (maas > 5500)
                    {
                        this.unvan = "Uzman Personel";
                        this.izinGunu = 30;
                    }
                        
                    else
                        this.unvan = "Personel";
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("{0}\n<Personel Oluşturulamadı>\n{1}\n-> İşletme içerisinde bir personelin en az 2500 TL maaşı olması gerekmektedir.\n{2}",ayrac,ayrac,ayrac);
                }
            }
        }
        public string getPersonelBilgileri()
        {
            if (unvan != null)
                return ayrac + "\n<Personel Oluşturuldu>\n" + ayrac + "\n-> Personel İsmi: " + isim + "\n-> Personel Soyismi: " + soyisim + "\n-> Personel Maaşı: " + maas + " TL\n-> Personel Ünvanı: " + unvan + "\n-> Personel İzin Günü: " + izinGunu + " Gün\n" + ayrac;
            else
                return ayrac + "\n<Personel Oluşturmanız Gerekiyor>\n" + ayrac + "\n-> Personel bilgililerine erişilemiyor. Lütfen önce bir personel oluşturun.\n" + ayrac;
        }
    }
}

using System;

namespace PolymorphismApplication {
    class Şekil{
        protected int width, height;
      
        public Şekil( int a = 0, int b = 0) {
            width = a;
            height = b;
        }
        public virtual int area() {
            Console.WriteLine("Parent class area :");
            return 0;
        }

       
        
    }
    class Dikdörtgen: Şekil {
        public Dikdörtgen( int a = 0, int b = 0): base(a, b) {

        }
        public override int area () {
            Console.WriteLine("Dikdörgen ");
            return (width * height); 
        }

       
    }
    class Ucgen: Şekil {
        public Ucgen(int a = 0, int b = 0): base(a, b) {
        }
        public override int area() {
            Console.WriteLine("Üçgen ");
            return (width * height / 2); 
        }
    }
    class Caller {
        public void CallArea(Şekil sh) {
            int a;
            a = sh.area();
            Console.WriteLine("Alanı: {0}", a);
        }
    }  
    class Tester {
        static void Main(string[] args) {
            Caller c = new Caller();
            Dikdörtgen r = new Dikdörtgen(10, 7);
            Ucgen t = new Ucgen(10, 5);
         
            c.CallArea(r);
            c.CallArea(t);
            Console.ReadKey();
        }
    }
}
*/


























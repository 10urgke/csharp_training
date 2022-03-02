/*
bool onurAdamdır = false;
int onurYas = 26;

if (onurYas >= 25 && onurAdamdır )  
{
    Console.WriteLine("Askere Gidebilirsin");
}
else {
Console.WriteLine("Askere Gidemezsiniz");
    
}

int jobPrice = 1000;
int total = 0;

// for (dongu sırası değeri; dongu kosulu; dongu artıs degeri

for(int i= 1; i <= 100; i++ (+= 1 de olabilir ))
{
    Console.WriteLine($"total önceki değeri: {total}");
    total = total + jobPrice;
    
    Console.WriteLine($"total önceki değeri: {total}");
}



for (int i = 100; i >= 1; i--)
   
{
    if (i%2 == 0)
    {
        Console.WriteLine($"Sayı Cift {i}");
    }
    else
    {
        Console.WriteLine($"Sayı Tektir {i}");
    }
    
}
int totalCiftSayı = 0;
int totalTekSayı = 0;


for (int i = 100; i >= 1; i--)
   
{
    if (i%2 == 0)
    {
        Console.WriteLine($"Sayı Cift {i}");
        totalCiftSayı = totalCiftSayı + i;
    }
    else
    {
        Console.WriteLine($"Sayı Tektir {i}");
        totalTekSayı = totalTekSayı + i;
    }
    
}
Console.WriteLine($"Cift Sayı Toplamı : {totalCiftSayı}");
Console.WriteLine($"Tek Sayı Toplamı : {totalTekSayı}" );
    
bool isMan = false;
int age = 20;

if (isMan && age==20)
{
    Console.WriteLine("1");
}
else if (isMan && age==21)
{
    Console.WriteLine("2");
}
else if (!isMan && age==20)
{
    Console.WriteLine("3");
}
else
{
    Console.WriteLine("olmadı");
}

//while (koşul belirt)
while (true)
{
    Console.WriteLine("while icerisi");
}
int deger = 0;
while (deger < 100)
{
    Console.WriteLine($"Deger {deger}");
    deger++;
}
//break=döngüden çık,kır demek.



int zaman = DateTime.Now.Second;
zaman += 10;
int count = 0;
while (DateTime.Now.Second <= zaman)
{
 Console.WriteLine($"Sistem Zamanı {DateTime.Now}");
 count++;
 if (count > 100000)
 {
     Console.WriteLine("Bu kadar da olmaz be");
     break;
     
 }
}
Console.WriteLine($"Döngü sonu {count}");

int islem = 1;
switch (islem)
{
    case 1:
        Console.WriteLine("1 nolu işlem yapıldı.");
        break;
    case 2:
        Console.WriteLine("2 nolu işlem yapıldı.");
        break;
    default:
        Console.WriteLine("default");
        break;
}
 

// string tipinde array tanımlaması, içerisinde x adet değer tutabilir x=; herhangi bir sayı olabilir.
string[] names = new string[10];
int[] sayılar = new int[10];
char[] karakterler = new char[10];
float[] ondalıklıSayılar = new float[10];
names[0] = "Onur11";
names[1] = "Onur2321231";
names[2] = "Onur3323232";
names[3] = "Onur4231";
names[4] = "Onur523";
names[5] = "Onur623";



for (int i = 0; i <= names.Length-1; i++)
{
    Console.WriteLine(names[i]);
}


//DAY2


//METHODLAR

////erişim belirteci(access modifiers), dondurdugu deger tipi(return type) isimi(names) () {}
//ERİŞİM BELİRTEÇ TİPLERİ= public,private,protected
//DEĞER TİPLERİ=
//Değişken türleri:  "int", "long", "float", "double", "decimal", "char", "bool", "byte", "short", "struct", "enum"
//Referans türleri:  "string", "object", "class", "interface", "array", "delegate", "pointer"
//Değer döndürmeyebilir(void) yada döndürebilir(hangi tipte değer istiyorsa o tip).
//DEĞER İSMİ=Herhangi bir isim değişken atama.
//public heryerden görülebilir.
//protected özel bir grup
//private grubun içindeki özel bir kişi


OnurSınıfı onur = new OnurSınıfı();

onur.Yas();
onur.Onur();
Console.WriteLine("Yaşınız nedir?");
//onur.IsOld(20,"fatih",false, false);
//onur.IsOld(10,"onur", true, true);
//onur.IsOld(19,"emre", true, false);

string ageStr = Console.ReadLine();
int age = Convert.ToInt16(ageStr);
string isManStr = Console.ReadLine();
bool isMan = Convert.ToBoolean(isManStr);
int[] arr = new int[10];
onur.IsOld(age,"onur", isMan, false, arr);
Console.WriteLine(onur.Onur2());
Console.WriteLine(onur.Yas());





public class OnurSınıfı
{
 
    public void Onur()
    {
        int a = 5;
        Console.WriteLine("Onur Aramıza Katıldı");
        // Email atmak istiyorum
  
    }

    public string Onur2()
    {
        char karakter = GetNamesFirstChar();
        return "Onur2" + "\t" + karakter;
    }

    public int Yas()
    {
        int onurYası = 20;
        return 20;
    }

    private char GetNamesFirstChar()
    {
        return 'o';
    }

    public void IsOld(int age, string name, bool isMan, bool isStudent, int[] yasArrayı)
    {

        for (int i = 0; i < yasArrayı.Length - 1; i++)
        {
            Console.WriteLine("Merhaba");
        }
  
        if (isMan)
        {
            Console.WriteLine("Erkeksin");
        }
        else
        {
            Console.WriteLine("Kadınsın");
        }

        if (isStudent)
        {
            Console.WriteLine("Ogrencisin");
        }
        else
        {
            Console.WriteLine("Ogrenci Degilsin");
        }
        if (age >= 20)
        {
            Console.WriteLine($"Yaslısın {name}");
        }
        else
        {
            Console.WriteLine($"Gencsin {name}");
        }
    }
}




//DAY 3

//CLASS KAVRAMI

namespace Console1;
public class Person
{
    // access modifier, class name (parametre gir veya girme){}
    public Person(string outName)
    {
        name = outName;
    }
    // property
    // access modifier, type, property name ;
    public string name;
    public string surname;
    public int age;
    public int length;
    public string LiveIn;
    public void SayName()
    {
        int index = 0;
        while (index < 10)
        {
            Console.WriteLine($"Hello, My Name Is {name}");
            index++;
        }
    }
    public void SayInfo()
    {
        Console.WriteLine($"Hello, My Name Is {name}, My Age: {age}");
    }
}
*/
 /*
public class car

{
    
    public string Marka;
    public string Model;
    public int MaxSpeed;
    public int Price;
    public int Mesafe;
    
   
    public void SpeedLimit()
    {
        Console.WriteLine($"Hızınız şu an: {MaxSpeed}");
        if (MaxSpeed >= 200)
        {
            Console.WriteLine("Hız limitini aştınız!!!");
        }
        else
        {
            Console.WriteLine("Hızınız şu an sınırın altında.");
        }

        
        
        
        Console.WriteLine("Arabanız kaç yıllık?");
        string ageStr = Console.ReadLine();
        int age = Convert.ToInt16(ageStr);
        if (age >= 20)
        {
            Console.WriteLine("Arabanın yenilenmesi lazım.");
        }
        else
        {
            Console.WriteLine("Araban yeni.");
        }

        
        
        
        
        
        
    }

    public void Info()
    {

        Console.WriteLine($"Araba markanız: {Marka}, Modeliniz: {Model}, Maksimum hız sınırınız: {MaxSpeed}, Arabanın fiyatı: {Price}$," );

        
        
        
    }

    public void Saat()
    {
        float clock = (float) Mesafe / MaxSpeed;
        Console.WriteLine($"Adana-İstanbul arasını {MaxSpeed}km/h hızla {clock} saatte varacaksınız.");


        



    }

    public void İnput()
    {

        Console.WriteLine("Bilgilerinizi Giriniz.");
        Thread.Sleep(2000);
        Console.WriteLine("Ad:");
        string Name = Console.ReadLine();
        Thread.Sleep(1000);
        Console.WriteLine("Soyad:");
        string Surname = Console.ReadLine();
        Thread.Sleep(1000);
        Console.WriteLine("Yaş:");
        string ageStr = Console.ReadLine();
        int age = Convert.ToInt16(ageStr);
        Thread.Sleep(2000);

        Console.WriteLine("FATURANIZ Yükleniyor:");
        Thread.Sleep(3000);
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("FATURANIZ:");
        Console.WriteLine("");
        Console.WriteLine("");

       
        
       
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
       
    Console.ForegroundColor = ConsoleColor.DarkCyan;
       Console.WriteLine("-----------------------------------------");
       Console.WriteLine("|       |                               |");
       Console.WriteLine("|       |                               |");
       Console.WriteLine("-----------------------------------------");
       Console.WriteLine($"Ad      |       {Name}                    |");
       Console.WriteLine("-----------------------------------------");
       Console.WriteLine("|       |                               |");
       Console.WriteLine("|       |                               |");
       Console.WriteLine("-----------------------------------------");
       Console.WriteLine($"Soyad   |       {Surname}                   |");
       Console.WriteLine("-----------------------------------------");
       Console.WriteLine("|       |                               |");
       Console.WriteLine("|       |                               |");
       Console.WriteLine("-----------------------------------------");
       Console.WriteLine($"Yaş     |       {age}                      |");
       Console.WriteLine("-----------------------------------------");
       Console.WriteLine("|       |                               |");
       Console.WriteLine("|       |                               |");
       Console.WriteLine("-----------------------------------------");
       Console.WriteLine($"Marka   |       {Marka}                     |");
       Console.WriteLine("-----------------------------------------");
       Console.WriteLine("|       |                               |");
       Console.WriteLine("|       |                               |");
       Console.WriteLine("-----------------------------------------");
       Console.WriteLine($"Model   |       {Model}                     |");
       Console.WriteLine("-----------------------------------------");
       Console.WriteLine("|       |                               |");
       Console.WriteLine("|       |                               |");
       Console.WriteLine("-----------------------------------------");
       Console.WriteLine($"Max Hız |       {MaxSpeed}                     |");
       Console.WriteLine("-----------------------------------------");
       Console.WriteLine("-----------------------------------------");
       Console.WriteLine("|Araba Satın Alındı Fatura No:1832890132|");
       Console.WriteLine("-----------------------------------------");
     

using System.Security.Cryptography;

List<Invoice> invoices = new List<Invoice>();
Invoice invoice;
int bmwPrice = 200000;
int audiPrice = 300000;
int mercedesPrice = 400000;
while (true)
{
    invoice = new Invoice();
    Console.WriteLine("Ad");
    string name = Console.ReadLine();
    invoice.Name = name;
    Console.WriteLine("Soyad");
    string surname = Console.ReadLine();
    invoice.Surname = surname;
    Console.WriteLine("Yaş");
    string ageStr = Console.ReadLine();
    int age = int.Parse(ageStr);
    invoice.Age = age;
    Console.WriteLine("Almak istediğiniz marka ( Lütfen BMW(1),MERCEDES(2),AUDI(3) )'den birisini seçip yazınız.");
    
    string MarkaStr = Console.ReadLine();
    int Marka = Convert.ToInt16(MarkaStr);
    
    if (Marka == 1 ) 
    {
        Console.WriteLine($"Almak istediğiniz araç BMW FİYATI İSE {bmwPrice}$ ");
        invoice.Brand = "BMW";
        invoice.Price = bmwPrice;
    } else if (Marka == 2)
    {
        Console.WriteLine($"Almak istediğiniz araç MERCEDES FİYATI İSE {mercedesPrice}$");
        invoice.Brand = "Mercedes";
        invoice.Price = mercedesPrice;
    } else if (Marka == 3)
    {
        Console.WriteLine($"Almak istediğiniz araç AUDİ FİYATI İSE {audiPrice}$");
        invoice.Brand = "Audi";
        invoice.Price = audiPrice;
    }
    else
    {
        Console.WriteLine("ADam Akıllı Marka sec!");
        invoice = null;
        break;
    }
}

PrintColumNames();

foreach (var invoice1 in invoices)
{
    
}

void PrintColumNames()
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("________________________________________");
    Console.WriteLine("Ad   | Soyad  | Yaş  | Marka  |  Fiyat  ");
    Console.WriteLine("________________________________________");
}

void PrintRows(Invoice invoice)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"{invoice.Name}   | {invoice.Surname}  | {invoice.Age}  | {invoice.Brand}  |  {invoice.Price}  ");
    Console.WriteLine("________________________________________");

}

class Invoice
{
    public string Name;
    public string Surname;
    public int Age;
    public string Brand;
    public int Price;


using System;
using System.Collections.Generic;
using System.Text;
 
namespace ConsoleApplication1
{
    public interface Iislemler
    {
        void islemgoster();
        double tutargetir();
    }
    public class IslemNo : Iislemler
    {
        private string islemkodu;
        private string Tarih;
        private double Tutar;
        public IslemNo()
        {
            islemkodu = " ";
            Tarih = " ";
            Tutar = 0.0;
        }
        public IslemNo(string c, string d, double a)
        {
            islemkodu = c;
            Tarih = d;
            Tutar = a;
        }
        public double tutargetir()
        {
            return Tutar;
        }
        public void islemgoster()
        {
            Console.WriteLine("İşlem No: {0}", islemkodu);
            Console.WriteLine("Tarih: {0}", Tarih);
            Console.WriteLine("Tutar: {0}", tutargetir());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IslemNo islem1 = new IslemNo("001", "8/10/2012", 78900.00);
            IslemNo islem2 = new IslemNo();//www.bilisimogretmeni.com
            IslemNo islem3 = new IslemNo("002", "9/10/2012", 451900.00);
            islem1.islemgoster();
            islem2.islemgoster();
            islem3.islemgoster();
            Console.ReadKey();
        }
    }
}}  
using System;

namespace MyApplication
{
   
    interface IAnimal 
    {
        void animalSound(); 
    }

 
    class Dog : IAnimal 
    {
        public void animalSound() 
        {
            
            Console.WriteLine("Köpek sesi: Hav Hav");
        }
    }

    class Program 
    {
        static void Main(string[] args) 
        {
            Dog myDog = new Dog();  
            myDog.animalSound();
        }
    }
}*/ 
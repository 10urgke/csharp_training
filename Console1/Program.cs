
// See https://aka.ms/new-console-template for more information
/*
 using Console1.Exam
Console.WriteLine("Hello, World!");
bool= true,false
long = çok büyük sayılar 
int= 1,0,-1
float= 1.2,1.5,-1.6
string = "TR6231312, bxjzckhjaskd?"
char= '3',a,b,?
int intDeger = 1000;
int eksiDeger = -1000;

bool(var da olabilir) değişken = true&false
değişken=true
!değişken=false
&&=ve
||=veya
=< = küçük eşit sorgusu
== = eşitlik sorgusu
!= = eşitsizlik sorgusu
> = büyük sorgusu
< = küçük sorgusu 
=> = büyük eşit sorgusu
% = mod almak (bölümün kalanı bulmak denilebilir)
for(int i: 1; i <= 10; i++)
{

}



using Console1;
using Console1.Examples;


Ornek2 ornek2 = new Ornek2();

ornek2.Ornek2Method();
Example1 example1 = new Example1();

using Console1;
Person emre = new Person("Emre");
emre.age = 24;
emre.length = 160;
emre.surname = "Baykusak";
emre.LiveIn = "Istanbul";
emre.SayName();
emre.SayInfo();
Person onurPerson = new Person("cumali");
Console.WriteLine(onurPerson.name);


car mercedes = new car();
mercedes.Marka = "Bmw";
mercedes.Model = "e30";
mercedes.Price = 200000;
mercedes.MaxSpeed = Random.Shared.Next(100,400);
mercedes.Mesafe = 775;


mercedes.SpeedLimit();
mercedes.Info();
mercedes.Saat();
mercedes.İnput();


namespace PolymorphismApp
{
 class Program
 {
  static void Main(string[] args)
  {
   
   Animal dog = new Dog("Karabaş","Kangal");
   Animal cat = new Cat("Mutlu", "Tekir");
   
   dog.infoText();
   Console.WriteLine("");
   cat.infoText(); 
  }
 }
}


using System;
namespace ProjeAdi
{
 class PersonalInformation
 {
  static void Main (string[] args)
  {
   
   
   
   Personel onur = new Personel();
   Personel enes = new Personel();
   Personel mustafa = new Personel();
   Personel omer = new Personel(); 
   
   onur.setPersonelBilgileri(isim:"Onur", "Gökçe", 2500);
   enes.setPersonelBilgileri("Mustafa Enes", "Barut", 3750);
   mustafa.setPersonelBilgileri("Mustafa", "Yenice", 7000);
  
   Console.WriteLine(onur.getPersonelBilgileri());
   Console.WriteLine(enes.getPersonelBilgileri());
   Console.WriteLine(mustafa.getPersonelBilgileri());
   Console.WriteLine(omer.getPersonelBilgileri());
  }
 }
}

using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApplication2
{
 public interface IArabaSur
 {
  void Calistir();
  void Sur();
  void Parket();
  void VitesDegistir(int vites);
  void Durdur();

  public class Araba : IArabaSur
  {
   public void Calistir()
   {
    Console.WriteLine("Araba Çalıştırıldı.. Haydi Bismillah ");
   }

   public void Sur()
   {
    Console.WriteLine("Fazla Hız Yapmadan Sürmeye Devam");
   }

   public void Parket()
   {
    Console.WriteLine("Park Etme İşlemi Yapılıyor Dikkat Edin");
   }

   public void VitesDegistir(int vites)
   {
    Console.WriteLine(vites.ToString() + " . vitese geçildi hızını ona göre ayarla ");
   }

   //www.bilisimogretmeni.com
   public void Durdur()
   {
    Console.WriteLine("Okula geldik : ) hadi geçmiş olsun....");
   }
  }

  class Program
  {
   static void Main(string[] args)
   {
    Araba ford = new Araba();
    ford.Calistir();
    ford.VitesDegistir(2);
    ford.Sur();
    ford.Parket();
    ford.Durdur();
    Console.ReadKey();
   }
  }
 };


using System;
namespace CsharpInterface {

 interface IPolygon {
 
  void calculateArea();

 }   
 
 class Rectangle : IPolygon {

  
  public void calculateArea() {
   
   int l = 30;
   int b = 90;
   int area = l * b;
   Console.WriteLine("Area of Rectangle: " + area);
  }
 } 

 class Square : IPolygon {

 
  public void calculateArea() {

   int l = 30;
   int area = l * l;
   Console.WriteLine("Area of Square: " + area);
  }
 }
 
 class Program {
  static void Main (string [] args) {

   Rectangle r1 = new Rectangle();  
   r1.calculateArea();

   Square s1 = new Square();  
   s1.calculateArea();
  }
 }
}
 */





















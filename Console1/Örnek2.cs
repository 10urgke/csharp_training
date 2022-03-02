/*
namespace Console1
{

    public class Ornek2
    {

        public void Ornek2Method()
        {
            
string kareDikdortgen = "", alanCevre = "";
int a, b, cevre, alan;
Console.WriteLine("1- Kare");
Console.WriteLine("2- Diktörtgen");
Console.Write("Seçiminiz (1-2) : ");
kareDikdortgen = Console.ReadLine();
if (kareDikdortgen == "1") {
 Console.WriteLine("1- Alan");
 Console.WriteLine("2- Çevre");
 Console.Write("Seçiminiz (1-2) : ");
 alanCevre = Console.ReadLine();
 if (alanCevre == "1") {
  Console.Write("Kenarı giriniz = ");
  a = int.Parse(Console.ReadLine());
  alan = a * a;
  Console.WriteLine("Alan = {0}", alan);
 }
 if (alanCevre == "2")
 {
  Console.Write("Kenarı giriniz = ");
  a = int.Parse(Console.ReadLine()); cevre = 4 * a; Console.WriteLine("Çevre={0}", cevre);
 } }
if (kareDikdortgen == "2") {
 Console.WriteLine("1- Alan");
 Console.WriteLine("2- Çevre");
 Console.Write("Seçiminiz (1-2) : ");
 alanCevre = Console.ReadLine();
 if (alanCevre == "1") {
  Console.Write("Uzun kenarı giriniz = ");
  a = int.Parse(Console.ReadLine());
  Console.Write("Kısa kenarı giriniz = ");
  b = int.Parse(Console.ReadLine());
  alan = a * b;
  Console.WriteLine("Alan = {0}", alan);
 }
 if (alanCevre == "2")
 {
  Console.Write("Uzun kenarı giriniz = "); 
  a = int.Parse(Console.ReadLine()); 
  Console.Write("Kısa kenarı giriniz = "); 
  b = int.Parse(Console.ReadLine()); 
  cevre = 2 * (a + b); Console.WriteLine("Çevre = {0}", cevre);
 } 
}
        }
    }
}
*/
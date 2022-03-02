/*
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

foreach (var inv in invoices)
{
    PrintRows(inv);
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
}
*/





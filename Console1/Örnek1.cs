
namespace Console1;

public class Program
{
    public static void Main(string[] args)
    {
        int parkSaati = 0;
        int ucret = 0;
        Console.Write("Park süresini girin.");
        parkSaati = Convert.ToInt32(Console.ReadLine());
        if (parkSaati < 3)
            ucret = parkSaati * 4;
        else if (parkSaati > 3 && parkSaati < 7)
            ucret = parkSaati * 3;
        else if (parkSaati >= 7 && parkSaati < 12)
            ucret = parkSaati * 2;
        else if (parkSaati >= 12)
            ucret = parkSaati * 1;
        Console.Write("Ödenecek Toplam Park Ücreti = {0}.", ucret);
    }
}


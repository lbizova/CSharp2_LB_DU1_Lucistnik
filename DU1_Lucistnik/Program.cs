using System.Globalization;
using System.Runtime.InteropServices;

namespace DU1_Lucistnik;

class Program
{
    static void Main(string[] args)
    {
        //1x lučištník pomocí konstruktoru z třídy Lučištník 
        Lucistnik william = new Lucistnik("William", 25);
        //Console.WriteLine ($"Lučištník {william.Name} má v toulci {william.NumberOfArrows} šípů. "); //1. test
        william.DisplayStatus(); //aktuální stav šípů pomocí metody DisplayStatus
        //textové menu pro uživatele:
        Console.WriteLine ("Lučistníku přeješ si : ");
        Console.WriteLine ("Vystřelit šíp (stiskni 1) nebo ");
        Console.WriteLine ("Přidat šípy do toulce (stikni 2) nebo ");
        Console.WriteLine ("Ukončit střelbu (stiskni 3). ");
        //čtení vstupu uživatele:
        string input = Console.ReadLine ();
        int number = int.Parse(input);
        switch (number)
        {
            case 1:
                william.ShootAnArrow();
                break;
            case 2:
                william.AddArrows();
                break;
            case 3:
                break;

        }
        //william.DisplayStatus(); //pomocné zobrazení počtu šípů na konci programu
    }
}

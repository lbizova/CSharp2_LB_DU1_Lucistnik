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
        Console.WriteLine ("Lučistníku přeješ si : ");
        Console.WriteLine ("Vystřelit šíp (stiskni 1) nebo ");
        Console.WriteLine ("Přidat šípy do toulce (stikni 2) nebo ");
        Console.WriteLine ("Ukončit střelbu (stiskni 3). ");
        Console.ReadLine ();
    }
}

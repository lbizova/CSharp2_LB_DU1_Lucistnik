using System.Runtime.InteropServices;

namespace DU1_Lucistnik;

class Program
{
    static void Main(string[] args)
    {
        //1x lučištník pomocí konstruktoru z třídy Lučištník 
        Lucistnik william = new Lucistnik("William", 25);
        Console.WriteLine ($"Lučištník {william.Name} má v toulci {william.NumberOfArrows} šípů. ");
    }
}

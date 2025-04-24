using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DU1_Lucistnik
{
    public class Lucistnik
    {
        //vytvoření vlastností jméno a počet šípů
        public string Name 
        {
            get;
            set;
        }
        public int NumberOfArrows 
        {
            get;
            set;
        }
        //konstruktor Lučištník
        public Lucistnik (string name, int numberOfArrows)
        {
            Name = name;
            NumberOfArrows = numberOfArrows;
        }
        //Metoda vystřel
        public void ShootAnArrow ()
        {
            
            if (NumberOfArrows > 0)
            {
                NumberOfArrows -= 1;
                Console.WriteLine ("Úspěšně jsi zasáhl cíl. ");
            }
            else
            {
                Console.WriteLine("!!!Nemáš už žádný šíp!!! ");
            }
        }

        //Metoda Přidej šípy, která přijímá počet šípů k přidání
        public void AddArrows()
        {
            int numberOfAddedArrows = Program.ReadIntFromConsole ("Kolik šípů si přeješ přidat? ");
            NumberOfArrows += numberOfAddedArrows;
            Console.WriteLine($"Přidal jsi {numberOfAddedArrows} a máš tedy celkem {NumberOfArrows}");
            //Console.WriteLine("Kolik šípů si přeješ přidat? ");
           /* int numberOfAddedArrows;
            while (!int.TryParse(Console.ReadLine(), out numberOfAddedArrows))
                Console.WriteLine("Neplatný vstup, zadej celé číslo. ");
            if(numberOfAddedArrows>= 0)
            {
                    NumberOfArrows += numberOfAddedArrows; 
            }
            else
            {
                Console.WriteLine("Nezadali jste kladné číslo, počet šípů se nezměnil.");
            }*/
        }

        //Metoda Zobraz stav
        public void DisplayStatus ()
        {
            Console.WriteLine($"Lučištník {Name}: v toulci má {NumberOfArrows} šípů. ");
        }

    }
}
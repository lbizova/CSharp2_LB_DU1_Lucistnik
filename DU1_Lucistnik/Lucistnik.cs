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
                Console.WriteLine ("Úspěšně jsi zasáhl cíl.");
                }
            else
                {
                Console.WriteLine("!!!Nemáš už žádný šíp!!!");
                }
        }

        //Metoda Přidej šípy
        public void AddArrows()
        {
            NumberOfArrows += 1; //možno v budoucnu doplnit dotaz na počet šípů a přidávat dle zadání uživatele
        }

        //Metoda Zobraz stav
        public void DisplayStatus ()
        {
            Console.WriteLine($"Lučištník {Name}: v toulci má {NumberOfArrows} šípů. ");
        }

    }
}
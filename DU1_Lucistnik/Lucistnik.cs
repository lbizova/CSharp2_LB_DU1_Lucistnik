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
            NumberOfArrows -= 1;
        }

        //Metoda Přidej šípy
        public void AddArrows()
        {
            NumberOfArrows += 1; //možno v budoucnu doplnit dotaz na počet šípů a přidávat dle zadání uživatele
        }

        //Metoda Zobraz stav
        public void DisplayStatus ()
        {
            Console.WriteLine($"V toulci máš {NumberOfArrows} šípů. ");
        }

    }
}
﻿using System.Globalization;
using System.Runtime.InteropServices;

namespace DU1_Lucistnik;

class Program
{
    static void Main(string[] args)
    {
        //1x lučištník pomocí konstruktoru z třídy Lučištník 
        Lucistnik william = new Lucistnik("William", 2);
        //Console.WriteLine ($"Lučištník {william.Name} má v toulci {william.NumberOfArrows} šípů. "); //1. test
        int number = 0;
        while (number != 3)
        {
            william.DisplayStatus(); //aktuální stav šípů pomocí metody DisplayStatus
            //textové menu pro uživatele:
            Console.WriteLine ("Lučistníku přeješ si : ");
            Console.WriteLine ("Vystřelit šíp (stiskni 1) nebo ");
            Console.WriteLine ("Přidat šípy do toulce (stikni 2) nebo ");
            Console.WriteLine ("Ukončit střelbu (stiskni 3). ");
            //čtení vstupu uživatele:
            while (!int.TryParse(Console.ReadLine (),out number))
                Console.WriteLine("!!!Neplatný vstup. Očekává se zadání čísla v rozsahu 1, 2 nebo 3. ");
            switch (number)
            {
                case 1:
                    william.ShootAnArrow();
                    break;
                case 2:
                    int numberOfAddedArrows = ReadIntFromConsole ("Kolik šípů si přeješ přidat? "); //oprava Dú
                    william.AddArrows(numberOfAddedArrows); //oparava Dú2
                    break;
                case 3:
                    break;
                default: 
                    Console.WriteLine ("Očekává se zadání čísla v rozsahu 1, 2 nebo 3. ");
                    break;

            }
        }
        william.DisplayStatus(); //pomocné zobrazení počtu šípů na konci programu
    }

    public static int ReadIntFromConsole(string prompt)
    {     
        int number;
        string input;
        bool isValid;
        do
        {
            Console.WriteLine(prompt);
            input = Console.ReadLine();
            isValid = int.TryParse(input, out number) && number>0;

            if (!isValid)
            {
                Console.WriteLine("Neplatný vstup, zadej celé kladné číslo. ");
            }
        } while (!isValid);
        return number;
        
        /* Jiná funkční varianta
        while(true)
        {
            Console.WriteLine (prompt);
            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number > 0)
                {
                    return number;
                }
            }
            Console.WriteLine("Neplatný vstup, zadej celé kladné číslo. "); 
        }*/

         /* Další funkční varianta 
         while (!int.TryParse(Console.ReadLine(), out number) || number <= 0){
            Console.WriteLine("Neplatný vstup, zadej celé kladné číslo. ");
            }
            return number;*/
        
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Zad._4._2
{
    class zad4
    {
        static void Main(string[] args)
        {
            //Wpisujemy liczby do programu odzielone przecinkiem, jeżeli wpiszemy mniej niż 5 program poprosi ponownie o podanie liczby.

            string[] tablica;
            
            while (true)
            {
                Console.Write("Wpisz liczby odzielając je przecinkiem: ");
                var wpisz = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(wpisz))
                {
                    tablica = wpisz.Split(',');
                    if (tablica.Length > 5)
                    
                        break;
                    
                }
                Console.WriteLine("Za małow spisanych liczb, jeżeli chcesz kontunuować wpisz ,,dalej'' ");
            }
            var liczby = new List<int>();
            foreach (var number in tablica)
                liczby.Add(Convert.ToInt32(number));

            var najm = new List<int>();
            while (najm.Count < 3)  //tą część kodu wzorowałem na Moshu i poprzednich zadaniach z tym że wcześniej największą liczbe prosiło a teraz 3 najmniejsze
            {
                
                var min = liczby[0];
                foreach (var liczba in liczby)
                {
                    if (liczba < min)
                        min = liczba;
                }
                najm.Add(min);

                liczby.Remove(min);
            }

            Console.WriteLine("3 najmniejsze liczby to ");
            foreach (var liczba in najm)
                Console.WriteLine(liczba);

        }    
    }
}

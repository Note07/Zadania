using System;
using System.Collections.Generic;

namespace Zad3._2
{
    class Zad3
    {
        static void Main(string[] args)
        {
            //wprowadzamy 5 liczb które jeśli się powtórzą program zwróci nam uwagę, następnie je posortuje

            var numbers = new List<int>();

            while (numbers.Count < 5) // wykonuję się dopóki nie wpiszemy 5 liczb, w C# numerujemy od 0 dlatego jest < od 5 a nie =5
            {
                Console.Write("Wprowadź 5 liczb:  ");
                var liczba = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(liczba)) //zwraca uwagę jeżeli wpiszemy tę samą liczbe po raz kolejny
                {
                    Console.WriteLine("Już wpisałęś tę liczbe" + liczba);
                    continue;
                }

                numbers.Add(liczba); //dodajemy wpisane liczby do listy
            }

            numbers.Sort(); //metoda je sortuje

            foreach (var number in numbers) //Wypisuje wszystkie liczby
                Console.WriteLine(number);
        }
    }
}

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Zadanie1._2
{
    class Zad1
    {
        static void Main(string[] args)
        {
            //Wpisuje imiona do programu a ten gdy wcisne enter pokazuje mi ile osób polubiło mi post

            var names = new List<string>(); //tworzę liste imion

            while (true)
            {
                Console.WriteLine("Wpisz tyle imion ile chcesz, potem kliknij dwa razy  ENTER");
                var wpisane = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(wpisane)) //bez tego będziemy w kółko wpisywać imiona i nie zobacyzmy rezultatu. ściągnięte od Mosha
                    break;
                names.Add(wpisane);
            }
            if (names.Count > 2)
            {
                Console.WriteLine("{0}, {1} i {2} inni polubili twój post", names[0], names[1], names.Count - 2);
            }
            else if (names.Count == 2)
            {
                Console.WriteLine("{0} i {1} lubią twój post", names[0], names[1]);
            }
            else if (names.Count == 1)
            {
                Console.WriteLine("{0} lubi twój post.", names[0]);
            }
           

        }
    }
}

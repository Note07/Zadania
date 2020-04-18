using System;

namespace Zad2._2
{
    class zad2
    {
        static void Main(string[] args)
        {
            //wpisujesz imię a program pokazuje je od tyłu
            Console.Write("Wpisz swoje imię ");
            var imie = Console.ReadLine();

            var tablica = new char[imie.Length]; //tworzymy tablice

            for (var i = imie.Length; i > 0; i--)  //pętla odejmuje każdą literke od tłu dzięki i--,  .Length mówi nam ile imię ma liter

                tablica[imie.Length - i] = imie[i - 1];

            var odtylu = new string(tablica); 

            Console.WriteLine("Odwrócone imię to " + odtylu);
        }
    }
}

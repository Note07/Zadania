using System;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            //szukanie najwiekszej liczby z wpisanych

            Console.Write("Wpisz liczby odzielając je przecinkami: ");
            var a = Console.ReadLine();

            var liczba = a.Split(','); 

            var naj = Convert.ToInt32(liczba[0]);

            foreach (var dane in liczba)
            {
                var cyfra = Convert.ToInt32(dane);
                if (cyfra > naj)
                    naj = cyfra;
            }

            Console.WriteLine("Największą z wpisanych jest: " + naj);
        }
    }
}

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nazwisko = null;
            int? ileliter = nazwisko?.Length;
            var wynik = ileliter ?? 10;
            Console.Write(wynik);
        }
    }
}

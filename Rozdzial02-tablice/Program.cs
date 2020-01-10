using System;

namespace Rozdzial02_tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] imiona = new string[4];
            imiona[0] = "Kasia";
            imiona[1] = "Jacek";
            imiona[2] = "Joasia";
            imiona[3] = "Tomek";
            for (int i = 0; i < imiona.Length; i++)
            {
                Console.WriteLine(imiona[i]);
            }
        }
    }
}

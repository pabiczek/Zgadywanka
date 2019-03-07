using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraMonolit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gra Za dużo za mało");


            Console.Write("Podaj imię!: ");
            string nazwa = Console.ReadLine();
            Console.WriteLine($"Witaj, {nazwa}");

            Console.WriteLine("Koniec gry");
        }
    }
}

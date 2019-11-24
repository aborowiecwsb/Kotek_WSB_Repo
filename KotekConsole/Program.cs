using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotekConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("1. Dodaj liczby");
                Console.WriteLine("2. Odejmij liczby");
                Console.WriteLine("3. * liczby");
                Console.WriteLine("4. / liczby");
                Console.WriteLine("5. Wyjscie");

                int menuOption = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}

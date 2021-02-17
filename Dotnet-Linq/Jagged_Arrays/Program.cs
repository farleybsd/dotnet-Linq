using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Arrays
{
    class Program
    {
        // Jagged Array = Array Denteando = Array Serrilhado
        static void Main(string[] args)
        {
            string[][] familia = new string[3][];
            //{
            //    { "Fred","Wilma","Pedrita" },
            //    { "Homer","Marge","Lisa","Bart","Maggie" },
            //    { "Florinda","Kiko"}
            //};

            familia[0] = new string[] { "Fred", "Wilma", "Pedrita" };
            familia[1] = new string[] { "Homer", "Marge", "Lisa", "Bart", "Maggie" };
            familia[2] = new string[] { "Florinda", "Kiko" };
            Imprimir(familia);

            Console.ReadKey();
        }

        private static void Imprimir(string[][] familia)
        {
            foreach (var familiaitem in familia)
            {
                Console.WriteLine(string.Join(",", familiaitem));
            }
        }

    }
}

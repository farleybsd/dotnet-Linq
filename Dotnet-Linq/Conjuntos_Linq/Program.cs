using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjuntos_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] seq1 = { "Janeiro", "Fevereiro", "março" };
            string[] seq2 = { "Fevereiro", "Março", "Abril" };

            // Concatenando Duas Sequencias
            Console.WriteLine();
            Console.WriteLine("Concatenando Duas Sequencias");

            var consulta = seq1.Concat(seq2);
            Impimir(consulta);

            // União entre duas sequencias
            Console.WriteLine();
            Console.WriteLine("União entre duas sequencias");

            var consulta2 = seq1.Union(seq2);
            Impimir(consulta2);

            // União entre duas sequencias com comparador
            Console.WriteLine();
            Console.WriteLine("União entre duas sequencias com comparador");

            var consulta3 = seq1.Union(seq2,StringComparer.InvariantCultureIgnoreCase);
            Impimir(consulta3);

            // Interserção de duas sequencias 
            Console.WriteLine();

            Console.WriteLine("Interserção de duas sequencias ");

            var consulta4 = seq1.Intersect(seq2);
            Impimir(consulta4);

            // Execeto elementos do seq1 que não estão em seq2
            Console.WriteLine();

            Console.WriteLine("Execeto elementos do seq1 que não estão em seq2");

            var consulta5 = seq1.Except(seq2);
            Impimir(consulta5);

            Console.ReadKey();
        }

        private static void Impimir(IEnumerable<string> consulta)
        {
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionary
{
    class Program
    {
        static void Main(string[] args)

        //SortedDictionary Implementa uma Arvores melhor desenpenho pra adicionar e remover itens
        {
            IDictionary<string, Aluno> sorterd = new SortedDictionary<string, Aluno>();

            sorterd.Add("VT", new Aluno("Vanessa", 34672));

            sorterd.Add("AL", new Aluno("Ana", 5617));

            sorterd.Add("RN", new Aluno("Rafael", 17645));

            sorterd.Add("wm", new Aluno("Wanderson", 11287));

            ImprimirEmOrdem(sorterd);

            Console.ReadKey();
        }

        private static void ImprimirEmOrdem(IDictionary<string, Aluno> sorterd)
        {
            foreach (var alunosordernados in sorterd)
            {
                Console.WriteLine(alunosordernados);
            }
        }
    }
}

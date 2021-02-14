using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um Dicionario de Alunos
            IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();

            alunos.Add("VT", new Aluno("Vanessa", 34672));

            alunos.Add("AL", new Aluno("Ana", 5617));

            alunos.Add("RN", new Aluno("Rafael", 17645));

            alunos.Add("wm", new Aluno("Wanderson", 11287));

            // Imprimindo Aluno
            Imprimir(alunos);

            // Removendo AL
            alunos.Remove("AL");
            // Adicionando MO
            alunos.Add("MO", new Aluno("Marcelo", 12345));

            Console.WriteLine();

            // Imprimindo Aluno
            Imprimir(alunos);

            // Ordenando Dicionario.... SortedList implementa uma lista
            IDictionary<string, Aluno> sorterd = new SortedList<string, Aluno>();

            sorterd.Add("VT", new Aluno("Vanessa", 34672));

            sorterd.Add("AL", new Aluno("Ana", 5617));

            sorterd.Add("RN", new Aluno("Rafael", 17645));

            sorterd.Add("wm", new Aluno("Wanderson", 11287));


            Console.WriteLine();
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

        private static void Imprimir(IDictionary<string, Aluno> alunos)
        {
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}

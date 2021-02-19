using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mes> mes = new List<Mes>
            {
                new Mes("Janeiro",31),
                new Mes("Fevereiro",28),
                new Mes("Março",31),
                new Mes("Abril",30),
                new Mes("Maio",31),
                new Mes("Junho",30),
                new Mes("Julho",31),
                new Mes("Agosto",31),
                new Mes("Setembro",30),
                new Mes("Outubro",31),
                new Mes("Novembro",30 ),
                new Mes("Dezembro",31),
                new Mes("Janeiro",31)
            };

            // Pegar o primeiro trimestre
            var consulta = mes.Take(3);

            Imprimir(consulta);

            Console.WriteLine();

            // Pegar os meses depois do primeiro trimestre
            var consulta2 = mes.Skip(3);
            Imprimir(consulta2);

            Console.WriteLine();

            // Pegar os medes do terceiro trimestre
            var consulta3 = mes.Skip(6).Take(3);
            Imprimir(consulta3);
             
            Console.WriteLine();

            // Pegar os meses até que o mês comece com a letra S

            var consulta4 = mes.TakeWhile(m=> !m.Nome.StartsWith("S")); // predicate expressao lambida
            Imprimir(consulta4);

            Console.WriteLine();

            // Pular os meses até que o mes comece com a letra S
            var consulta5 = mes.SkipWhile(m => !m.Nome.StartsWith("S"));
            Imprimir(consulta5);

            Console.ReadKey();
        }

        private static void Imprimir(IEnumerable<Mes> consulta)
        {
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Mes
    {
        public Mes(string nome, int dias)
        {
            Nome = nome;
            Dias = dias;
        }

        public string Nome { get; private set; }
        public int Dias { get; private set; }


        public override string ToString()
        {
            return $"{Nome} - {Dias}";
        }
    }
}

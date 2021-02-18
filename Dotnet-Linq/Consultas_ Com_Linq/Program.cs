using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultas__Com_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problema : Obter os nomes dos meses do ano
            //  Que tem 31 dias, em maiúsculo e em ordem alfabetica

            // Linq consulta Intregrada a Linguagem

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

            IEnumerable<string>
                consulta = mes
                            .Where(m => m.Dias == 31)
                            .OrderBy(m => m.Nome)
                            .Select(m => m.Nome.ToUpper());
            Imprimir(consulta);

            Console.ReadKey();
        }

        private static void Imprimir(IEnumerable<string> consulta)
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

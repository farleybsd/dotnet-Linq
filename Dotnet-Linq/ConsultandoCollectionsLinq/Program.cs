using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultandoCollectionsLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problema : Obter os nomes dos meses do ano
            //  Que tem 31 dias, em maiúsculo e em ordem alfabetica

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
            mes.Sort();
            Imprimir(mes);

            Console.ReadKey();

        }

        private static void Imprimir(List<Mes> mes)
        {
            foreach (var m in mes)
            {
                if(m.Dias == 31)
                { Console.WriteLine(m.Nome.ToUpper()); }
                
            }
        }
    }

    class Mes : IComparable
    {
        public Mes(string nome, int dias)
        {
            Nome = nome;
            Dias = dias;
        }

        public string Nome { get; private set; }
        public int Dias { get; private set; }

        public int CompareTo(object obj)
        {
            Mes outro = obj as Mes;
            return this.Nome.CompareTo(outro.Nome);
        }

        public override string ToString()
        {
            return $"{Nome} - {Dias}";
        }
    }
}

//propg
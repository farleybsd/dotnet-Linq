using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariância
{
    class Program
    {
        static void Main(string[] args)
        {
            // String para objeto
            Console.WriteLine();
            Console.WriteLine("String para objeto");

            string titulo = "meses";
            object obj = titulo;
            Console.WriteLine(obj);

            //  List<string> para List<object>
            Console.WriteLine();
            Console.WriteLine("List<string> para List<object>");

            IList<string> listaMeses = new List<string>
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };

            //IList<object> listaObj = listaMeses;

            // String[] para objeto[]
            Console.WriteLine();
            Console.WriteLine("String[] para objeto[]");

            string[] arrayMeses = new string[]
            {
            "Janeiro", "Fevereiro", "Março",
            "Abril", "Maio", "Junho",
            "Julho", "Agosto", "Setembro",
            "Outubro", "Novembro", "Dezembro"
            };

            object[] arrayObj = arrayMeses;

            Console.WriteLine(arrayObj);

            foreach (var item in arrayObj)
            {
                Console.WriteLine(item);
            }


            //List<string> para IEnumerable<object>
            Console.WriteLine();
            Console.WriteLine("List<string> para IEnumerable<object>");

            IEnumerable<object> enumObt = listaMeses; // COVARIANCIA


            foreach (var item in enumObt)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}

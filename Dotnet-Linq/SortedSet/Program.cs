using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conjunto de alunos :
            ISet<string> alunos = new SortedSet<string>(new ComparadorMinusculo())
            {
                "Vanessa Tonini",
                "Ana Losnak",
                "Rafael Nercessian",
                "Priscila Stuani"
            };

            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio GushiKen");
            alunos.Add("Fabio GushiKen");
            alunos.Add("FABIO GUSHIKEN");
            ImprimirDicionario(alunos);

            ISet<string> outroConjunto = new HashSet<string>();

            // este conjunto é subconjunto do outro? IsSubsetOf
            alunos.IsSubsetOf(outroConjunto);

            // este conjunto é superconunto do outro ? IsSupersetOf
            alunos.IsSupersetOf(outroConjunto);

            // os conjuntos contêm os mesmos elementos ? SetEquals
            alunos.SetEquals(outroConjunto);

            // subtrai os elementos da outra coleção que também estão nesse conjunto ExceptWith
            alunos.ExceptWith(outroConjunto);

            // intersecção dos conjuntos - IntersectWith
            alunos.IntersectWith(outroConjunto);

            // somente em um ou outro conjuton - SymmetricExceptWith
            alunos.SymmetricExceptWith(outroConjunto);

            // união de conjuntos - UnionWith
            alunos.UnionWith(outroConjunto);

            Console.ReadKey();
        }

        private static void ImprimirDicionario(ISet<string> alunos)
        {
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }

    internal class ComparadorMinusculo : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}

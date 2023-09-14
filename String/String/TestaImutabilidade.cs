using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class TestaImutabilidade
    {
        static void Main()
        {
            string nome = "Rafael Cosentino";
            string nomeAlterado = nome.ToUpper();

            //Imprime Rafael Cosentino
            Console.WriteLine(nome);

            //Imprime RAFAEL COSENTINO
            Console.WriteLine(nomeAlterado);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class TestaValeRefeicao
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Vale Refeição: " + Funcionario.valeRefeicaoDiario);
            Funcionario.valeRefeicaoDiario = 15;
            Console.WriteLine("Vale Refeição: " + Funcionario.valeRefeicaoDiario);

            Funcionario.ReajustaValeRefeiçãoDiario(0.1);
            Console.WriteLine("Vale Refeição: " + Funcionario.valeRefeicaoDiario);
        }
    }
}

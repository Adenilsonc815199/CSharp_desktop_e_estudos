using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Funcionario
    {
        public String nome;
        public int salario;
        public static double valeRefeicaoDiario;

        public static void ReajustaValeRefeiçãoDiario(double taxa)
        {
            Funcionario.valeRefeicaoDiario += Funcionario.valeRefeicaoDiario * taxa;
        }
    }
   
}

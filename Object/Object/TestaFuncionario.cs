using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    class TestaFuncionario
    {
        static void Main()
        {
            Funcionario f = new Gerente();
            f.Salario = 3000;

            Console.WriteLine(f.Salario);
            Console.WriteLine(f.CalculaBonificacao());
        }

    }
}

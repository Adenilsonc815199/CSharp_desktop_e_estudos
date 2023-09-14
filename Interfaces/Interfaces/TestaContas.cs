using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class TestaContas
    {
        static void main()
        {
            ContaCorrente c1 = new ContaCorrente();
            ContaPoupanca c2 = new ContaPoupanca();

            c1.Deposita(500);
            c2.Deposita(500);

            c1.Saca(100);
            c2.Saca(100);

            Console.WriteLine(c1.saldo);
            Console.WriteLine(c2.saldo);
        }
    }
}

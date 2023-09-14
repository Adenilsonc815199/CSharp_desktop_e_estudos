using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class TestadorGeradorDeExtrato
    {
        static void Main()
        {
            ContaCorrente c1 = new ContaCorrente();
            ContaPoupanca c2 = new ContaPoupanca();

            c1.Deposita(500);
            c2.Deposita(500);

            GeradorDeExtrato g = new GeradorDeExtrato();
            g.GeraExtrato(c1);
            g.GeraExtrato(c2);
        }
    }
}

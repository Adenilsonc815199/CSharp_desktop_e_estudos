using System;

namespace Object
{
    class TestaConta
    {
        static void Main()
        {
            Conta c = new ContaPoupanca();
            c.saldo = 1000;

            c.ImprimeExtratoDetalhado();
        }
    }
}

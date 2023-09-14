using System;

namespace Static
{
    class TestaContador
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Contador:" + Conta.contador);

            Conta c1 = new Conta();
            Console.WriteLine("Numero da conta:" + c1.numero);
            Console.WriteLine("Contador:" + Conta.contador);

            Conta c2 = new Conta();
            Console.WriteLine("Numero da conta:" + c1.numero);
            Console.WriteLine("Contador:" + Conta.contador);

            Conta.ZeraConta();
        }
    }
}

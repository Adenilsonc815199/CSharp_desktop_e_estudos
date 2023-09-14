using System;

namespace Static
{
    class Conta
    {
        public static int contador;
        public int numero;

        public Conta()
        {
            Conta.contador++;
            this.numero = Conta.contador;
        }

        public static void ZeraConta()
        {
            Console.WriteLine("Contador: " + Conta.contador);
            Console.WriteLine("Zerando o contador!!!");
            Conta.contador = 0;
        }


    }



}

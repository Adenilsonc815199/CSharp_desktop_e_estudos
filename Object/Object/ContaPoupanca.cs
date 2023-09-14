using System;

namespace Object
{
    class ContaPoupanca : Conta
    {
        public int DiaDoAniversario { get; set; }

        public override void ImprimeExtratoDetalhado()
        {
            Console.WriteLine("EXTRATO DETALHADO DE CONTA POUPANÇA");
            DateTime agora = DateTime.Now;

            Console.Write("Data: " + agora.ToString("D"));
            Console.WriteLine("Saldo: " + saldo);
            Console.WriteLine("Aniversário: " + this.DiaDoAniversario);

        }
    }

}

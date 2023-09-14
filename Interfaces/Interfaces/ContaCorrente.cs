using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class ContaCorrente : Iconta
    {
        public double saldo { get; set; }
        private double taxaPorOperacao = 0.45;

        public void Deposita(double valor)
        {
            this.saldo += valor - taxaPorOperacao;
        }
        public void Saca(double valor)
        {
            this.saldo -= valor + taxaPorOperacao;

        }
    }
}

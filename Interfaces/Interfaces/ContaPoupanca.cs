using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class ContaPoupanca : Iconta
    {
        public double saldo { get; set; }
        public void Deposita(double valor)
        {
            this.saldo += valor;
        }
        public void Saca(double valor)
        {
            this.saldo -= valor;
        }
    }
}

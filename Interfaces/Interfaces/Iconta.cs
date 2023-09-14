using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface Iconta
    {
        void Deposita(double valor);
        void Saca(double valor);
        double saldo { get; set; }
    }
}

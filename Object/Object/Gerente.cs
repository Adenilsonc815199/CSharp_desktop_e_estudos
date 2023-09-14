using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    class Gerente : Funcionario
    {
        public string usuario { get; set; }
        public string senha { get; set; }

        public override double CalculaBonificacao()
        {
            return this.Salario * 0.2 + 300;
        }
    }
}

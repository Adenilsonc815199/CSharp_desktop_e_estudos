using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    abstract class Funcionario
    {
        public double Salario { get; set; }

        public abstract double CalculaBonificacao();
    }
}

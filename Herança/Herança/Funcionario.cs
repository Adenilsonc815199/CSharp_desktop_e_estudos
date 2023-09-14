using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public virtual double CalculoBonificacao()
        {
            return this.Salario * 0.6 + 100;
        } 



}       
        
    }


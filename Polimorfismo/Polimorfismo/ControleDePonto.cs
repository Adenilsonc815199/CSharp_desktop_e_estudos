using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class ControleDePonto
    {
        public void RegistroDeEntrada (Funcionario f)
        {
            DateTime agora = DateTime.Now;
            string horario = String.Format("{0:d/M/yyyy HH:mm:ss}", agora);

            Console.WriteLine("Nome do funcionário: " + f.nome);
            Console.WriteLine("Data de entrada: " + horario);
            Console.WriteLine("Código: " + f.codigo);
            Console.WriteLine("--------------------------------------------------------");

 
        }

        public void RegistroDeSaida(Funcionario f)
        {
            DateTime agora = DateTime.Now;
            string horario = String.Format("{0:d/M/yyyy HH:mm:ss}", agora);

            Console.WriteLine("Nome do funcionário: " + f.nome);
            Console.WriteLine("Data de saída: " + horario);
            Console.WriteLine("Código: " + f.codigo);
            Console.WriteLine("--------------------------------------------------------");


        }




    }
}

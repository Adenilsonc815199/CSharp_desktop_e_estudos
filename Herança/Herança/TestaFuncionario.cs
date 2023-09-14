using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class TestaFuncionario
    {
        static void Main (string[] args)
        {
            Gerente g = new Gerente();
            g.Nome = "Rafael Cosentino";
            g.Salario = 2000;
            g.Usuario = "rafael.cosentino";
            g.Senha = "12345";

            Telefonista t = new Telefonista();
            t.Nome = "Carolina Melo";
            t.Salario = 1000;
            t.estacaoDeTrabalho = 13;

            Secretaria s = new Secretaria();
            s.Nome = "Tatiane Andrade";
            s.Salario = 1500;
            s.ramal = 198;


            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Dados Gerente");
            Console.WriteLine("Nome: " + g.Nome);
            Console.WriteLine("Salário: " + g.Nome);
            Console.WriteLine("Usuário: " + g.Nome);
            Console.WriteLine("Senha: " + g.Nome);
            Console.WriteLine("Bonificação: " + g.CalculoBonificacao());
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Dados Telefonista");
            Console.WriteLine("Nome: " + t.Nome);
            Console.WriteLine("Salário: " + t.Salario);
            Console.WriteLine("Estação de trabalho: " + t.estacaoDeTrabalho);
            Console.WriteLine("Bonificação: " + t.CalculoBonificacao());
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Dados Secretaria");
            Console.WriteLine("Nome: " + s.Nome);
            Console.WriteLine("Salário: " + s.Salario);
            Console.WriteLine("Ramal: " + s.ramal);
            Console.WriteLine("Bonificação: " + s.CalculoBonificacao());
            Console.WriteLine("---------------------------------------");


        }

    }
}

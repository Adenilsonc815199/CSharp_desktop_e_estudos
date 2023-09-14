using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        delegate bool filtro(Conta c);
        static void Main(string[] args)
        {
            List<Conta> contas = new List<Conta>
            {
                new Conta {Numero = 1 , Saldo = 35700 },
                new Conta {Numero = 3 , Saldo =-700 },
                new Conta {Numero = 5 , Saldo = 85 },
                new Conta {Numero = 42 , Saldo = 15400},
                new Conta {Numero = 102 , Saldo = 1700},
                new Conta {Numero = 500 , Saldo =-300},
                new Conta {Numero = 203 , Saldo = 600 }
            };

            filtro FiltroParaOferecerCredito = FiltraContaNegativa;
            filtro filtroContasParaOferecerInvestimento = FiltraContaParaInvesvimento;

            Console.WriteLine("Contas com saldo negativo: ");
            List<Conta> contaSaldoNegativo = Filtrar(contas, FiltroParaOferecerCredito);
            Imprime(contaSaldoNegativo);

            Console.WriteLine("Contas com saldo acima de 10k");
            List<Conta> contaSaldoAcima10k = Filtrar(contas, filtroContasParaOferecerInvestimento);
            Imprime(contaSaldoAcima10k);
        }

        static List<Conta> Filtrar(List<Conta> contas, filtro filtro)
        {
            List<Conta> contasFiltradas = new List<Conta>();
            foreach (var conta in contas)
            {


                if (filtro(conta))
                {
                    contasFiltradas.Add(conta);
                }
            }
            return contasFiltradas;
        }
        static bool FiltraContaNegativa(Conta conta)
        {
            return conta.Saldo < 0;
        }

        static bool FiltraContaParaInvesvimento(Conta conta)
        {
            return conta.Saldo >= 1000;
        }

        static void Imprime(List<Conta> contas)
        {
            foreach (var conta in contas)
            {
                Console.WriteLine("Número: {0}, Saldo {1}", conta.Numero, conta.Saldo);
            }
            Console.WriteLine();
        }
    }
}


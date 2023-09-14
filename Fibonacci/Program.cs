using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obtendo numero digitado
            Console.WriteLine("Insira um numero inteiro: ");
                string numeroEntrada = Console.ReadLine();
                int numeroConvertido = Int32.Parse(numeroEntrada);
                int numeroAnterior = 0;
                int numeroAtual = 1;
                int fibonacci;
                bool existeNaSequencia = false;
                List<int> numerosAnteriores = new List<int>();

            for (int i = 0; i < numeroConvertido; i++)
                {
                //Imprimindo a sequencia, e inserindo numero anterior na lista
                Console.WriteLine(numeroAnterior);
                numerosAnteriores.Add(numeroAnterior);

                fibonacci = numeroAnterior + numeroAtual;
                numeroAnterior = numeroAtual;
                numeroAtual = fibonacci;

                //Valida se numero informado existe em algum momento do calculo
                if(numeroConvertido == numeroAnterior || numeroConvertido == numeroAtual || numeroConvertido == fibonacci)
                {
                    existeNaSequencia = true;
                }
            }

            //Resposta se existe ou não
            if(existeNaSequencia == true)
            {
                Console.WriteLine("Numero informado existe na sequencia de Fibonacci, numero: " + numeroConvertido);
            }
            else
            {
                Console.WriteLine("Numero informado Não existe na sequencia de Fibonacci, numero: " + numeroConvertido);
            }


        }
    }

}

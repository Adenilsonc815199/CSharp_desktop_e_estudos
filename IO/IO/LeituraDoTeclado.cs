using System;
using System.IO;

namespace IO
{
    class LeituraDoTeclado
    {
        static void Main()
        {
            TextReader teclado = Console.In;
            string linha = teclado.ReadLine();
            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = teclado.ReadLine();
            }
        }
    }
}

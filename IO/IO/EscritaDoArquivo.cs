using System;
using System.IO;

namespace IO
{
    class EscritaDoArquivo
    {
        static void Main()
        {
            TextWriter arquivo = new StreamWriter("saida.txt");

            arquivo.WriteLine("Primeira Linha!!!");
            arquivo.WriteLine("Segunda Linha!!!");
            arquivo.WriteLine("Terceira Linha!!!");

            arquivo.Close();
        }
    }
}

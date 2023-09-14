using System;
using System.IO;

namespace IO
{
    class LeituraDeArquivo
    {
        static void Main()
        {
            TextReader arquivo = new StreamReader("entrada.txt"); //TextReader le o arquivo txt.
            string linha = arquivo.ReadLine();
            while(linha != null)
            {
                Console.WriteLine(linha);
                linha = arquivo.ReadLine();
            }
            arquivo.Close();
        }
    }
}

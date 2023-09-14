
using System;
using System.Collections;
using System.Diagnostics;

namespace Collections
{
    class TestaAdicionaNoComeco
    {
        static void Main() { 
        ArrayList arraylist = new ArrayList();
        long tempo = TestaAdicionaNoComeco.AdicionaNoComeco(arraylist);
        Console.WriteLine(" ArrayList : " + tempo + "ms");
    }
    public static long AdicionaNoComeco(IList lista)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        int size = 100000;
        for (int i =0; i < size; i++)
        {
            lista.Insert(0, 1);
        }
        sw.Stop();
        return sw.ElapsedMilliseconds;
    }
    }
}

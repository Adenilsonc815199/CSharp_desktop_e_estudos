
using System;
using System.Collections;
using System.Diagnostics;

namespace Collections
{
    class TestaAdicionaNoFinal
    {
        static void Main()
        {
            ArrayList arraylist = new ArrayList();
            long tempo = TestaAdicionaNoFinal.AdicionaNoFinal(arraylist);
            Console.WriteLine("ArrayList: " + tempo + "ms");
            
        }
        public static long AdicionaNoFinal(IList lista)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int size = 100000;
            for (int i = 0; i < size; i++)
            {
                lista.Add(i);
            }
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }
    }
}

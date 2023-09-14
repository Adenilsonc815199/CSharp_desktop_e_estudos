using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class App
    {
       public static void ImprimeK19()
        {
            for (int i = 0; i <100; i++)
            {
                Console.WriteLine("k19");
                if(i % 10 == 0)
                {
                    Thread.Sleep(100);
                }
            }
        }

        public static void ImprimeK31()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("k31");
                if (i % 10 == 0)
                {
                    Thread.Sleep(100);
                }
            }
        }

        public static void Main()
        {
            Thread thread1 = new Thread(ImprimeK19);
            Thread thread2 = new Thread(ImprimeK31);

            thread1.Start();
            thread2.Start();
        }

    }
}

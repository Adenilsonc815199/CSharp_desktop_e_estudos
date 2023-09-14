using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class ExibeArgumentos
    {
        static void Main (string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
        }

    }
}

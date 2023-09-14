using System;

namespace ConsultaVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            double media;
            double SP = 67836.43;
            double RJ = 36678.66;
            double MG = 29229.88;
            double ES = 27165.48;
            double Outros = 19849.53;

            media = SP + RJ + MG + ES + Outros;

            double mediaSP = (SP / media)* 100;
            double mediaRJ = (RJ / media) * 100;
            double mediaMG = (MG / media) * 100;
            double mediaES = (ES / media) * 100;
            double mediaOutros = (Outros / media) * 100;
            Console.WriteLine("Média de SP " + mediaSP.ToString("N2") + "%");
            Console.WriteLine("Média de RJ " + mediaRJ.ToString("N2") + "%");
            Console.WriteLine("Média de MG" + mediaMG.ToString("N2") + "%");
            Console.WriteLine("Média de RS " + mediaES.ToString("N2") + "%");
            Console.WriteLine("Média dos Outros " + mediaOutros.ToString("N2") + "%");
        }
    }
}

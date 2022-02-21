using System;
using System.IO;

namespace leitorDeBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linha1="" , linha2="" , linha3="" ;
            int contadordeposicoes = 0;


            string numero = @" __      __  __      __  __  __  __  __ 
                              |  |   | __| __||__||__ |__    ||__||__|
                              |__|   ||__  __|   | __||__|   ||__| __|";

                             
                          


            StringReader leitordecodigo = new StringReader(numero);


            string primeiralinha = leitordecodigo.ReadLine();
            string segundalinha = leitordecodigo.ReadLine();
            string terceiralinha = leitordecodigo.ReadLine();

            segundalinha = segundalinha.Trim();
            terceiralinha = terceiralinha.Trim();

            char[] posicaoPrimeiraLinha = primeiralinha.ToCharArray();
            char[] posicaoSegundaLinha = segundalinha.ToCharArray();
            char[] posicaoTerceiraLinha = terceiralinha.ToCharArray();

            Console.WriteLine(primeiralinha);
            Console.WriteLine(segundalinha);
            Console.WriteLine(terceiralinha + "\n");

            for (int i = 0; i < 40; i ++)
            {
                linha1 += posicaoPrimeiraLinha[i];
                linha2 += posicaoSegundaLinha[i];
                linha3 += posicaoTerceiraLinha[i];
                
                if(linha1 ==" __ " && linha2 =="|  |"&& linha3=="|__|")
                {
                    Console.Write("0");
                }
                if (linha1 =="    "&& linha2=="   |"&& linha3=="   |" )
                {
                    Console.Write("1");
                }
                if (linha1 ==" __ "&& linha2==" __|"&& linha3=="|__ ")
                {
                    Console.Write("2");
                }
                if (linha1 ==" __ "&& linha2==" __|"&& linha3==" __|")
                {
                    Console.Write("3");
                }
                if (linha1 =="    "&& linha2=="|__|"&& linha3=="   |")
                {
                    Console.Write("4");
                }
                if (linha1 ==" __ "&& linha2=="|__ "&& linha3==" __|")
                {
                    Console.Write("5");
                }
                if (linha1 ==" __ "&& linha2=="|__ "&& linha3=="|__|")
                {
                    Console.Write("6");
                }
                if (linha1 ==" __ "&& linha2=="   |"&& linha3=="   |")
                {
                    Console.Write("7");
                }
                if (linha1 ==" __ "&& linha2=="|__|"&& linha3=="|__|")
                {
                    Console.Write("8");
                }
                if (linha1 ==" __ "&& linha2=="|__|"&& linha3==" __|")
                {
                    Console.Write("9");
                }
                contadordeposicoes++;
                if(contadordeposicoes==4)
                {
                    linha1 = "";
                    linha2 = "";
                    linha3 = "";
                    contadordeposicoes = 0;
                }

            }

        }
    }
}

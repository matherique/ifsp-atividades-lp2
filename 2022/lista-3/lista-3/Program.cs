using System;

namespace lista_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Ex1
    {
        public static int MAGIC_NUMBER = 213;
        public static void Run()
        {
            int maior = int.MinValue;
            int menor = int.MaxValue;

            int n = 0;
            int total = 0;

            for (int i = 0; i < MAGIC_NUMBER; i++)
            {
                Console.Write("Informe um numero: ({0}/{1})", i + 1, MAGIC_NUMBER);
                n = int.Parse(Console.ReadLine());
                total += n;

                if (n > maior)
                {
                    maior = n;
                    continue;
                }

                if (n < menor)
                {
                    menor = n;
                    continue;
                }
            }

            Console.WriteLine("Média aritimetica dos numeros: {0}", total / MAGIC_NUMBER);
            Console.WriteLine("Maior = {0}", maior);
            Console.WriteLine("Menor = {0}", menor);
        }
    }
}


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

    class EX2
    {
        public static void Run()
        {
            int n = 0;
            int total = 0;
            int i = 0;

            while (true)
            {
                Console.Write("Informe um numero: (digite 0 para finalizar) ");
                n = int.Parse(Console.ReadLine());

                total += n;

                i += 1;
                if (n == 0)
                {
                    break;
                }
            }

            int media = total / i;
            Console.WriteLine("Média aritmética: {0}", media);
        }
    }

    class EX3
    {
        public static void Run()
        {
            Console.Write("Informe um numero: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Informe um numero (maior que o informado anteriormente): ");
            int y = int.Parse(Console.ReadLine());


            for (int i = x; i < y; i++)
            {
                if (i % 7 == 3)
                {
                    Console.Write(i);
                }

                Console.Write(" ");
            }
        }
    }

    class EX4
    {
        public static int MAGIC_NUMBER = 97;
        public static void Run()
        {
            int total_par = 0;
            int total_impar = 0;

            int n = 0;

            for (int i = 0; i < MAGIC_NUMBER; i++)
            {
                Console.Write("Informe um numero: ({0}/{1})", i + 1, MAGIC_NUMBER);
                n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    total_par += n;
                    continue;
                }

                total_impar += n;
            }

            Console.WriteLine("Total pares: {0}", total_par);
            Console.WriteLine("Total impares: {0}", total_impar);
        }
    }
}


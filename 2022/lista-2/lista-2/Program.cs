using System;

namespace lista_2
{
    class Program
    {
        static void Main(string[] args)
        {
            EX1_a.Run();
        }
    }

    class EX1_a
    {
        public static void Run()
        {
            int n1 = 0, n2 = 0, n3 = 0;
            
            Console.Write("Escreva um numero: ");  
            string n1Str = Console.ReadLine();
            n1 = int.Parse(n1Str);

            Console.Write("Escreva outro numero: ");  
            string n2Str = Console.ReadLine();
            n2 = int.Parse(n2Str);

            Console.Write("Escreva outro numero: ");  
            string n3Str = Console.ReadLine();
            n3 = int.Parse(n3Str);

            int[] result = new int[] {n1,n2,n3};

            Array.Sort(result);

            Console.WriteLine("Os numeros informados em ordem crescente: {0}, {1}, {2}", result[0], result[1], result[2]);
        }
    }
}


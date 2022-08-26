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

    class EX1_b {

        public static void Run()
        {
          double radiano = 0;

          Console.Write("Informe um angulo em radianos: ");
          string radianoStr = Console.ReadLine();
          radiano = double.Parse(radianoStr);
          
          double PI = 3.14;
          double graus =  radiano * (180.0 / PI);
          
          Console.WriteLine("{0} rad = {1}º", radiano, graus);
        }
    }


    class EX1_c {
      public static void Run() {

        Console.Write("Informe o tamanho do cateto a: ");
        string aStr = Console.ReadLine();
        double a = double.Parse(aStr);

        Console.Write("Informe o tamanho do cateto b: ");
        string bStr = Console.ReadLine();
        double b = double.Parse(bStr);

        double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

        Console.WriteLine("c = {0}", c);
      }
    }

    class EX1_d
    {
        public static void Run()
        {
            Console.WriteLine("Informe um numero: "); 
            string nStr = Console.ReadLine();
            int n = int.Parse(nStr);

            if (n < 0 && n % 2 != 0) {
                return;
            }

            Console.WriteLine(Math.Sqrt(n));
        }
    }

    class EX1_e
    {
        public static void Run()
        {
            Console.WriteLine("Informe um numero: ");
            string n1Str = Console.ReadLine();
            int n1 = int.Parse(n1Str);

            Console.WriteLine("Informe um numero: ");
            string n2Str = Console.ReadLine();
            int n2 = int.Parse(n2Str);

            if (n1 > n2) {
                Console.WriteLine(n1);
                return;
            }

            if (n2 > n1) { 
                Console.WriteLine(n2);
                return;
            }

            Console.WriteLine("Os numeros são iguais");
        }
    }

    class EX1_f {
        public static void Run() {
            Console.Write("Informe um numer: ");
            string nStr = Console.ReadLine();
            int n = int.Parse(nStr);

            string dia = "Inválido";

            switch (n) {
                case 1:
                    dia = "Domingo";
                    break;
                case 2:
                    dia = "Segunda-feira";
                    break;
                case 3:
                    dia = "Terça-feira";
                    break;
                case 4:
                    dia = "Quarta-feira";
                    break;
                case 5:
                    dia = "Quinta-feira";
                    break;
                case 6:
                    dia = "Sexta-feira";
                    break;
                case 7:
                    dia = "Sabado";
                    break;
            }

            Console.WriteLine(dia);
        }

    }
}


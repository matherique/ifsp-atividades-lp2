using System;

namespace lista_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //EX1.Run();
            //EX2.Run();
            //EX3.Run();
            //EX4.Run();
            //EX5.Run();
            //EX6.Run();
            //EX7.Run();
            //EX8.Run();
            //EX9.Run();
            //EX10.Run();
            //EX11.Run();
            //EX12.Run();
        }
    }

    /*
     * 1.Para calcular vários tributos, a base de cálculo é o salário-mínimo. Faça um programa que leia o valor do salário-mínimo atuale o valor do salário de uma pessoa. Calcular e imprimir quantos salários-mínimos líquidos ela ganha, considerando que há um desconto de 8,5% de INSS.
     */
    class EX1
    {
        public static void Run()
        {
            double salarioMinimoAtual = 0.0;
            double salario = 0.0;
            double inss = 0.085;

            Console.Write("Informe o salário mínimo atual: ");
            string salarioMinimoStr = Console.ReadLine();
            salarioMinimoAtual = double.Parse(salarioMinimoStr);


            Console.Write("Informe o seu salário: ");
            string salarioStr = Console.ReadLine();
            salario = double.Parse(salarioStr);

            salario *= 1 - inss;

            double qtdSalarioMinimo = salario / salarioMinimoAtual;
            Console.WriteLine("Voce ganha {0} salários minimos", qtdSalarioMinimo);
        }
    }
    /*
     Façaum  programa  que  pede um  valor ao  usuário em  metros  e exibao  correspondente  em centímetros e milímetros.
    */
    class EX2
    {
        public static void Run()
        {
            double metros = 0.0;

            Console.Write("Informe o valor em metros: ");
            string metrosStr = Console.ReadLine();
            metros = double.Parse(metrosStr);

            double centimetros = metros * 100;
            double milimetros = centimetros * 100;

            Console.WriteLine("{0} metros equivalem há {1} centrimetros", metros, centimetros);
            Console.WriteLine("{0} metros equivalem há {1} milimetros", metros, milimetros);
        }
    }
    /*
     Façaum programa que solicite um valor em graus Fahrenheit e imprimao valor correspondente em graus Celsius usando as fórmulas que seguem:
        a.Usar uma variável floatpara ler o valor em Fahrenheit e a fórmula C=(f-32.0) * (5.0/9.0).
        b.Usar uma variável int para ler o valor em Fahrenheit e a fórmula C=(f-32)*(5/9).
    */

    class EX3
    {
        public static void Run()
        {
            Console.Write("(Informe o valor em Fahrenheit: ");
            string fahrenheitStr = Console.ReadLine();

            {
                double fahrenheit = double.Parse(fahrenheitStr);
                double celsius = (fahrenheit - 32.0) * (5.0 / 9.0);

                Console.WriteLine("(double) Celsius = {0}", celsius);
            }

            {
                float fahrenheit = float.Parse(fahrenheitStr);
                float celsius = (fahrenheit - 32) * (5 / 9);

                Console.WriteLine(" (float) Celsius = {0}", celsius);
            }


        }
    }

    /*Pesquise sobre a fórmula de cálculo do IMC (Índice de Massa Corporal) e crie um programa capaz de solicitar as informações, calcular e retornar o resultado.
     */

    class EX4
    {
        public static void Run()
        {
            double peso = 0.0;
            double altura = 0.0;

            Console.Write("Informe o peso (kg): ");
            string pesoStr = Console.ReadLine();
            peso = double.Parse(pesoStr);

            Console.Write("Informe a altura (m): ");
            string alturaStr = Console.ReadLine();
            altura = double.Parse(alturaStr);

            double imc = peso / (altura * altura);

            Console.WriteLine("IMC = {0}", imc);
        }
    }
    /*
     Faça um programa que solicite ao usuário três números e três pesos. Em seguida,calcule a média ponderada. Imprima o resultado.*/
    class EX5
    {
        public static void Run() {
            double n1 = 0.0, n2 = 0.0, n3 = 0.0;
            double p1 = 0.0, p2 = 0.0, p3 = 0.0;

            Console.Write("Informe um numero (1): ");
            string n1str = Console.ReadLine();
            n1 = double.Parse(n1str);

            Console.Write("Informe um numero (2): ");
            string n2str = Console.ReadLine();
            n2 = double.Parse(n1str);

            Console.Write("Informe um numero (3): ");
            string n3str = Console.ReadLine();
            n3 = double.Parse(n3str);

            Console.Write("Informe um peso (1): ");
            string p1str = Console.ReadLine();
            p1 = double.Parse(p1str);

            Console.Write("Informe um peso (2): ");
            string p2str = Console.ReadLine();
            p2 = double.Parse(p2str);

            Console.Write("Informe um peso (3): ");
            string p3str = Console.ReadLine();
            p3 = double.Parse(p3str);


            double media = (n1 * p1 + n2 * p2 + n3 * p3) / (p1 + p2 + p3);
            Console.WriteLine("A média ponderada dos dados informados é {0}", media);
        }
    }

    /*
     Escolha uma fórmula da física para codificar, solicite as informações necessárias para o cálculo e apresente o resultado.*/
    class EX6
    {
        public static void Run()
        {
            double distancia = 0.0;
            double tempo  = 0.0;

            Console.WriteLine("Calculo da velocidade média");
            Console.Write("Informe uma distancia (m): ");
            string distanciaStr = Console.ReadLine();
            distancia = double.Parse(distanciaStr);


            Console.Write("Informe um tempo (h): ");
            string tempoStr = Console.ReadLine();
            tempo = double.Parse(tempoStr);

            double velocidade = distancia / tempo;
            Console.WriteLine("A velocidade média é {0}km/h", velocidade);
        }
    }

    /*
     Escreva  um  algoritmo  que receba o salário de um funcionário, calcule e mostre o novo salário, sabendo-se que este sofreu um aumento de 33,7%.*/
    class EX7
    {
        public static void Run()
        {
            double salario = 0.0;
            Console.WriteLine("Informe o salário: ");
            string salarioStr = Console.ReadLine();
            salario = double.Parse(salarioStr);

            double novoSalario = salario * (1 + 0.337);
            Console.WriteLine("Seu novo salário é {0}", novoSalario);
        }
    }

    /*Leia um valor em realeacotaçãododólar.Emseguida,imprimaovalorcorrespondenteemdólares.*/
    class EX8
    {

    }
}


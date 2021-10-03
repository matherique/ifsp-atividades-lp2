using System;
using System.Linq;
using System.Collections.Generic;

namespace atividade
{
  class Program
  {
    // 1 - https://www.urionlinejudge.com.br/judge/pt/problems/view/1049
    // 2 - https://www.urionlinejudge.com.br/judge/pt/problems/view/1059 
    // 3 - https://www.urionlinejudge.com.br/judge/pt/problems/view/1073
    // 4 - https://www.urionlinejudge.com.br/judge/pt/problems/view/1079
    // 5 - https://www.urionlinejudge.com.br/judge/pt/problems/view/1133
    static void Main(string[] args)
    {
      int[] opts = { 1, 2, 3, 4, 5 };

      Console.WriteLine("Digite um numero de 1 a 5");
      Console.Write("> ");
      int option = Program.ReadInt();

      while (opts.Contains(option))
      {
        switch (option)
        {
          case 1:
            Program.Ex1049();
            break;
          case 2:
            Program.Ex1059();
            break;
          case 3:
            Program.Ex1073();
            break;
          case 4:
            Program.Ex1079();
            break;
        }

        Console.Write("> ");
        option = Program.ReadInt();
      }
    }

    static int ReadInt()
    {
      string optionStr = Console.ReadLine();
      int opt;
      int.TryParse(optionStr, out opt);

      return opt;
    }

    static void Ex1049()
    {
      string p1 = Console.ReadLine();
      string p2 = Console.ReadLine();
      string p3 = Console.ReadLine();

      Dictionary<string, Dictionary<string, Dictionary<string, string>>> animal = new Dictionary<string, Dictionary<string, Dictionary<string, string>>> {
        {
          "vertebrado", new Dictionary<string, Dictionary<string,string>>
          {
            { "ave", new Dictionary<string, string> { {"carnivoro", "aguia"}, {"onivoro", "pomba"} } },
            { "mamifero", new Dictionary<string, string> { {"onivoro", "homem"}, {"herbivoro", "vaca"} } },
          }
        },
        {
          "invertebrado", new Dictionary<string, Dictionary<string,string>>
          {
            { "inseto", new Dictionary<string, string> { {"hematofago", "pulga"}, {"herbivoro", "lagarta"} } },
            { "anelideo", new Dictionary<string, string> { {"hematofago", "sanguessuga"}, {"onivoro", "minhoca"} } },
          }
        },
      };

      try
      {
        Console.WriteLine(animal[p1][p2][p3]);
      }
      catch (Exception)
      {
        Console.WriteLine("nenhum animal encontrado");
      }
    }

    static void Ex1059()
    {
      for (var i = 1; i <= 100; i++)
      {
        if (i % 2 == 0)
        {
          Console.WriteLine(i);
        }
      }
    }

    static void Ex1073()
    {
      int n = Program.ReadInt();

      if (n <= 5 && n >= 2000) return;

      for (var i = 1; i <= n; i++)
      {
        if (i % 2 == 0) Console.WriteLine(string.Format("{0}^{1} = {2}", i, 2, Math.Pow(i, 2)));
      }
    }

    static void Ex1079()
    {
      int nTestCase = Program.ReadInt();

      Double[] resp = new Double[nTestCase];

      for (var i = 0; i < nTestCase; i++)
      {
        string testCase = Console.ReadLine();
        string[] cases = testCase.Split(" ");

        if (cases.Length != 3) return;

        Double a = Double.Parse(cases[0]);
        Double b = Double.Parse(cases[1]);
        Double c = Double.Parse(cases[2]);

        Double total = ((a * 2) + (b * 3) + (c * 5)) / (2 + 3 + 5);

        resp[i] = total;
      }

      resp.ToList().ForEach(a => Console.WriteLine("{0:N1}", a));
    }
  }
}

using System;

namespace atividade_4
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Digite o CPF: ");
      string cpf = Console.ReadLine();

      if (isValidCPF(cpf))
      {
        Console.WriteLine("CPF é válido");
      }
      else
      {
        Console.WriteLine("CPF inválido");
      }

    }

    public static bool isValidCPF(string cpf)
    {
      int[] multiplier1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
      int[] multiplier2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

      cpf = cpf.Trim().Replace(".", "").Replace("-", "");

      if (cpf.Length != 11) return false;

      string temp = cpf.Substring(0, 9);
      int sum = 0;

      for (int i = 0; i < 9; i++)
        sum += int.Parse(temp[i].ToString()) * multiplier1[i];

      int remainder = sum % 11;

      if (remainder < 2)
      {
        remainder = 0;
      }
      else
      {
        remainder = 11 - remainder;
      }

      string digit = remainder.ToString();

      temp = temp + digit;
      sum = 0;
      for (int i = 0; i < 10; i++)
      {
        sum += int.Parse(temp[i].ToString()) * multiplier2[i];
      }

      remainder = sum % 11;

      if (remainder < 2)
      {
        remainder = 0;
      }
      else
      {
        remainder = 11 - remainder;
      }

      digit = digit + remainder.ToString();

      return cpf.EndsWith(digit);
    }
  }
}

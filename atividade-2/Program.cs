using System;

namespace atividade_2
{
  class Program
  {
    static void Main(string[] args)
    {
      // Você foi contratado por uma corretora de serviços financeiros e precisa desenvolver
      // uma aplicação que dê suporte às operações da empresa. Portanto, seu primeiro trabalho
      // consiste em criar um sistema de gestão de clientes. Cada cliente ao solicitar um 
      // cadastro, precisará informar os seguintes dados: (Nome, CPF, RG, idade,
      // Renda Bruta Mensal, e-mail, telefone e patrimônio). Além dos dados informados, há um 
      // dado interno (classificação) que precisa ser definido com base nos seguintes critérios: 
      // 
      // Crie as variáveis necessárias para armazenar os dados a serem informados, além daquela que informa a classificação.
      // Crie um menu com as opções:
      //  1 - Editar dados (pergunte ao usuário se ele quer atualizar um a um os dados. Se houver alteração de idade ou patrimônio deve atualizar a classificação.
      //  2 - Exibir os dados cadastrados para aquele cliente.
      // Além disso, possibilite que as opções do menu possam ser escolhidas quantas vezes forem necessárias.

      // string nome, cpf, rg, rendaBMensal, email, telefone, classificacao;
      // int idade, escolha;
      // float patrimônio;
      int escolha;

      //Coletar os dados acima, menos a classificação.
      //Classificar o cliente de acordo com as regras apresentadas na descrição.
      do
      {
        //Exibir menu
        Console.WriteLine("Menu:");
        Console.WriteLine("  1: Editar");
        Console.WriteLine("  2: Exibir");

        Console.Write("> ");
        int.TryParse(Console.ReadLine(), out escolha);
        switch (escolha)
        {
          case 1:
            //Edição de dados perguntando se o usuário quer editar um a um os dados.
            break;
          case 2:
          //Exibir os dados cadastrados, inclusive a classificação.
          case 3:
            // cadastrar
            cadastrar();
            break;
        }

      } while (escolha != 0);
    }

    static string classificacao(float patrimonio, int idade)
    {
      //      * Cliente diamante : 10MM ou mais de patr. e menos de 39 anos OU 35MM ou mais de patr. e 39 ou mais anos.
      //      * Cliente ouro     : entre [7MM, 10MM) de patr. e menos de 36 anos OU entre [20MM, 35MM) de patr. e 36 ou mais anos.
      //      * Cliente prata    : entre [5MM, 7MM) de patr. e menos de 33 anos OU entre [10MM, 20MM) de patr. e 33 ou mais anos.
      //      * Cliente bronze   : entre [1MM, 5MM) de patr. e menos de 30 anos OU entre [5MM, 10MM) de patr. e 30 ou mais anos.
      //      * Cliente safira   : entre [0 e 1MM) de patr. e menos de 27 anos OU entre [0, 5MM) e 27 ou mais anos.
      //      * IMPORTANTE: caso haja sobreposição em relação a idade e patrimônio, escolha sempre a classificação acima.
      if ((patrimonio >= 10 && idade < 39) || (patrimonio >= 35 && idade >= 39))
      {
        return "diamante";
      }
      else if ((patrimonio >= 7 && patrimonio < 10 && idade < 36) || (patrimonio >= 20 && patrimonio < 35 && idade >= 36))
      {
        return "ouro";
      }
      else if ((patrimonio < 5 && patrimonio >= 7 && idade < 33) || (patrimonio >= 10 && patrimonio < 20 && idade >= 33))
      {
        return "prata";
      }
      else if ((patrimonio < 1 && patrimonio >= 5 && idade < 30) || (patrimonio >= 5 && patrimonio < 10 && idade >= 30))
      {
        return "bronze";
      }
      else if ((patrimonio < 0 && patrimonio >= 1 && idade < 27) || (patrimonio >= 0 && patrimonio < 5 && idade >= 27))
      {
        return "safira";
      }
      return "seila";
    }

    static void cadastrar()
    {
      // Nome, CPF, RG, idade, Renda Bruta Mensal, e-mail, telefone e patrimônio
      Console.Write("nome: ");
      string nome = Console.ReadLine();

      Console.Write("cpf: ");
      string cpf = Console.ReadLine();

      Console.Write("rg: ");
      string rg = Console.ReadLine();

      Console.Write("idade: ");
      int idade = int.Parse(Console.ReadLine());

      Console.Write("renda bruta mensal: ");
      string rendaBMensal = Console.ReadLine();

      Console.Write("email: ");
      string email = Console.ReadLine();

      Console.Write("telefone: ");
      string telefone = Console.ReadLine();

      Console.Write("patrimonio: ");
      float patrimonio = float.Parse(Console.ReadLine());


      string c = classificacao(patrimonio, idade);

    }
  }

  class Cliente
  {
    public string nome;
    public string email;
    public string cpf;
    public string rg;
    public int idade;
    public string rendaBMensal;
    public string telefone;
    public float patrimonio;
    public string classificacao;
  }
}
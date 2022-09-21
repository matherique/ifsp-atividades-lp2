using System;
using System.Collections.Generic;

namespace agenda
{
    class Agenda
    {

        public List<Cliente> clientes = new List<Cliente>();

        public void run()
        {
            string opcao;

            do
            {
                Console.WriteLine("=== Agenda ===\n");

                Console.WriteLine("1. Inserir novo cliente");
                Console.WriteLine("2. Listar todos os clientes");
                Console.WriteLine("3. Buscar clientes por nome");
                Console.WriteLine("4. Editar cliente");
                Console.WriteLine("5. Remover cliente");
                Console.WriteLine("6. Sair");
                Console.WriteLine("");
                Console.Write("> ");

                opcao = Console.ReadLine();
                Console.Clear();

                switch (opcao)
                {
                    case "1":
                        {
                            Console.WriteLine("== Cadastrar cliente ===\n");
                            Console.Write("nome: ");
                            string nome = Console.ReadLine();
                            Console.Write("telefone: ");
                            string telefone = Console.ReadLine();
                            Console.WriteLine("");

                            this.clientes.Add(new Cliente(nome, telefone));
                            Console.WriteLine("Cliente adicionado com sucesso.");
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("== Listar clientes ===\n");
                            if (this.clientes.Count == 0)
                            {
                                Console.WriteLine("Nenhum cliente cadastrado.");
                                break;
                            }

                            for (int i = 0; i < this.clientes.Count; i++)
                            {
                                Console.WriteLine("Cliente #{0}", i + 1);
                                Console.WriteLine(this.clientes[i]);
                                Console.WriteLine();
                            }
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("== Buscar clientes ===\n");
                            if (this.clientes.Count == 0)
                            {
                                Console.WriteLine("Nenhum cliente cadastrado.");
                                break;
                            }

                            Console.Write("Informe o nome do cliente: ");
                            string nome = Console.ReadLine();

                            bool existe = false;
                            for (int i = 0; i < this.clientes.Count; i++)
                            {
                                if (this.clientes[i].nome.ToLower().Contains(nome.ToLower()))
                                {
                                    Console.WriteLine("Cliente #{0}", i + 1);
                                    Console.WriteLine(this.clientes[i]);
                                    Console.WriteLine();
                                    existe = true;
                                }
                            }

                            if (!existe)
                            {
                                Console.WriteLine("Nenhum cliente encontrado com o nome: \"{0}\"", nome);
                            }

                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("== Editar clientes ===\n");
                            if (this.clientes.Count == 0)
                            {
                                Console.WriteLine("Nenhum cliente cadastrado.");
                                break;
                            }

                            Console.Write("Informe o nome do cliente: ");
                            string nome = Console.ReadLine();

                            int count = 0;
                            int target = 0;

                            Console.WriteLine("\nResultados: \n");

                            for (int i = 0; i < this.clientes.Count; i++)
                            {
                                if (this.clientes[i].nome.ToLower().Contains(nome.ToLower()))
                                {
                                    Console.WriteLine("Cliente #{0}", i + 1);
                                    Console.WriteLine(this.clientes[i]);
                                    Console.WriteLine();
                                    count += 1;
                                    target = i;
                                }
                            }

                            if (count == 0)
                            {
                                Console.WriteLine("Nenhum cliente encontrado com o nome: \"{0}\"", nome);
                                break;
                            }

                            if (count > 1)
                            {
                                Console.WriteLine("Encontrado {0} clientes com este nome.", count);
                                Console.Write("Informe qual cliente deseja editar: ");
                                string t = Console.ReadLine();
                                target = int.Parse(t) - 1;
                            }

                            Console.Write("nome: ");
                            string newNome = Console.ReadLine();
                            Console.Write("telefone: ");
                            string newTelefone = Console.ReadLine();
                            Console.WriteLine("");

                            this.clientes[target] = new Cliente(newNome, newTelefone);
                            Console.WriteLine("Cliente editado com sucesso.");

                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("== Remover clientes ===\n");
                            if (this.clientes.Count == 0)
                            {
                                Console.WriteLine("Nenhum cliente cadastrado.");
                                break;
                            }

                            Console.Write("Informe o nome do cliente: ");
                            string nome = Console.ReadLine();

                            int count = 0;
                            int target = 0;

                            Console.WriteLine("\nResultados: \n");

                            for (int i = 0; i < this.clientes.Count; i++)
                            {
                                if (this.clientes[i].nome.ToLower().Contains(nome.ToLower()))
                                {
                                    Console.WriteLine("Cliente #{0}", i + 1);
                                    Console.WriteLine(this.clientes[i]);
                                    Console.WriteLine();
                                    count += 1;
                                    target = i;
                                }
                            }

                            if (count == 0)
                            {
                                Console.WriteLine("Nenhum cliente encontrado com o nome: \"{0}\"", nome);
                                break;
                            }

                            if (count > 1)
                            {
                                Console.WriteLine("Encontrado {0} clientes com este nome.", count);
                                Console.Write("Informe qual cliente deseja remover: ");
                                string t = Console.ReadLine();
                                target = int.Parse(t) - 1;
                            }

                            this.clientes.RemoveAt(target);
                            Console.WriteLine("Cliente removido com sucesso.");

                            break;
                        }
                    case "6":
                        return;
                    default:
                        {
                            Console.WriteLine("opção inválida. \n");
                            break;
                        }
                }

                Console.Write("\nPressione qualquer tecla para voltar para o menu....");
                Console.ReadKey();
                Console.Clear();

            } while (true);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.Clear();
            Agenda agenda = new Agenda();
            agenda.run();
        }
    }

    class Cliente
    {
        public string nome;
        public string telefone;

        public Cliente(string nome, string telefone)
        {
            this.nome = nome;
            this.telefone = telefone;
        }

        public override string ToString()
        {
            return String.Format("Nome: {0} \nTelefone: {1}", this.nome, this.telefone);
        }
    }
}

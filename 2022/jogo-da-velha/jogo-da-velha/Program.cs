using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
/*
- Realizar validação em relação aos campos de entrada de dados;
- Permitir jogar com 2 jogadores (jogador1 x jogador2);
- Permitir jogar contra o computador;
- Armazenar ranking dos 10 jogadores com mais partidas vencidas;
- Permitir jogo com jogador cadastrado ou não (caso o jogador seja cadastrado, ele participará do ranking);
- Permitir cadastro de jogador com nome e cpf (validado) na plataforma do jogo;
- Manter o ranking e cadastro de jogadores permanentemente em memória secundária;
[OPCIONAL] Inserir níveis de dificuldade no jogo com algum tipo de inteligência quando o jogo for contra o computador
*/
namespace jogo_da_velha
{
    class Program
    {

        static void Main(string[] args)
        {
            Database db = new Database();
            Game game = new Game();

            JogoDaVelha jogo = new JogoDaVelha(db, game);
            jogo.loadPlayers();
            jogo.showMenu();


            jogo.savePlayers();

            /*
                Entrar
                Jogar sem cadastro
                Cadastrar
                Ranking
            */

        }
    }

    class JogoDaVelha
    {

        private List<Player> players = new List<Player>();
        private Database db;
        private Game game;
        private Player currentPlayer = null;
        private Player otherPlayer = null;
        private Player computer = null;

        public JogoDaVelha(Database db, Game game)
        {
            this.db = db;
            this.game = game;
        }

        public void loadPlayers()
        {
            foreach (string player in this.db.select())
            {
                string[] playerData = player.Split(';');
                this.players.Add(new Player(playerData[0], playerData[1], int.Parse(playerData[2])));
            }

            if (this.players.Find(x => x.name == "COMPUTADOR") == null)
            {
                this.players.Add(new Player("COMPUTADOR", "00000000000", 0));
            }
        }

        public void showMenu()
        {
            Console.Clear();
            Console.WriteLine("==== Bem vindo ao jogo da velha! ====");

            if (this.currentPlayer == null)
            {
                Console.WriteLine("1 - Entrar");
                Console.WriteLine("2 - Jogar sem cadastro");
                Console.WriteLine("3 - Cadastrar");
                Console.WriteLine("4 - Ranking");
                Console.WriteLine("5 - Sair");
            }
            else
            {
                Console.WriteLine("Bem vindo " + this.currentPlayer.name);

                Console.WriteLine("1 - Jogar com outro jogador");
                Console.WriteLine("2 - Jogar contra o computador");
                Console.WriteLine("3 - Deslogar");
                Console.WriteLine("4 - Sair");
            }

            Console.Write("\nEscolha uma opção: ");

            int option = int.Parse(Console.ReadLine());
            Console.Clear();
            if (this.currentPlayer == null)
            {
                this.parseMenuOptionUnauthenticated(option);
            }
            else
            {
                this.parseMenuOptionAuthenticated(option);
            }
        }

        private void playWithOtherPlayer()
        {
            Console.Clear();
            Console.WriteLine("==== Jogar com outro jogador ====");
            Console.WriteLine("1 - Escolher jogador");
            Console.WriteLine("2 - Voltar");

            Console.Write("\nEscolha uma opção: ");

            int option = int.Parse(Console.ReadLine());
            Console.Clear();


            if (option == 1)
            {
                Console.Write("Digite seu CPF: ");
                string cpf = Console.ReadLine();
                cpf = Regex.Replace(cpf, "[^0-9]", "");
                Player op = this.players.Find(x => x.cpf == cpf && x.cpf != this.currentPlayer.cpf);

                if (op == null)
                {
                    Console.WriteLine("Jogador não encontrado!");
                    Console.ReadKey();
                    this.playWithOtherPlayer();
                }
                else
                {
                    this.game.setPlayer1(this.currentPlayer);
                    this.game.setPlayer2(op);
                    this.game.play();
                    return;
                }
            }
            else if (option == 2)
            {
                return;
            }
            else
            {
                Console.WriteLine("Opção inválida!");
                this.playWithOtherPlayer();
            }
        }

        private void parseMenuOptionAuthenticated(int option)
        {

            switch (option)
            {
                case 1:
                    this.playWithOtherPlayer();
                    break;
                case 2:
                    this.playWithComputer();
                    break;
                case 3:
                    this.currentPlayer = null;
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            this.showMenu();
        }

        private void parseMenuOptionUnauthenticated(int option)
        {
            switch (option)
            {
                case 1:
                    this.login();
                    break;
                case 2:
                    this.playWithoutRegister();
                    break;
                case 3:
                    this.register();
                    break;
                case 4:
                    this.showRanking();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            this.showMenu();
        }

        private void playWithComputer()
        {
            this.computer = this.players.Find(x => x.name == "COMPUTADOR");
            this.otherPlayer = this.currentPlayer;

            this.game.setPlayer1(this.currentPlayer);
            this.game.setPlayer2(this.computer);

            this.game.play();
        }

        private void login()
        {
            Console.WriteLine("==== Login ====");

            Console.Write("Digite seu CPF: ");
            string cpf = Console.ReadLine();

            Player player = this.players.Find(p => p.cpf == cpf);

            if (player == null)
            {
                Console.WriteLine("Usuário não encontrado!");
                return;
            }

            this.currentPlayer = player;
            Console.WriteLine("Login realizado com sucesso!");
        }

        private void playWithoutRegister()
        {
            Player player1 = new Player("Jogador 1", "001.001.001-01", 0);
            Player player2 = new Player("Jogador 2", "002.002.002-02", 0);

            this.game.setPlayer1(player1);
            this.game.setPlayer2(player2);

            this.game.play();
        }

        private void register()
        {
            Console.WriteLine("==== Cadastro ====");
            Console.Write("Digite seu nome: ");
            string name = Console.ReadLine();
            name.Replace(";", "");

            if (name == "")
            {
                Console.WriteLine("Nome inválido!");
                return;
            }
            else if (this.players.Find(p => p.name == name) != null)
            {
                Console.WriteLine("Já existe um jogador cadastrado com esse nome!");
                return;
            }
            else if (name == "COMPUTADOR")
            {
                Console.WriteLine("Esse nome não pode ser utilizado!");
                return;
            }

            Console.Write("Digite seu CPF: ");
            string cpf = Console.ReadLine();
            cpf = Regex.Replace(cpf, "[^0-9]", "");

            if (cpf.Length != 11)
            {
                Console.WriteLine("CPF inválido!");
                return;
            }
            else if (this.players.Find(player => player.cpf == cpf || player.name == name) != null)
            {
                Console.WriteLine("Jogador já cadastrado!");
                return;
            }


            Player player = new Player(name.ToUpper(), cpf);
            this.players.Add(player);
            this.currentPlayer = player;

            Console.WriteLine("Jogador cadastrado com sucesso!");
        }

        private void showRanking()
        {
            Console.WriteLine("==== Ranking ====");
            this.players.Sort((x, y) => y.victories.CompareTo(x.victories));

            Console.WriteLine("Ranking");
            Console.WriteLine("Nome\t\tVitórias");
            for (int i = 0; i < this.players.Count - 1; i++)
            {
                Console.WriteLine($"{i + 1} - {this.players[i].name} - {this.players[i].victories}");
            }
        }

        public void savePlayers()
        {
            string[] playersData = new string[this.players.Count];

            for (int i = 0; i < this.players.Count; i++)
            {
                playersData[i] = this.players[i].ToString();
            }

            this.db.updateAll(playersData);
        }

    }

    class Player
    {
        public string name;
        public string cpf;
        public int victories;

        public Player(string name, string cpf, int victory = 0)
        {
            this.name = name;
            this.cpf = cpf;
            this.victories = victory;
        }


        public void addVictory()
        {
            this.victories++;
        }

        public override string ToString()
        {
            return String.Format("{0};{1};{2}", this.name, this.cpf, this.victories);
        }

        public string Print()
        {
            return String.Format("Nome: {0}\nCPF: {1}\nVitórias: {2}", this.name, this.cpf, this.victories);
        }

    }

    class Game
    {
        public Player player1;
        public Player player2;
        public int[,] board;

        public Game()
        {
            this.board = new int[3, 3];
        }

        public void setPlayer1(Player player)
        {
            this.player1 = player;
        }

        public void setPlayer2(Player player)
        {
            this.player2 = player;
        }

        public void play()
        {
            if (this.player1 == null || this.player2 == null)
            {
                throw new Exception("Os jogadores não foram definidos!");
            }

            int turn = 1;
            int winner = 0;
            while (winner == 0)
            {
                Console.WriteLine("==== Jogo ====");

                Console.WriteLine("Turno: {0}\n", turn);
                Console.WriteLine("Jogador 1: {0}", this.player1.name);
                Console.WriteLine("Jogador 2: {0}", this.player2.name);
                Console.Write("Jogador 1, escolha uma posição para jogar: ");

                int position = int.Parse(Console.ReadLine());
                this.board[position / 3, position % 3] = 1;

                Console.Write("Jogador 2, escolha uma posição para jogar: ");

                position = int.Parse(Console.ReadLine());
                this.board[position / 3, position % 3] = 2;
                turn++;
                winner = this.checkWinner();
                this.PrintBoard();
            }
            if (winner == 1)
            {
                Console.WriteLine("Jogador 1 venceu!");
                this.player1.addVictory();
            }
            else
            {
                Console.WriteLine("Jogador 2 venceu!");
                this.player2.addVictory();
            }
        }

        public int checkWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                if (this.board[i, 0] == this.board[i, 1] && this.board[i, 1] == this.board[i, 2])
                {
                    return this.board[i, 0];
                }
                if (this.board[0, i] == this.board[1, i] && this.board[1, i] == this.board[2, i])
                {
                    return this.board[0, i];
                }
            }
            if (this.board[0, 0] == this.board[1, 1] && this.board[1, 1] == this.board[2, 2])
            {
                return this.board[0, 0];
            }
            if (this.board[0, 2] == this.board[1, 1]
                && this.board[1, 1] == this.board[2, 0])
            {
                return this.board[0, 2];
            }
            return 0;

        }
        public void PrintBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (this.board[i, j] == 0)
                    {
                        Console.Write(" ");
                    }
                    else if (this.board[i, j] == 1)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("O");
                    }
                    if (j < 2)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
                if (i < 2)
                {
                    Console.WriteLine("-----");
                }
            }
        }
    }

    class Database
    {
        private String FILENAME = "database.txt";

        public Database()
        {
            if (!File.Exists(this.FILENAME))
            {
                File.Create(this.FILENAME).Close();
            }
        }

        public void insert(string txt)
        {
            File.AppendAllLines(FILENAME, new string[] { txt });
        }

        public string[] select()
        {
            return File.ReadAllLines(FILENAME);
        }

        public void updateAll(string[] data)
        {
            File.WriteAllLines(FILENAME, data);
        }
    }
}


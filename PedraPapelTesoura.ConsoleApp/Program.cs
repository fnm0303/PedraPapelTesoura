using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        while (true)
        {
            int escolhaJogador = ObterEscolhaJogador();

            int escolhaComputador = ObterEscolhaComputador();

            CompararEscolhas(escolhaJogador, escolhaComputador);

            Console.WriteLine("-------------------------");
            Console.Write("Deseja continuar? s/n ");
            string? opcaoContinuar = Console.ReadLine().ToUpper();

            if (opcaoContinuar != "S")
                break;
        }

    }
    static int ObterEscolhaJogador()
    {
        int escolhaJogador;

        do
        {
            Console.Clear();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Pedra, Papel, Tesoura");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1 - Pedra");
            Console.WriteLine("2 - Papel");
            Console.WriteLine("3 - Tesoura");
            Console.WriteLine("-------------------------");

            Console.Write("Escolha uma opção válida: ");
            string? strEscolhaJogador = Console.ReadLine(); //? para permitir que a variável seja null

            Console.WriteLine("-------------------------");

            if (strEscolhaJogador == "1" || strEscolhaJogador == "2" || strEscolhaJogador == "3")
            {
                escolhaJogador = Convert.ToInt32(strEscolhaJogador);
                break;
            }

        } while (true);

        return escolhaJogador;
    }

    static int ObterEscolhaComputador()
    {
        return RandomNumberGenerator.GetInt32(1, 4);
        //return escolhaComputador;
    }

    static void CompararEscolhas(int escolhaJogador, int escolhaComputador)
    {
        const int ESCOLHA_PEDRA = 1; //constantes tudo maiusculo
        const int ESCOLHA_PAPEL = 2;
        const int ESCOLHA_TESOURA = 3;

        if (escolhaJogador == escolhaComputador)
        {
            Console.WriteLine("Empate!");
        }
        else if (escolhaJogador == ESCOLHA_PEDRA)
        {
            Console.Write("Pedra vs");
            if (escolhaComputador == ESCOLHA_PAPEL)
            {
                Console.WriteLine(" Papel");
                Console.WriteLine("O computador venceu!");
            }
            else if (escolhaComputador == ESCOLHA_TESOURA)
            {
                Console.WriteLine(" Tesoura");
                Console.WriteLine("Você venceu!");
            }
        }
        else if (escolhaJogador == ESCOLHA_PAPEL)
        {
            Console.Write("Papel vs");
            if (escolhaComputador == ESCOLHA_TESOURA)
            {
                Console.WriteLine(" Tesoura");
                Console.WriteLine("O computador venceu!");
            }
            else if (escolhaComputador == ESCOLHA_PEDRA)
            {
                Console.WriteLine(" Tesoura");
                Console.WriteLine("Você venceu!");
            }
        }
        else if (escolhaJogador == ESCOLHA_TESOURA)
        {
            Console.Write("Tesoura vs");
            if (escolhaComputador == ESCOLHA_PEDRA)
            {
                Console.WriteLine(" Pedra");
                Console.WriteLine("O computador venceu!");
            }
            else if (escolhaComputador == ESCOLHA_PAPEL)
            {
                Console.WriteLine(" Papel");
                Console.WriteLine("Você venceu!");
            }
        }
    }

}


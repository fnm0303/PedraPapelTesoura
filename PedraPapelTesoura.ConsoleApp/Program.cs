using System.Security.Cryptography;

const int ESCOLHA_PEDRA = 1; //constantes tudo maiusculo
const int ESCOLHA_PAPEL = 2;
const int ESCOLHA_TESOURA = 3;

while (true)
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

    int escolhaComputador = RandomNumberGenerator.GetInt32(1, 4); //nro aleatório entre 1, 2 ou 3

    if (escolhaJogador == escolhaComputador)
    {
        Console.WriteLine("Empate!");
    }
    else if (escolhaJogador == ESCOLHA_PEDRA)
    {
        Console.Write("Pedra vs");
        if (escolhaComputador == ESCOLHA_PAPEL)
        {
            Console.WriteLine("Papel");
            Console.WriteLine("O computador venceu!");
        }
        else if (escolhaComputador == ESCOLHA_TESOURA)
        {
            Console.WriteLine("Tesoura");
            Console.WriteLine("Você venceu!");
        }
    }
    else if (escolhaJogador == ESCOLHA_PAPEL)
    {
        Console.Write("Papel vs");
        if (escolhaComputador == ESCOLHA_TESOURA)
        {
            Console.WriteLine("Tesoura");
            Console.WriteLine("O computador venceu!");
        }
        else if (escolhaComputador == ESCOLHA_PEDRA)
        {
            Console.WriteLine("Tesoura");
            Console.WriteLine("Você venceu!");
        }
    }
    else if (escolhaJogador == ESCOLHA_TESOURA)
    {
        Console.Write("Tesoura vs");
        if (escolhaComputador == ESCOLHA_PEDRA)
        {
            Console.WriteLine("Pedra");
            Console.WriteLine("O computador venceu!");
        }
        else if (escolhaComputador == ESCOLHA_PAPEL)
        {
            Console.WriteLine("Papel");
            Console.WriteLine("Você venceu!");
        }
    }

    Console.Write("Deseja continuar? s/n ");
    string? opcaoContinuar = Console.ReadLine().ToUpper();

    Console.WriteLine("-------------------------");

    if (opcaoContinuar != "S")
        break;
}

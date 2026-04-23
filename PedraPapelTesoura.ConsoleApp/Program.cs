const int ESCOLHA_PEDRA = 1; //constantes tudo maiusculo
const int ESCOLHA_PAPEL = 2;
const int ESCOLHA_TESOURA = 3;

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
    string escolhaJogador = Console.ReadLine();

    if (escolhaJogador != "1" && escolhaJogador != "2" && escolhaJogador != "3")
    {

    }
} while (true);

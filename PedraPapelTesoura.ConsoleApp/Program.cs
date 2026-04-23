using System.Security.Cryptography;
using PedraPapelTesoura.ConsoleApp.Entidades;

namespace PedraPapelTesoura.ConsoleApp;

class Program
{
    static void Main()
    {
        while (true)
        {
            int escolhaJogador = Jogador.ObterEscolhaJogador();

            int escolhaComputador = Computador.ObterEscolhaComputador();

            Jogo.CompararEscolhas(escolhaJogador, escolhaComputador);

            Console.WriteLine("-------------------------");
            Console.Write("Deseja continuar? s/n ");
            string? opcaoContinuar = Console.ReadLine().ToUpper();

            if (opcaoContinuar != "S")
                break;
        }

    }



}


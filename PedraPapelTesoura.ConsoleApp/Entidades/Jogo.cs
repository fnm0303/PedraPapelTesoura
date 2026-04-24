using System;

namespace PedraPapelTesoura.ConsoleApp.Entidades;

public static class Jogo
{
    public static void CompararEscolhas(int escolhaJogador, int escolhaComputador)
    {
        const int ESCOLHA_PEDRA = 1; //constantes tudo maiusculo
        const int ESCOLHA_PAPEL = 2;
        const int ESCOLHA_TESOURA = 3;

        if (escolhaJogador == escolhaComputador)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Empate!");
            Console.ResetColor();
        }
        else if (escolhaJogador == ESCOLHA_PEDRA)
        {
            Console.Write("Pedra vs");
            if (escolhaComputador == ESCOLHA_PAPEL)
            {
                Console.WriteLine(" Papel");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("O computador venceu!");
                Console.ResetColor();
            }
            else if (escolhaComputador == ESCOLHA_TESOURA)
            {
                Console.WriteLine(" Tesoura");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Você venceu!");
                Console.ResetColor();
            }
        }
        else if (escolhaJogador == ESCOLHA_PAPEL)
        {
            Console.Write("Papel vs");
            if (escolhaComputador == ESCOLHA_TESOURA)
            {
                Console.WriteLine(" Tesoura");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("O computador venceu!");
                Console.ResetColor();
            }
            else if (escolhaComputador == ESCOLHA_PEDRA)
            {
                Console.WriteLine(" Tesoura");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Você venceu!");
                Console.ResetColor();
            }
        }
        else if (escolhaJogador == ESCOLHA_TESOURA)
        {
            Console.Write("Tesoura vs");
            if (escolhaComputador == ESCOLHA_PEDRA)
            {
                Console.WriteLine(" Pedra");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("O computador venceu!");
                Console.ResetColor();
            }
            else if (escolhaComputador == ESCOLHA_PAPEL)
            {
                Console.WriteLine(" Papel");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Você venceu!");
                Console.ResetColor();
            }
        }
    }
}

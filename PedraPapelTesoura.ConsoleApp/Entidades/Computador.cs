using System;
using System.Security.Cryptography;

namespace PedraPapelTesoura.ConsoleApp.Entidades;

public static class Computador
{
    public static int ObterEscolhaComputador()
    {
        return RandomNumberGenerator.GetInt32(1, 4);
        //return escolhaComputador;
    }
}

using System;
namespace SistemaVeterinaria.Utilidades
{
public class GeneradorCodigo
    {
public static string Generar()
        {
    string letrasYnumeros = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random rnd = new Random();
            string codigoNuevo = "";

            for (int i = 0; i < 8; i++)
            {
                int pos = rnd.Next(letrasYnumeros.Length);
                codigoNuevo = codigoNuevo + letrasYnumeros[pos];
            }

            return codigoNuevo;
        }
    }
}
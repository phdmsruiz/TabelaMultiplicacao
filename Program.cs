// See https://aka.ms/new-console-template for more information
using System;

class TabelaMultiplicacao
{
    
    public static void Multiplicar(int numero)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
    static void Main(string[] args)
    {
        int seuNumero;
        Console.WriteLine("Digite um número:");
        seuNumero = Convert.ToInt32(Console.ReadLine());

        Multiplicar(seuNumero);

    }
}

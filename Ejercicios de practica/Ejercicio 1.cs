using System;

class Program
{
    static void Main()
    {
        // Hacer que el sujeto ponga dos digitos
        Console.Write("Ingrese numero de dos digitos: ");
        string input = Console.ReadLine();

        // Chequear si son mas de dos digitos
        if (input.Length != 2)
        {
            Console.WriteLine("Por favor, ingrese un numero de dos dígitos.");
            return;
        }

        // Hacer que sea un numero entero
        int numero = int.Parse(input);

        // Calculo de la suma con resultado
        Console.WriteLine($"La suma de los dígitos es: {numero / 10 + numero % 10}");

    }
}

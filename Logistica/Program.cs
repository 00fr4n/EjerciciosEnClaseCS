int[] desplazA = new int[5];
int[] desplazB = new int[5];
int[] desplazTotal = new int[5];
Console.WriteLine("Desplazamientos A (2, 4, 6, 8, 10):");
for (int i = 0; i < desplazA.Length; i++)
{
    try
    {
        Console.Write($"Intervalo {i + 1}: ");
        desplazA[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada invalida. Por favor, ingrese un numero entero.");
        i--;
        Console.ResetColor();
    }
}
Console.WriteLine("Desplazamientos B (1, 3, 5, 7, 9):");
for (int i = 0; i < desplazB.Length; i++)
{
    try
    {
        Console.Write($"Intervalo {i + 1}: ");
        desplazB[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada invalida. Por favor, ingrese un numero entero.");
        i--;
        Console.ResetColor();
    }
}

for (int i = 0; i < desplazTotal.Length; i++)
{
    desplazTotal[i] = desplazA[i] + desplazB[i];
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(" Desplazamiento total");
Console.ResetColor();

for (int i = 0; i < desplazTotal.Length; i++)
{
    Console.WriteLine($"Total en Intervalo {i + 1}: {desplazTotal[i]} metros");
}

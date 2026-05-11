int[] maqA = new int[5];
int[] maqB = new int[5];
int[] diferenciaVector = new int[5];
Console.WriteLine("Produccion A (15, 18, 20, 25, 30):");
for (int i = 0; i < maqA.Length; i++)
{
    try
    {
        Console.Write($"Periodo {i + 1}: ");
        maqA[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada invalida. Por favor, ingrese un numero entero.");
        i--;
        Console.ResetColor();
    }
}
Console.WriteLine("Produccion B (5, 8, 10, 12, 15):");
for (int i = 0; i < maqB.Length; i++)
{
    try
    {
        Console.Write($"Periodo {i + 1}: ");
        maqB[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada invalida. Por favor, ingrese un numero entero.");
        i--;
        Console.ResetColor();
    }
}
for (int i = 0; i < diferenciaVector.Length; i++)
{
    diferenciaVector[i] = maqA[i] - maqB[i];
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(" Diferencias de Produccion");
Console.ResetColor();
for (int i = 0; i < diferenciaVector.Length; i++)
{
    Console.WriteLine($"Diferencia en Periodo {i + 1}: {diferenciaVector[i]} unidades");
}

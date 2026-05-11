int[] vectorV = new int[5];
double sumaCuadrados = 0;
Console.WriteLine("Movimientos Vector V (3, 4, 5, 6, 7):");
for (int i = 0; i < vectorV.Length; i++)
{
    try
    {
        Console.Write($"Direccion {i + 1}: ");
        vectorV[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada invalida. Por favor, ingrese un numero entero.");
        i--;
        Console.ResetColor();
    }
}
for (int i = 0; i < vectorV.Length; i++)
{
    sumaCuadrados += Math.Pow(vectorV[i], 2);
}
double magnitudTotal = Math.Sqrt(sumaCuadrados);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Calculo de trayectoria");
Console.ResetColor();
Console.WriteLine($" total del vector de movimiento es: {magnitudTotal}");

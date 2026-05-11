int[] vecA = new int[5];
int[] vecB = new int[5];
int productoEscalar = 0;

Console.WriteLine("Ingrese las fuerzas del Vector A (1, 2, 3, 4, 5):");
for (int i = 0; i < vecA.Length; i++)
{
    try
    {
        Console.Write($"Fuerza A {i + 1}: ");
        vecA[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada invalida, ingrese un numero entero.");
        i--;
        Console.ResetColor();
    }
}
Console.WriteLine("Ingrese las fuerzas del Vector B (5, 4, 3, 2, 1):");
for (int i = 0; i < vecB.Length; i++)
{
    try
    {
        Console.Write($"Fuerza B {i + 1}: ");
        vecB[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada invalida, ingrese un numero entero.");
        i--;
        Console.ResetColor();
    }
}
for (int i = 0; i < vecA.Length; i++)
{
    productoEscalar += vecA[i] * vecB[i];
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Producto Escalar");
Console.ResetColor();
Console.WriteLine($"El producto escalar total es: {productoEscalar}");

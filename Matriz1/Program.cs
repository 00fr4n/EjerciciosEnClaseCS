double [,] matriz = new double [3, 3];
Console.WriteLine("Matrices");
Console.WriteLine("Ingresa las temperaturas:");
int cont = 1;
try
{
    for (int r = 0; r < 3; r++)
{
    for(int c = 0; c<3; c++)
    {
        Console.WriteLine($"Dime la temperatura # {cont++}");
        matriz[r,c] = Convert.ToDouble(Console.ReadLine());
    }
}
}
catch (FormatException)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Dato invalido, porfavor ingrese un numero;");
    Console.ResetColor();
}

Console.Clear();
Console.WriteLine("Temperaturas Registradas");
for (int f=0; f<3;f++)
{
    for (int c=0; c<3; c++)
    {
       if(matriz[f,c] < 35) Console.ForegroundColor = ConsoleColor.Green;
       else if(matriz [f,c] >= 35 && matriz[f,c] < 40) Console.ForegroundColor = ConsoleColor.Yellow;
       else Console.ForegroundColor = ConsoleColor.Red;
       Console.Write($"{matriz[f,c]}");
       Console.ResetColor();
    }
Console.WriteLine();
}

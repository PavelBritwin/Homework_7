// Task  47

Console.Clear();

double[,] array = new double[new Random().Next(5, 10), new Random().Next(5, 10)];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = Math.Round(new Random().NextDouble(), 2);
        Console.Write($"{array[i, j]} ({i}{j})  ");
    }
    Console.WriteLine();
}


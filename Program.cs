// Task 52
Console.Clear();
int[,] array = new int[5, 5];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(3, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    double average = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        average += array[j, i];
    }
    Console.Write($"{average/array.GetLength(0)}  ");
}
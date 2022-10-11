// Task 50
Console.Clear();
int[,] array = new int[new Random().Next(5, 10), new Random().Next(5, 10)];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(3, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите индексы элемента массива: ");
int firstIndex = Convert.ToInt32(Console.ReadLine()); // first
int secondIndex = Convert.ToInt32(Console.ReadLine()); // second

if ((firstIndex < 0)||
    (firstIndex >= array.GetLength(0))||
    (secondIndex < 0)||
    (secondIndex >= array.GetLength(1)))
    Console.WriteLine("Такого элемента нет в массиве!");
else
    Console.WriteLine($"Значение элемента: {array[firstIndex, secondIndex]}");
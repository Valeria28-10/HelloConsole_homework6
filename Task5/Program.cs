// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
FillArray(array);

for (int j = 0; j < array.GetLength(1); j++)
{
    double avarageSumma = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avarageSumma = (avarageSumma + array[i, j]);
    }
    avarageSumma = Math.Round((avarageSumma / m), 2);
    Console.Write($"Среднеарифметическое значение элементов в столбце {j+1}: {avarageSumma}");
    Console.WriteLine();
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


FillArray(array);
Console.WriteLine();
PrintArray(array);
 

// Задача 50. Напишите программу, которая на вход принимает значение
// элемента в двумерном массиве, и возвращает позицию этого элемента или же 
// указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        Console.Write($"{array[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        array[i, j] = new Random().Next(0,10); 
        }
    }
}

void SearchValue(int valueSearch,int[,] array)
{
    bool SearchValue = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] == valueSearch)
            {
                Console.WriteLine($"Позиция искомого числа {valueSearch} находится [{i},{j}]");
                SearchValue = true;
               
            }
        }
    }
    if(!SearchValue)
    {    
        Console.WriteLine($"{valueSearch} -> такого числа в массиве нет");
    }
}

Console.Write("Введите количество строк: ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите искомое число: ");
int valueSearch = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[linesVol, columnsVol];

FillArray(array);
Console.WriteLine();
PrintArray(array);
SearchValue(valueSearch, array);


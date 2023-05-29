// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите любые числа через пробел или запятую: ");
char[] NumbersToSelect = new char[] {',', ' '};
string[] numbers = Console.ReadLine().Split(NumbersToSelect, StringSplitOptions.RemoveEmptyEntries);
int[] num = Array.ConvertAll(numbers, int.Parse);
int count = 0;
for (int i =0; i < numbers.Length; i++)
{
    if (num[i] > 0)
    {
        count ++;
    }
}
Console.WriteLine($"Количество чисел больше нуля: {count}");


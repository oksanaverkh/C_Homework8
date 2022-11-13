// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
// 1 строка

Console.Clear();
Console.Write("Enter massive rows number: ");
int rows = GetValue();
Console.Write("Enter massive columns number: ");
int columns = GetValue();
Console.Write("Enter massive minimum number: ");
int minValue = GetValue();
Console.Write("Enter massive maximum number: ");
int maxValue = GetValue();
Console.WriteLine();

int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
Console.WriteLine();
RowsSum(array);

int GetValue()
{
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void RowsSum(int[,] arr)
{
    int min = maxValue*columns; // maximum possible sum of elements in each row
    int minRow = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        Console.WriteLine($"Sum of row {i} elements = {sum} ");
        if (sum < min)
        {
            min = sum;
            minRow = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Minimum sum of elements is in the row {minRow}");
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

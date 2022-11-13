// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
Console.Write("Enter massive minimum number: ");
int minValue = int.Parse(Console.ReadLine());

int[,] array = GetSpiredArray(4);
PrintArray(array);

int[,] GetSpiredArray(int n)
{
    int[,] result = new int[n, n];
    for (int currentValue = minValue, spire = 0; spire < n / 2; spire++)
    {
        for (int j = spire; j < n - spire; j++)
            result[spire, j] = currentValue++;

        for (int i = spire + 1; i < n - spire - 1; i++)
            result[i, n - spire - 1] = currentValue++;

        for (int j = n - spire - 1; j < n - spire && j > 0; j--)
            result[n - spire - 1, j] = currentValue++;

        for (int j = spire; j < n - spire && j == 0; j++)
            result[n - spire - 1, j] = currentValue++;

        for (int i = spire + 2; i < n - spire - 1; i++)
            result[i, spire] = currentValue++;

        for (int i = 0; i == spire; i++)
            result[spire + 1, spire] = currentValue++;
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] < 10) Console.Write($" 0{inArray[i, j]} ");
            if (inArray[i, j] >= 10) Console.Write($" {inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] array1 = GetArray(rows, columns, minValue, maxValue);
PrintArray(array1);
Console.WriteLine();
int[,] array2 = GetArray(rows, columns, minValue, maxValue);
PrintArray(array2);
Console.WriteLine();
ProductionMatrix();

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

int[,] ProductArray(int[,] arr1, int[,] arr2)
{
    int[,] prodArr = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            for (int ii = 0, jj = 0; ii < arr1.GetLength(0) && jj < arr1.GetLength(1); ii++, jj++)
            {
                prodArr[i, j] += arr1[i, jj] * arr2[ii, j];
            }
        }
    }
    return prodArr;
}

void ProductionMatrix()
{
    if (rows == columns)
    {
        Console.WriteLine("Resulting matrix:");
        int[,] productArray = ProductArray(array1, array2);
        PrintArray(productArray);
    }
    else Console.WriteLine("ERROR! Production is impossible");
}


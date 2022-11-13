// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
Console.Write("Enter massive length: ");
int rows = GetValue();
Console.Write("Enter massive width: ");
int columns = GetValue();
Console.Write("Enter massive height: ");
int height = GetValue();
Console.WriteLine();

int[,,] array = GetArray(rows, columns, height, 10, 99);
PrintArray(array);
Console.WriteLine();
CheckArray(array); //checking of repeated values
Console.WriteLine();

int GetValue()
{
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,,] GetArray(int m, int n, int p, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, p];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int z = 0; z < p; z++)
            {
                int temp = new Random().Next(minValue, maxValue + 1);
                int count = 0;
                for (int k = 0; k < m; k++)
                {
                    for (int l = 0; l < n; l++)
                    {
                        for (int q = 0; q < p; q++)
                            if (result[k, l, q] == temp) count++;
                    }
                }
                if (count < 1) result[i, j, z] = temp;
                else if (z>0) z = z-1;
                else if (j>0) j = j-1;
                else if (i>0) i = i-1;
            }
        }
    }
    return result;
}

void CheckArray(int[,,] arr)
{
    for (int n = 10; n < 100; n++)
    {
        int count = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int z = 0; z < arr.GetLength(2); z++)
                {
                    if (arr[i, j, z] == n)
                    {
                        count++;
                    }
                }
            }
        }
        if (count > 1) Console.WriteLine($"{n} meets {count} times in a massive"); ;
    }
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int z = 0; z < inArray.GetLength(2); z++)
            {
                Console.Write($"{inArray[i, j, z]} ({i},{j},{z}) ");
            }
        }
        Console.WriteLine();
    }
}

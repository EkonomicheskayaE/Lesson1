// Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

int n = 3;
int m = 4;

int [ , ] arr = new int [n, m];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(0,10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}


for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = arr.GetLength(1) - 1; k > j; k--)
    
        {
        if (arr[i, k] > arr[i, k - 1])
            {
            int max = arr[i, k];
            arr[i, k] = arr[i, k - 1];
            arr[i, k - 1] = max;
            }
        }
    }
    
}
Console.WriteLine();

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int k = 0; k < arr.GetLength(1); k++)
    {
        Console.Write(arr[i, k] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

int x = 3;
int y = 4;
int sum1 = 0;
int sum2 = 0;
int sum3 = 0;
int min = 0;

int [ , ] array = new int [x, y];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0,10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == 0) sum1 = sum1 + array[0, j];
        
        if (i == 1) sum2 = sum2 + array[i, j];
        
        if (i == 2) sum3 = sum3 + array[i, j];
        
    }
    
}
if (sum1 < sum2) min = min + sum1;
if (sum2 < sum1) min = min + sum2;
if (sum3 < min) min = min + sum3;

Console.WriteLine($"Строка с наименьей суммой элементов равна той, в которой сумма элементов равна {min}");
Console.WriteLine();

// Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.


    int[,] m1 = {
        {3, 2, 1},
        {5, 2, 1},
        {7, 2, 1},
    };
    int[,] m2 = {
        {1, 2, 4},
        {1, 3, 1},
        {1, 2, 4},
    };

    
    for (int i = 0; i < m1.GetLength(0); i++)
    {
        for (int j = 0; j < m1.GetLength(1); j++)
        {
            m1[i, j] = m1[i, j] * m2[i, j];
            Console.Write(m1[i, j] + " ");
            
        }
        Console.WriteLine();
    }
    Console.WriteLine();
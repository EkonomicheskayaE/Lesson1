// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

double [,] mass = new double [3, 4];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(-10, 10);
        Console.Write(mass[i, j]/2 + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

Console.WriteLine("Введите строку: ");
int A = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Введите столбец: ");
int B = Convert.ToInt32(Console.ReadLine()) - 1;

int str = 3;
int sto = 4;

int [,] array = new int [str, sto];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0,10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();


if(A < 0 | A >= array.GetLength(0) | B < 0 | B >= array.GetLength(1))
{
    Console.WriteLine($"Такого элемента нет!");
}
else
{
    Console.WriteLine($"Значение элемента массива = {array[A, B]}");
}
Console.WriteLine();

// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

int k = 3;
int l = 4;


int [ , ] arr = new int [k, l];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(0,10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < arr.GetLength(1); i++)
{
    double sum = 0;
    double sr = 0;
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        sum = sum + arr[j, i];
        sr = sum/k;

    }
    Console.Write($"Сумма элементов в столбце равна {sum}");
    Console.Write(" ");
    Console.Write($"Среднее арифметическое элементов в столбце равно {Math.Round(sr, 1)}");
    Console.WriteLine();
}

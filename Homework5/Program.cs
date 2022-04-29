// Задайте массив, заполненный случайными 3ёхзначными числами.
// Напишите программу, которая покажет кол-во чётных чисел в массиве.

//Console.Clear();

Console.WriteLine("Задача 34. Задаём массив заполненный случайными 3ёхзначными числами!");

void ma(int[] array)
{
    for (int i = 0; i<array.Length; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
}
int[] mass=new int[4];

Console.WriteLine();

for(int i=0; i<mass.Length; i++)
{
    mass[i]=new Random().Next(100, 999);
}
ma(mass);

int count = 0;

for(int i=0; i<mass.Length; i++)
{
    if (mass[i]%2 ==0) 
    {
        count++;
    }
  
}
Console.WriteLine($"Кол-во чётных чисел в массиве равно {count}.");
Console.WriteLine();

// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.

Console.WriteLine("Задача 36. Задаём одномерный массив, заполненный случайными числами!");

void collections(int[] ar)
{
    for (int i = 0; i<ar.Length; i++)
    {
        Console.WriteLine($"{ar[i]} ");
    }
}
int[] a=new int[4];

Console.WriteLine();

for(int i=0; i<a.Length; i++)
{
    a[i]=new Random().Next(-100, 100);
}
collections(a);

int sum = 0;
for (int i=0; i<a.Length; i++)
{
    if(i%2 != 0) sum = sum + a[i];
        
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sum}.");
Console.WriteLine();

// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементом массива.

Console.WriteLine("Задача 38. Задаём массив вещественных чисел!");

void col(int[] dl)
{
    for (int i = 0; i < dl.Length; i++)
    {
        Console.WriteLine($"{dl[i]} ");
    }
}
int[] size=new int[5];

for(int i=0; i<size.Length; i++)
{
    size[i]=new Random().Next(1, 100);
}
col(size);

int max = size[0];
int min = size[0];
int diff = 0;

for(int i = 0; i < size.Length; i++)
{
    if (size[i]>max) max = size[i];
      
    if (size[i]<min) min = size[i];
    diff = max - min;
      
}  
Console.WriteLine($"Максимальное значение в массиве равно {max}. ");
Console.WriteLine($"Минимальное значение в массиве равно {min}. ");
Console.WriteLine($"Разница между максимальным и минимальным значением равно {diff}.");


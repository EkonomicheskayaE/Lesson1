// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int B = Convert.ToInt32(Console.ReadLine());

double C = Math.Pow(A,B);

Console.WriteLine($"{A} в степени {B} = {C} ");

// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int a = 0;
for(int i = 0; i <= num; i++)
{
    a = num%10;
    num = (num-a) / 10;
    sum = sum + a;
}

Console.WriteLine($"Сумма цифр данного числа равна {sum}");

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void z(int[] array)
{
    for (int i = 0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
int[] mass= new int[8];

Console.WriteLine();

for(int i=0; i<mass.Length; i++)
{
mass[i]=new Random().Next(1,100);
}
z(mass);

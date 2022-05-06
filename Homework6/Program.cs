// Нужно ввести с клавиатуры М чисел.
// Посчитать сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через пробел: ");
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) count++;
}
Console.WriteLine($"Количество введённых пользователем чисел больше 0 равно {count}.");


// Напишите программу, которая найдёт точку пересечения двух прямых.
// Значения задаются пользователем.
// Уравнения y = k1*x + b1, y = k2*x + b2.

Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;

Console.WriteLine($"Точка пересечения двух прямых ({x};{y})");


// квадраты чисел
Console.WriteLine("Введите любое число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N <= 0)
{
    N = -N;
    Console.WriteLine("введите новое число:");
}
else
{
   int numbers = 1;

Console.WriteLine("Все квадраты чисел с одного по заданное число: ");

while (numbers <= N)
{
    Console.WriteLine(Math.Pow(numbers,2));
    numbers++;
}
}

int n = 9;
int i = 1;
while (i < n)
{
    Console.Write($"{i*i}, ");
    i++;
}
Console.WriteLine($"{i*i}. ");
Console.Clear();
Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = numberA / numberB;

if (numberA % numberB == 0)
{
    Console.WriteLine($"Кратно, результат: {result}");
}
else
{
    Console.WriteLine($"Не кратно, остаток от деления: {numberA % numberB}");
}
// остаток от деления
Console.Clear();
Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int numberB = 7;
int numberC = 23;

if ((numberA % numberB == 0) & (numberA % numberC == 0))
{
    Console.WriteLine($"Кратно {numberB} и {numberC}");
}
else
{
    Console.WriteLine($"Не кратно {numberB} и {numberC}");
}

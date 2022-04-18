// Третья цифра заданного числа, если есть.
Console.Clear();
Console.WriteLine("Введите любое число: ");
int X = Convert.ToInt32(Console.ReadLine());
if (X < 100)
{
    Console.WriteLine("Третьей цифры нет!");
}
else if (X > 99)
{
    Console.WriteLine(X.ToString()[2]);
}
    
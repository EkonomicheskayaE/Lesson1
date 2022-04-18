// Домашнее задание ко второму семинару.

Console.Write("Введите 3ёх значное число: ");
int M = Convert.ToInt32(Console.ReadLine());
int D = M/10;
int O = D%10;
Console.WriteLine($"Вторая цифра равна {O}");


int sum = new Random().Next(100, 999);
Console.WriteLine($"sum = {sum}");
int C1 = sum/100;
int C3 = sum%10;
Console.WriteLine($"Удаляем вторую цифру и получаем {C1}{C3}");


Console.WriteLine("Введите любое число: ");
int X = Convert.ToInt32(Console.ReadLine());
if (X < 100)
{
    Console.WriteLine("Третьей цифры нет!");
}
else if (X > 99)
{
    Console.Write("Третья цифра равна ");
    Console.WriteLine(X.ToString()[2]);
}


Console.WriteLine("Введите число от 1 до 7: ");
int G = Convert.ToInt32(Console.ReadLine());
if (G == 1)
{
    Console.WriteLine("Понедельник - это рабочий день (не является выходным).");
}
else if (G == 2)
{
    Console.WriteLine("Вторник - это рабочий день (не является выходным).");
}
else if (G == 3)
{
    Console.WriteLine("Среда - это рабочий день (не является выходным).");
}
else if (G == 4)
{
    Console.WriteLine("Четверг - это рабочий день (не является выходным).");
}
else if (G == 5)
{
    Console.WriteLine("Пятница - это рабочий день (не является выходным).");
}
else if (G == 6)
{
    Console.WriteLine("Суббота - это выходной день (является выходным).");
}
else if (G == 7)
{
    Console.WriteLine("Воскресенье - это выходной день (является выходным).");
}

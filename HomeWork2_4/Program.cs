// Находим выходной
Console.Clear();
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
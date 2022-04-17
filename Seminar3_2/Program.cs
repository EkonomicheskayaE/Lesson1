// определяем четверть
Console.Clear();
int r = new Random().Next (1,4);
Console.WriteLine($"r = {r}");
// int с = Convert.ToInt32(Console.ReadLine());

if (r == 1)
{
    Console.WriteLine("x > 0 b y > 0");
}
else if (r == 2)
{
    Console.WriteLine("x > 0 b y < 0");
}
else if (r == 3)
{
    Console.WriteLine("x < 0 b y < 0");
}
else if (r == 4)
{
    Console.WriteLine("x > 0 b y < 0");
}
else
{
    Console.WriteLine("ошибка, нет такой четверти");
}
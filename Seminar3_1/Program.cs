// Определение координаты на плоскости
Console.Clear();
Console.WriteLine("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());

if ((x>0) & (y>0))
{
    Console.WriteLine("точка в 1-й четверти");
}
if ((x>0) & (y<0))
{
    Console.WriteLine("точка в 4-й четверти");
}
if ((x<0) & (y>0))
{
    Console.WriteLine("точка в 2-й четверти");
}
if ((x<0) & (y<0))
{
    Console.WriteLine("точка в 3-й четверти");
}
if (x == 0 | y == 0)
{
    Console.WriteLine("ошибка");
}

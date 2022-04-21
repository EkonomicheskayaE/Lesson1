// Проверка пятизначного числа на полиндромность.
Console.Clear();
Console.WriteLine("Введите любое пятизначное число: ");
int F = Convert.ToInt32(Console.ReadLine());
int temp = F;
int rev = 0;
int dig;
while (F>0)
{
    dig = F%10;
    rev = rev*10+dig;
    F = F/10;
}
if (temp == rev)
{
    Console.WriteLine("Число является плиндромом");
}
else
{
    Console.WriteLine("Число не является плиндромом");
}

// Нахождение расстояния между точками в 3D пространстве.
Console.WriteLine("Введите значение координаты А1 ");
int A1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение координаты А2 ");
int A2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение координаты А3 ");
int A3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение координаты B1 ");
int B1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение координаты B2 ");
int B2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение координаты B3 ");
int B3 = Convert.ToInt32(Console.ReadLine());
double length = Math.Sqrt(Math.Pow(A1 - B1,2) + Math.Pow(A2 - B2,2) + Math.Pow(A3 - B3,2));
Console.WriteLine(length);

// Таблица кубов.

Console.WriteLine("Введите число: ");
int K = Convert.ToInt32(Console.ReadLine());

if (K<0)
{
    K = -K;
    Console.WriteLine("Введите другое число: ");
}
else
{
    int mean = 1;
    Console.WriteLine("Кубы чисел: ");

while (mean <= K)
{
   Console.WriteLine(Math.Pow(mean,3));
   mean++;
}
}
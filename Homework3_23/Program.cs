// Таблица кубов.
Console.Clear();
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
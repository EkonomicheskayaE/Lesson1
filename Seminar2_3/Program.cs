// int numberA = new Random().Next(1, 10);
int numberA = new Random().Next(10, 100);
Console.WriteLine(numberA);

int b = numberA / 10;
int c = numberA % 10;

if (b > c)
{
    Console.WriteLine($"большее число {b}");
}
else
{
    Console.WriteLine($"наибольшая цифра {c}");
}
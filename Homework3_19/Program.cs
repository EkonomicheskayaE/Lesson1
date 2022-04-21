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
// Программа, которая на вход принимает 3ёх значное число и показывает 2ую цифру этого числа.
Console.Clear();
Console.Write("Введите 3ёх значное число: ");
int M = Convert.ToInt32(Console.ReadLine());
int D = M/10;
int O = D%10;
Console.WriteLine($"Вторая цифра равна {O}");
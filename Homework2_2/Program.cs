// Выводим 3ёх значное число и удаляем вторую цифру.
Console.Clear();
int sum = new Random().Next(100, 999);
Console.WriteLine($"sum = {sum}");
int C1 = sum/100;
int C3 = sum%10;
Console.Write($"Удаляем вторую цифру и получаем {C1}{C3}");
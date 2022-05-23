// Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.
// M = 6; N = 2. -> "6, 5, 4, 3, 2"
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void SomeRec (int n, int m)
{
    if (n == m)
    {
        Console.Write(m);
        return;
    }

    else if (n < m)
    {
    Console.Write(n + " ");
    SomeRec(n + 1, m);
    }
    else
    {
    Console.Write(n + " ");
    SomeRec(n - 1, m);    
    }
}

SomeRec(m, n);

Console.WriteLine();
Console.WriteLine();

// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int SumRec (int m1, int n1)
{
    if (m1 <= n1) return m1;
    
    return  m1 + SumRec(m1 - 1, n1);
}

Console.Write($"Сумма элементов в промежутке от {m1} до {n1} равна {SumRec (n1, m1)}.");

Console.WriteLine();
Console.WriteLine();

// Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> Akkerman(m,n) = 29

int Akkerman(int n2, int m2)
{
    if (n2 == 0) return m2 + 1;

    else if(n2 > 0 && m2 == 0) return Akkerman(n2 - 1, 1);

    else return Akkerman(n2 - 1, Akkerman(n2, m2 - 1));
}
Console.WriteLine($"Функция Аккермана равна {Akkerman(2, 3)}.");

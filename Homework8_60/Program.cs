// Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

int x = 3;
int y = 3;
int z = 3;

int [ , , ] massA = new int[x, y, z];
int [] uni = new int[massA.Length];
bool ex = false;
int count = 0;

for (int i = 0; i < massA.GetLength(0); i++)
{
    for (int j = 0; j < massA.GetLength(1); j++)
    {
        for (int k = 0; k < massA.GetLength(2); k++)
        {
            massA[i, j, k] = new Random().Next(10, 100);
            ex = false;
                        
            for (int c = 0; c < count; c++)
            {
                if (massA[i, j, k] == uni[c])
                {
                    ex = true;
                    k--;
                    break;
                }
            }
            if (ex == false)
            {
               Console.Write($"{massA[i, j, k]}" + " ");
               
               Console.Write($"({i}, {j}, {k})" + " ");
               
               uni[count] = massA[i, j, k];
               count++;
            }
            
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}




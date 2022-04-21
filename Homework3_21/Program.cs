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
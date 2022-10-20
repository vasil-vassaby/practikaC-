// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки 1");
Console.Write("x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки 2");
Console.Write("x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double hypotenuse = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)); // вычисление квадратного корня из суммы квадратов катетов, чтобы найти гипотенузу
double result = Math.Round(hypotenuse, 2, MidpointRounding.ToZero); // округление значения до ближайшего целого числа или до определенного числа дробных цифр, в данном случае до сотых
Console.WriteLine($"A ({x1},{y1}); B ({x2},{y2}) -> {res}");

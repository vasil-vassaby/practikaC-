// Напишите программу, которая 
// принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Clear();
Console.WriteLine("Введите координаты точки A");
Console.Write("x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Vector(int xi, int yi, int zi, int xn, int yn, int zn)
{
    double vector = Math.Sqrt((xn - xi) * (xn - xi) + (yn - yi) * (yn - yi) + (zn - zi) * (zn - zi));
    return Math.Round(vector, 2, MidpointRounding.ToZero);
}

double ab = Vector(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {ab}");
// Напишите программу, которая 
// принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта
// точка.




Console.WriteLine("Введите координаты точки");
Console.Write("x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter(int xi, int yi)
{
    if (xi > 0 && yi > 0) return 1;
    if (xi < 0 && yi > 0) return 2;
    if (xi < 0 && yi < 0) return 3;
    if (xi > 0 && yi < 0) return 4;
    return 0;
}
int quarter = Quarter(x, y);
// 
string result = quarter > 0 
             ? $"Указанные координаты соответствуют четверти -> {quarter}"
             : "Введены некорректные координаты";
Console.Write(result);
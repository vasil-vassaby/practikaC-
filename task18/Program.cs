// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine()); // можно без конвертации


string Сoordinates(int num)
{
    if (num == 1) return "Координаты  точек в диапазоне x > 0, y > 0";
    if (num == 2) return "Координаты  точек в диапазоне x < 0, y > 0";
    if (num == 3) return "Координаты  точек в диапазоне x < 0, y < 0";
    if (num == 4) return "Координаты  точек в диапазоне x > 0, y < 0";
    return "Введены некорректные координаты";
}
string quarter = Сoordinates (number);

Console.Write(quarter);

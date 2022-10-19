// Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

bool Weekend (int num)
{
    if (num ==6 || num ==7) return true;
    return false;
}

Console.Clear();
Console.Write("Введите цифру: ");
int digit = Convert.ToInt32(Console.ReadLine());

if (digit<1 || digit > 7) Console.Write("Введите цифру от 1 до 7!");
else
{
bool result = Weekend(digit);
Console.Write($"Это выходной => ");
if (result) Console.Write("Да");
else Console.Write("Нет");
}
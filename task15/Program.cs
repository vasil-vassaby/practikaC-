// Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите цифру: ");
int digit = Convert.ToInt32(Console.ReadLine());

if (digit <=5) 
{
    Console.Write("Это выходной => ");
    Console.Write("Нет");
}
else if (digit > 5 && digit <= 7) 
{
    Console.Write("Это выходной => ");
    Console.Write("Да");
}
else Console.Write("Введите цифру от 1 до 7!");
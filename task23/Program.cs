// Напишите программу, которая 
// принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void TableOfCubes(int num) 
{
    for (int i = 1; i <= num; i++) Console.WriteLine($"{i, 2} | {Math.Pow(i, 3)}");
}

if (number > 0)
{
    Console.WriteLine($"Таблица кубов чисел от 1 до {number}");
    TableOfCubes(number);
}
else Console.WriteLine("Введите натуральное число!");

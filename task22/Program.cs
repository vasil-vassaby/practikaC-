// Напишите программу, которая
// принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// через цикл while
// void TableOfSquares(int num)
// {
//     int i = 1;
//     while(i <= num)
//     { 
//         Console.WriteLine($"|{i,4}||{i*i,4}|");
//         i++;
//     }
// }

// через цикл for
void TableOfSquares(int num)
{
for (int i = 1; i <= num; i++) Console.WriteLine($"|{i,4}||{i * i,4}|");
}

if (number > 0)
{
    Console.WriteLine($"Таблица квадратов чисел от 1 до {number}");
    TableOfSquares(number);
}
else Console.WriteLine("Введите натуральное число!");


// Напишите цикл, который 
// принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();

Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

numberB = Math.Abs(numberB);

int NumberInPower(int numA, int numB)
{
    int count = 0;
    int numC = 1;
    while (count < numB)
    {
        numC = numC * numA;
        count++;
    }
    return numC;
}

int numberInPower = NumberInPower(numberA, numberB);
Console.WriteLine($"Число {numberA} в натуральной степени {numberB} = {numberInPower}");
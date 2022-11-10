// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = { 6, 7, 19, 345, 3 }; // берем конкретный массив

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(i < arr.Length - 1 ? $"{arr[i]}," : $"{arr[i]}");
    }
    Console.WriteLine("]");
}

bool PresentNumberArray(int[] arr, int num)
{
    bool res = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            res = true;
            break;
        }
    }
    return res;
}

PrintArray(array);
bool result = PresentNumberArray(array, number);
Console.Write($"Заданное число {number} присутствует в массиве -> ");
Console.Write(result ? "Да" : "Нет");
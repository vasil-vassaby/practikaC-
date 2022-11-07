// напишите программу, которая 
//выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке


Console.Clear();
Console.Write("Введите количество элементов: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] NameArray(int num)
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int[] nameArray = NameArray(number);
PrintArray(nameArray);
// напишите программу кото принимает на вход число и проверяет кратно ли оно одновременно 7 и 23
// 14 - нет
//161 - да

bool DivNum(int digit, int num1, int num2)
{
    int res1 = digit%num1;
    int res2 = digit%num2;
    if (res1 == 0 && res2 == 0) return true;
    return false;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int number1 = 7;
int number2 = 23;

bool result = DivNum(num, number1, number2);
if (result) Console.Write("Кратно");
else Console.Write("Не кратно");

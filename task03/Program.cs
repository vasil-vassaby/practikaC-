// 3. Напишите программу, которая 
//будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1) Console.Write("Понедельник");
else if (number == 2) Console.Write("Вторник");
else if (number == 3) Console.Write("Среда");
else if (number == 4) Console.Write("Четверг");
else if (number == 5) Console.Write("Пятница");
else if (number == 6) Console.Write("Суббота");
else if (number == 7) Console.Write("Воскресенье");
else Console.Write("В неделе только 7 дней. Введите число от 1 до 7!");
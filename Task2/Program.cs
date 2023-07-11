Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 5 & number < 8)  Console.WriteLine("Сегодня выходной ");
if (number < 6) Console.WriteLine("Сегодня рабочий день");
if (number > 7) Console.WriteLine("В неделе только 7 дней");
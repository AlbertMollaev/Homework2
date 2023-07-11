Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100) Console.WriteLine("Это не трехзначное число");
if (number > 99 & number < 100000) {
    int result = number / 100 % 10;
    Console.WriteLine($"3 цифра числа {number} является: {result}");
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100) Console.WriteLine("Третьей цифры нету!");
if (number > 99 & number < 1000) {
    int result = number % 10;
    Console.WriteLine($"3 цифра числа {number} является: {result}");
} 
if (number > 999 & number < 10000) {
    int result = number / 10 % 10;
    Console.WriteLine($"3 цифра числа {number} является: {result}");     
}
if (number > 9999 & number < 100000) {
    int result = number / 100 % 10;
    Console.WriteLine($"3 цифра числа {number} является: {result}");
}
if (number > 99999 & number < 1000000) {
    int result = number / 1000 % 10;
    Console.WriteLine($"3 цифра числа {number} является: {result}");
}
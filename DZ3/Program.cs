// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).
double x, ostatok;
Console.WriteLine("Введите значение x ");
x = Convert.ToInt32(Console.ReadLine());
ostatok = x % 2;
if (ostatok == 0)
    Console.WriteLine("Четное число");
    else if (ostatok >= 1)
    Console.WriteLine("Нечетное число");
    
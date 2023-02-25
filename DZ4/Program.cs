// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
double N;
Console.WriteLine("Введите значение N ");
N = int.Parse(Console.ReadLine());
int i = 1;
while (i <= N)
 {
    if (i%2==0)
  {
    Console.Write(i+1);
}
    Console.Write("{0} ", ++i);
}
           
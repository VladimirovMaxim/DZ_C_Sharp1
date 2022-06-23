// Hапишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
while(count< num - 1)
{
    Console.Write(count +", ");
    count = count + 2;
}
if (count == num) Console.Write(count);
if (count == num-1) Console.Write (count);

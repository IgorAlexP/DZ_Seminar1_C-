/*Напишите програму, которая принимает на вход три числа и выдает максимальное из этих чисел*/

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
 int d = 0;

if (a > b)
{
    d = a;
}
else
{
    d = b;
}
if (d > c)
{
    Console.WriteLine(d);
}
else 
{
    Console.WriteLine(c);
}
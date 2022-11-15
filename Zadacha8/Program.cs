/* Задача 6 Напишите программу, которая на вход принимает число (N) а на выходе показывает все четные числа 
от 1 до N.*/

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;

while(count <= N)
{
    Console.WriteLine(count);
    count = count + 2;
}

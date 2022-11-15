/* Задача 6 Напишите программу, которая на вход принимает число и выдает, является ли число четным.*/

Console.WriteLine("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("ЭТО ЧИСЛО ЯВЛЯЕТСЯ ЧЕТНЫМ");
}
else
{
   Console.WriteLine("ЭТО ЧИСЛО НЕ ЯВЛЯЕТСЯ ЧЕТНЫМ"); 
}
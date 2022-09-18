// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите трех значное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if((num<100) || (num>1000))
{
    Console.WriteLine("Число не является трехзначным!");
}

int num1 = num%100;
int num2 = num1/10;

Console.WriteLine(num2);
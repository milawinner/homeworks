﻿Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 >= num2 & num1 >= num3)
{
    Console.Write(num1);
    Console.WriteLine(" - это самое большее число");
}
else
{
    if (num2 > num1 & num2 > num3)
{
    Console.Write(num2);
    Console.WriteLine(" - это самое большее число");
}
    else 
    {
        Console.Write(num3); 
        Console.WriteLine(" - это самое большее число");
        }
}

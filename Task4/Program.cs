﻿//Задача необязательная FIZZ BUZZ: 
// Напишите программу, которая выводит на экран числа 
// от 1 до 100. При этом вместо чисел, 
// кратных трем, программа должна выводить 
// слово Fizz, а вместо чисел, кратных пяти — 
// слово Buzz. Если число кратно пятнадцати, 
// то программа должна выводить слово FizzBuzz. 
// Задача может показаться очевидной, 
// но нужно получить наиболее простое и красивое решение.

int num = new Random().Next(1,100);
Console.WriteLine(num);

if (num%3==0)
{
    if (num%5==0)
    {
    Console.WriteLine("FizzBuzz");
    }
    else
    {
        Console.WriteLine("Fizz");
    }
}
else if (num%5==0)
{
    Console.WriteLine("Buzz");
}

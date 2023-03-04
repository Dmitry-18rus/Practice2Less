﻿// Задача необязательная 2:
// В институте биоинформатики по офису передвигается робот. Недавно студенты из группы программистов написали для него программу, по которой робот, 
//когда заходит в комнату, считает количество программистов в ней и произносит его вслух: "n программистов".
// Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.
// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), выводящее это число в консоль вместе с 
// правильным образом изменённым словом "программист", для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.
// В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает все случаи, как минимум до 1000 человек.

Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
if (n>0)
{
    if (((n==1) || (n%10==1)) && (n!=11) && (n%100!=11))
    {
        Console.WriteLine(n + " программ"+"ист");
    }
    else if (((n==2) || (n%10==2)) && (n!=12) && (n%100!=12))
    {
        Console.WriteLine(n + " программ"+"иста");
    }
    else if (((n==3) || (n%10==3)) && (n!=13) && (n%100!=13))
    {
        Console.WriteLine(n + " программ"+"иста");
    }
    else if (((n==4) || (n%10==4)) && (n!=14) && (n%100!=14))
    {
        Console.WriteLine(n + " программ"+"иста");
    }
    else if (((n>=5) && (n<=19)) || ((n%10>=5) && (n%10<=19)) || ((n%10==0)||(n%100==0)) ||((n%100>=5) && (n%100<=19)))
    {
        Console.WriteLine(n + " программ"+"истов");
    }
}
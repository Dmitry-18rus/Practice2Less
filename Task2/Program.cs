// Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
//Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
int res = num;
if (num >= 100)
{
    for (; res >= 1;)
    {
        res = res / 10;
        count++;
    }
    //Console.WriteLine("count = " + count);
    int res2 = num / Convert.ToInt32((Math.Pow(10, (count - 3))));
    //Console.WriteLine("res2 = " + res2);

    int res3 = res2 % 10;
    Console.WriteLine(res3);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.Clear ();
Console.WriteLine ("Введите число, чтобы узнать его третью цифру: ");
int number = int.Parse(Console.ReadLine());
if (number / 100 < 1)
{
    Console.WriteLine ("Третьей цифры нет");
}
else
{
    int a1 = (number % 1000 - number % 100) / 100;
    Console.WriteLine ($"третья цифра: {a1}");
}
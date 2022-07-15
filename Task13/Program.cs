// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите любое число");
int num = int.Parse(Console.ReadLine());
string srt = num.ToString();


if (srt.Length > 2)
{
    Console.WriteLine(srt[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
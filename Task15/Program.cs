// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число от 1 до 7");
int week = int.Parse(Console.ReadLine());

switch (week)
{
    case 1:
        Console.WriteLine("рабочий день");
        break;
    case 2:
        Console.WriteLine("рабочий день");
        break;
    case 3:
        Console.WriteLine("рабочий день");
        break;
    case 4:
        Console.WriteLine("рабочий день");
        break;
    case 5:
        Console.WriteLine("рабочий день");
        break;
    case 6:
        Console.WriteLine("выходной день");
        break;
    case 7:
        Console.WriteLine("выходной день");
        break;
    default:
        Console.WriteLine("Нет такого дня недели");
        break;
}
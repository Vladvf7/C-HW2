// Домашняя работа №2.
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// System.Console.WriteLine("Введите трех значное число ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num > 99 && num < 1000)
// {
//     System.Console.WriteLine(num / 10 % 10);
// }
// else 
// {
//     System.Console.WriteLine("Введено неверное значение");
// }


// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// System.Console.WriteLine("Введите число, имеющее больше 2-x символов");
// String str = Console.ReadLine()!;
// if (str!.Length > 2)
// {
// System.Console.WriteLine(str[2]);
// }
// else
// {
// System.Console.WriteLine("Введено не трёхзначное число");
// }

// Задача 15: напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяем является ли день выхсдньм.
// 6-> Да
// 7-> Да
// 1 -> Hет

Console.Write("Введите число дня недели от 1 до 7: ");
int number = int.Parse(Console.ReadLine()!);

if(number < 1 || number > 7) System.Console.WriteLine("Нет. Вы ввели неверное число! До встречи");
else if(number > 5) System.Console.WriteLine("Да, этот день выходной!");
else if(number > 1 || number < 5) System.Console.WriteLine("Нет, это рабочий день!");

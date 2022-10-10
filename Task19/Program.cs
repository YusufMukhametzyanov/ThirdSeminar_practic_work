/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
/*var s = "232";
if (s.Reverse().SequenceEqual(s)) Console.WriteLine("Палиндром!");*/

/*int[] array = { 2, 2, 3, 2, 2 };

int n = array.Length;


if (array[0] == array[4] && array[1] == array[3])

    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число не является палиндромом");*/

Console.Write("Введите пятизначное число: ");
 string a = Console.ReadLine();


if (a[0] == a[4] && a[1] == a[3])

    Console.WriteLine($"{a} -> да");
else
    Console.WriteLine($"{a} -> нет");


   




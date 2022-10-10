/* 
Задача 23
Напишите программу, которая на вход принимает число (N) и выдаёт таблицу кубов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25
2 -> 1, 4
*/

void GetNumber (int number)
{
    Console.Write($"{number} -> ");
    for (int i = 1; i <= number; i++)
    {
        double a = Math.Pow(i,3);
        Console.Write($" {a} ");
    }
}

Console.Write("Введите число:");
int b = int.Parse(Console.ReadLine());
GetNumber(b);
/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

void GetDistance(int X2, int X1, int Y2, int Y1, int Z2, int Z1)
{
    double result = 0;

    double X = Math.Pow(X2 - X1, 2); // Эта запись имеет значение формулы (x2 - x1)2 - (Функция Math.Pow это возведение некоего число в определённую степень)
    // (secondX - firstX)*(secondX-firstX) - Эта запись аналогичная верхней
    double Y = Math.Pow(Y2 - Y1, 2);
    double Z = Math.Pow(Z2 - Z1, 2);
    result = Math.Sqrt(X + Y + Z); // Функция Math.Sqrt это извлечение корня

    Console.WriteLine($"Расстояние между двумя точками в 3D пространстве = {result}");
}

GetDistance(1, 7, -1, -5, 9, 0);
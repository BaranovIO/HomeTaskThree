﻿/*
double FindDistance(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double distance = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
    return distance;
}

Console.Write("Введите координату х первого числа ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y первого числа ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z первого числа ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату х второго числа ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y второго числа ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z второго числа ");
double zB = Convert.ToDouble(Console.ReadLine());

double dist = Math.Round(FindDistance(xA, yA, zA, xB, yB, zB),2);

Console.WriteLine($"Расстояние между точкой А с координатами ({xA}, {xB}, {yB}) и точкой  B с координатами ({xB}, {yB}, {zB}) = {dist}");
*/


void FindCube(int N)
{
    int number = 1;

    while (number <= N)
    {
        Console.Write(Math.Pow(number, 3) + " ");
        number++;
    }
}

Console.Write("Введите число: ");
int cubeNumber = Convert.ToInt32(Console.ReadLine());

FindCube(cubeNumber);


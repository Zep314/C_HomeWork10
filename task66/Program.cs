// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N. M = 1; N = 15 -> 120 M = 4; N = 8. -> 30

using System;

int Summ(int m,int n)    // Рекурсивная функция, которая суммирует числа в промежутке m..n
{
    if (m>n)  // вдруг введут первое число больше второго
    {
        return 0;
    }
    else
    {
        return n + Summ(m,n-1);
    }
}

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма натуральных чисел в промежутке [{M}..{N}] равна {Summ(M,N)}");

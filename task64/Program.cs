// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N в обратном порядке. M = 1; N = 5. -> «5, 4, 3, 2, 1»

using System;

void PrintNatur(int m,int n)    // Рекурсивная функция, которая печатает очередное число из промежутка, 
{                               // и вызывает сама себя для печати следующего числа
  if (m>=n)  // вдруг введут первое число больше второго
  {
    Console.WriteLine(n);  // 
  }
  else
  {
    Console.WriteLine(n);
    PrintNatur(m,n-1);
  }
}

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

PrintNatur(M,N);

﻿// задача 45 - HARD необязательная. На вход программы подаются одно целое число. Составьте список чисел 
// Фибоначчи, в том числе для отрицательных индексов. Это по сути последовательность Негафибоначчи.
// Пример:
// для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

System.Console.WriteLine("Введите число");
double n = Convert.ToInt32(Console.ReadLine());
double NegaFibonacci(int n)
{
    if(n == -1) return 1;
    else if (n == -2) return -1;
    else return NegaFibonacci(n + 2) - NegaFibonacci(n + 1); 
}
for (int j = -8; j <= -1; j++) System.Console.Write(NegaFibonacci(j)+",");
System.Console.Write(0+",");

double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci (n-1) + Fibonacci(n-2); 
}
for (int i=1; i<=8; i++) System.Console.Write(Fibonacci(i)+",");



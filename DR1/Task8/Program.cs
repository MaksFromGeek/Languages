﻿Console.WriteLine("Введите любое целое число:");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= n)
{
    if (count % 2 == 0)
    {
        Console.Write(count + ", ");
        count++;
    }
    else
    {
        count++;
    }
}

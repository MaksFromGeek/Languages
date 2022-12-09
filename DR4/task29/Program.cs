// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.
Random rnd = new Random();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0,100);
    System.Console.WriteLine($"{array[i]} ");
}

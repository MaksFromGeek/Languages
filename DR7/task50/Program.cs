// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и 
// возвращает позицию этого элемента или же указание, что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int rows = 3;
int cols = 4;
int[,] array = new int[rows, cols];
Console.WriteLine("Введите число от 1 до 10, расположенное в нашей матрице");
int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк двумерного массива");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов двумерного массива");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
        {
            if (array[i, j] == m)
            {
                System.Console.Write(Convert.ToString(i, j));
            }
            else Console.Write("Такое число отсутствует в нашей марице");
            Console.WriteLine();
        }
    }

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
        {
            if (array[i, j] == m)
            {
                System.Console.Write(Convert.ToString(i, j));
            }
            else Console.Write("Такое число отсутствует в нашей марице");
            Console.WriteLine();
        }
    }
}



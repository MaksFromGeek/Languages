// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0;

void PrintArray(int[] array)
{
    foreach (int el in array) // этот цикл только для просмотра и тут нет индексов
        System.Console.Write($"{el} ");
    // for (int i = 0; i<array.Length; i++)
    // Console.Write($"{arrai[i]}");
    System.Console.WriteLine();
}
int CountNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
    return count;
}


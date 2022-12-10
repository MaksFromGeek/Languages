try
{
    Console.WriteLine("Введите число А:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B:");
    int b = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine($"Число А в степени В равно: {degree(a, b)}");
    

    int degree(int a, int b)
    {
        int result = 1;
        for (int i = 1; i <= b; i++) result = result * a;
        return result;
    }
}

catch
{
    System.Console.WriteLine("Надо было вводить целое число");
}


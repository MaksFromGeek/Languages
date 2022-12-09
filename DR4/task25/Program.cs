try
{
    Console.WriteLine("Введите первое число");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int b = Convert.ToInt32(Console.ReadLine());
    int result = 1;


    int amount(int a, int b)
    {

        for (int i = 0; i < b; i++)
        {
            result = result * a;
        }
        return result;
    }

    Console.WriteLine($"{amount(a, b)}");
}
catch
{
    Console.WriteLine("Надо было вводить именно целое число");
}


// Console.WriteLine("Введите число:"); 
// int num = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите степерь числа:"); 
// int pow = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine($"Число {num} в степени {pow} равно {Power(num, pow)}."); 
 
 
// int Power(int a, int b) 
// { 
//     int z = 1; 
//     for (int i = 1; i <= b; i++) 
//         z = z * a; 
//     return z; 
// }

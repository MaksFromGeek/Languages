System.Console.WriteLine("Введите целое число");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма цифр в веденном числе равна: {SumDigits(n)}");

int SumDigits(int n)
    {
        int sum = 0;
        int result = 0;
        for (int i = 1; n > 0; i++) 
        {
            result = n%10;
            sum = sum + result;
            n/=10;
        }
        return sum;
    }


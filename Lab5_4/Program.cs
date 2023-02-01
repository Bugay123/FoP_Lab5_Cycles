internal class Program
{
    /*  Дано натуральне число n. Обчислити суму перших n членів ряду:
        Результат вивести на консоль.*/

    private static void Main(string[] args)
    {
        Console.WriteLine("Введите натуральное число:");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for(int k = 1; k <= n; k++)
        {
            sum += (double)((k + 1) / k);
        }
        Console.WriteLine($"Результат: {sum}");
    }
}
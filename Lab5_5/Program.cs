internal class Program
{
    /*  Обчислити (n+1)!+5*n. Значення n ввести з консолі. Результат вивести
        на консоль.*/
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите n:");
        int n = int.Parse(Console.ReadLine());
        int fac = 0;
        if (n == 0)
        {
            Console.WriteLine("Результат: 1");
        }
        for (int a = 1; a <= n; a++)
        {
            fac = fac * (n + 1);
        }
        fac = fac + 5 * n;
        Console.WriteLine(fac);
    }
}
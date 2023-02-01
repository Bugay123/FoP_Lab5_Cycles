internal class Program
{

    /* Дано два цілих числа a,b (значення чисел ввести з консолі), a < b.
       Знайти суму квадратів всіх цілих від a до b включно.*/

    private static void Main(string[] args)
    {
        double sum = 0;
        Console.WriteLine("Введите а: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите b: ");
        int b = int.Parse(Console.ReadLine());
        while (a <= b)
        {
            sum = sum + Math.Pow(a, 2);
            a++;
        }
        Console.WriteLine(sum);
    }
}
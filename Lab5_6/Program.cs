internal class Program
{

    //Знайти найбільший спільний дільник чисел 25 і 15.

    private static void Main(string[] args)
    {
        int a = 25;
        int b = 15;
        int temp = 0;
        while (b != 0)
        {
            temp = b;
            b = a % b;
            a = temp;
        }
        Console.WriteLine($"Спільний дільник: {temp}");
    }
}
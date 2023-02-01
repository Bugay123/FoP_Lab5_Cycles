internal class Program
{

    /*  Обчислити значення в усіх точках функції на заданому відрізку [a,b].
        Вхідні дані ввести з консолі. Результат вивести на консоль.
        Функція F задається таким чином:
        F(x) = sin2x , x>0
        F(x) = 1+2sinx, x<=0*/

    private static void Main(string[] args)
    {
        Console.WriteLine("Введите максимальную границу:");
        int max = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите минимульную границу:");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("|  x  |  y   |");
        if(max > min)
        {
            
            for (int x = min; x <= max; x++)
            {
                double y = (x > 0) ? Math.Round(Math.Pow(Math.Sin(x), 2),2) : Math.Round(1 + 2 * Math.Sin(x), 2);
                Console.WriteLine($"|  {x}  |  {y}   |");
            }
        }
        else
        {
            Console.WriteLine("Ошибка");
        }
        
    }
}
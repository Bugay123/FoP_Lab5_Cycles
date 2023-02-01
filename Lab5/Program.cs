class Program
{
    private static void Main(string[] args)
    {
        double a, b, res;
        bool ok = true;
        char answer;

        do
        {
            Console.WriteLine("Введіть перший операнд: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть знак операції: ");
            char op = (char)Console.Read();
            Console.ReadLine();
            Console.WriteLine("Введіть другий операнд: ");
            b = double.Parse(Console.ReadLine());
        
            switch (op)
                {
                    case '+' : res = a + b; break;
                    case '-' : res = a - b; break;
                    case '*' : res = a * b; break;
                    case '/' : res = a / b; break;
                    default:
                    res = double.NaN; ok = false; break;
                }

            if (ok) Console.WriteLine("Результат: " + res);
            else Console.WriteLine("Неприпустима операція");

            Console.WriteLine("Завершити роботу? Введіть y, інакше enter");
            answer = (char)Console.Read();
            Console.ReadLine();
        } while (answer != 'y');
    }
}
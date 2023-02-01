internal class Program
{
    /* Написати програму, яка в залежності від порядкового номера місяця
       (1,2,...12) виводить на екран пору року(зима, весна....). Організувати
       цикл опитування «Бажаєте завершити?» до введення користувачем
       відповіді “y”.*/

    private static void Main(string[] args)
    {

        Console.WriteLine("Введите номер месяца:");
        int number = int.Parse(Console.ReadLine());

        char answer;
        do
        {

                switch (number)
            {
                case 1:
                    Console.WriteLine("Январь");
                break;
                case 2:
                    Console.WriteLine("Февраль");
                    break;
                case 3:
                    Console.WriteLine("Март");
                    break;
                case 4:
                    Console.WriteLine("Апрель");
                    break;
                case 5:
                    Console.WriteLine("Май");
                    break;
               case 6:
                    Console.WriteLine("Июнь");
                    break;
                case 7:
                    Console.WriteLine("Июль");
                    break;
                case 8:
                    Console.WriteLine("Август");
                    break;
                case 9:
                    Console.WriteLine("Сентябрь");
                    break;
                case 10:
                Console.WriteLine("Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Декабрь");
                    break;
               default:
                    Console.WriteLine("Ви ввели щось iнше");
                     break;
            }

            Console.WriteLine("Бажаєте завершити?");
            answer = char.Parse(Console.ReadLine());
        } while (answer != 'y');
    }
}
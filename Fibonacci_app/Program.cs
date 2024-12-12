using System.Text;

// Числа Фібоначчі

namespace Fibonacci_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введіть номер числа Фібоначчі.\nВхідний параметр: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Вихідне значення: {Fibonacci(number)}");
        }

        static int Fibonacci(int number)
        {
            if (number == 1)
            {
                return 0;
            }
            else if (number <= 3)
            {
                return 1;
            }
            else
            {
                return Fibonacci (number - 1) + Fibonacci(number - 2);
            }
        }
    }
}
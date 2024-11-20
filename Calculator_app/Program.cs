using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// Калькулятор, для арифметичних операцій з двома числами

try
{
    // Ініціалізація даних
    Console.Write("Введіть перше число: ");
    int first_number = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введіть друге число: ");
    int second_number = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введіть одну з операцій (+, -, *, /): ");
    string? math_operator = Console.ReadLine();

    // Виведення результату
    Console.Write($"{first_number} {math_operator} {second_number} = ");

    // Обчислення результату
    switch (math_operator)
    {
        case "+":
            Console.WriteLine(first_number + second_number);
            break;
        case "-":
            Console.WriteLine(first_number - second_number);
            break;
        case "*":
            Console.WriteLine(first_number * second_number);
            break;
        case "/":
            try
            {
                if (first_number % second_number == 0)
                {
                    Console.WriteLine(first_number / second_number);
                }
                else
                {
                    Console.WriteLine(Convert.ToDouble(first_number) / Convert.ToDouble(second_number));
                }
            }
            // Виняток: ділення на 0
            catch (DivideByZeroException)
            {
                Console.WriteLine("Помилка!");
                Console.WriteLine("На 0 ділити не можна!");
            }
            break;
        default:
            Console.WriteLine("Помилка!");
            Console.WriteLine("Оператор введено невірно!");
            break;
    }
}

// Виняток: некоректний формат
catch (FormatException)
{
    Console.WriteLine("Введено невірний формат числа!");
}
// Виняток переповнення
catch (OverflowException)
{
    Console.WriteLine("Ви ввели занадто велике число!");
}
// Інші винятки
catch (Exception)
{
    Console.WriteLine("Невідомий виняток!");
}
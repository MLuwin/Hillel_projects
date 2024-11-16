// Калькулятор, для арифметичних операцій з двома числами

// Ініціалізація даних
Console.Write("Введiть перше число: ");
int first_number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введiть друге число: ");
int second_number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введiть одну з арифметичних операцiй (+, -, *, /): ");
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
        // Перевірка ділення на ноль
        if(second_number == 0)
        {
            Console.WriteLine("Error");
            Console.WriteLine("На ноль дiлити не можна");
        }
        // Перевірка ділення без залишку
        else if (first_number % second_number != 0)
        {
            Console.WriteLine(Convert.ToDouble(first_number) / Convert.ToDouble(second_number));
        }
        else
        {
            Console.WriteLine(first_number / second_number);
        }
        break;
    default:
        Console.WriteLine("Error");
        Console.WriteLine("Оператор введено не вiрно!");
        break;
}
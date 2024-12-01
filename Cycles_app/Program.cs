using System.Text;
using System.Text.RegularExpressions;

Console.OutputEncoding = Encoding.UTF8;
int exception = 0;

try
{
    // 1. Обчислення середнього заробітку: 
    // Напишіть програму, яка запитує користувача про зарплату кожного працівника за місяць. 
    // Після отримання всіх значень програма має обчислити та вивести середній заробіток.

    exception++;
    Console.Write("1. Обчислення середнього заробітку\nВведіть кількість працівників: ");
    double countWorkers = double.Parse(Console.ReadLine());
    double salary, sumSalary = 0;

    for (int i = 0; i < countWorkers; i++)
    {
        Console.Write($"Введіть зарплату {i + 1} працівника: ");
        salary = double.Parse(Console.ReadLine());

        sumSalary += salary;
    }

    Console.WriteLine($"Середня зарплатня {countWorkers} працівників становить: {sumSalary / countWorkers}");
    Console.WriteLine();

    // 2. Побудова графіку зірочками: 
    // Напишіть програму, яка будує графік за допомогою зірочок. 
    // Користувач повинен ввести кількість рядків графіка. 
    // Кожен рядок графіка має містити відповідну кількість зірочок.

    exception++;
    Console.Write("2. Побудова графіку зірочками\nВведіть кількість рядків графіка: ");
    int row = int.Parse(Console.ReadLine());

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }

    Console.WriteLine();

    // 3. Генерація простих чисел: 
    // Напишіть програму, яка генерує прості числа від 1 до заданого користувачем числа. 
    // Просте число - це число, яке ділиться лише на 1 і на себе.

    exception++;
    Console.Write("3. Генерація простих чисел\nВведіть максимальне значення: ");
    int maxValue = int.Parse(Console.ReadLine());
    for (int i = 1; i <= maxValue; i++)
    {
        bool result = true;

        for (int j = 2; j <= i / 2; j++)
        {
            if (i % j == 0)
            {
                result = false;
                break;
            }
        }

        if (result)
        {
            Console.Write(i + " ");
        }
    }

    Console.WriteLine("\n");

    // 4. Перевірка паролю: 
    // Напишіть програму, яка перевіряє пароль користувача. 
    // Пароль вважається прийнятним, якщо він містить принаймні 8 символів, з яких принаймні один символ - це цифра, 
    // а також принаймні один символ - це спеціальний символ (наприклад, !, @, # тощо).

    exception++;
    Console.WriteLine("4. Перевірка паролю");
    string password = @"^(?=.*[a-zA-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$";

    while (true)
    {
        Console.Write("Введіть пароль, не меньше 8 символів, використовуючи букви, цифри та спецсимволи: ");
        string firstPassword = Console.ReadLine();
        if (Regex.IsMatch(firstPassword, password))
        {
            Console.Write("Повторіть введений пароль: ");
            string secondPassword = Console.ReadLine();
            bool result = firstPassword.Equals(secondPassword);

            if (result)
            {
                Console.WriteLine("Паролі однакові!");
            }
            else
            {
                Console.WriteLine("Паролі різні!");
            }
            break;
        }
        else
        {
            Console.WriteLine("Пароль введено не коректно!");
        }
    }

    Console.WriteLine();

    // 5. Генерація фібоначчівської послідовності: 
    // Напишіть програму, яка генерує перші N чисел Фібоначчі. 
    // Послідовність Фібоначчі починається з 0 і 1, а кожне наступне число є сумою двох попередніх чисел у послідовності

    exception++;
    Console.Write("5. Генерація фібоначчівської послідовності\nВведіть довжину послідовності: ");
    int maxFib = int.Parse(Console.ReadLine());
    int resultFib = 0,
        minCount = 0,
        maxCount = 1;

    for (int i = 1; i < maxFib; i++)
    {
        if (i == 1)
        {
            Console.Write(minCount + " " + maxCount + " ");
        }
        else if (i > 1)
        {
            resultFib = minCount + maxCount;
            Console.Write(resultFib + " ");

            minCount = maxCount;
            maxCount = resultFib;
        }
    }

    Console.WriteLine("\n");

    // 6. Калькулятор оплати праці за годину: 
    // Напишіть програму, яка запитує в користувача кількість годин, працюваних за день, та розмір годинної ставки. 
    // Після введення значень програма має обчислити та вивести оплату за день.

    exception++;
    Console.Write("6. Калькулятор оплати праці за годину\nВведіть кількість годин: ");
    int hour = int.Parse(Console.ReadLine());
    Console.Write("Введіть розмір годинної ставки: ");
    int hourSalary = int.Parse(Console.ReadLine());

    // Console.WriteLine("Оплата за день становить: " + hour * hourSalary);

    int resultSalary = 0;
    for (int i = 0; i < hour; i++)
    {
        resultSalary += hourSalary;
    }
    Console.WriteLine("Оплата за день становить: " + resultSalary);

    Console.WriteLine();

    // 7. Генерація таблиці множення для конкретного числа:
    // Напишіть програму, яка запитує в користувача число, а потім генерує таблицю множення для цього числа від 1 до 10.

    exception++;
    Console.Write("7. Генерація таблиці множення\nВведіть будь-яке ціле число: ");

    int multiTableValue = int.Parse(Console.ReadLine());
    int multiTableResult;

    for (int i = 1; i <= 10; i++)
    {
        multiTableResult = i * multiTableValue;
        Console.WriteLine($"{i} * {multiTableValue} = {multiTableResult}");
    }

    Console.WriteLine();

    // 8. Перевірка на простоту:
    // Напишіть програму, яка перевіряє, чи є задане користувачем число простим.
    // Число вважається простим, якщо воно ділиться лише нв 1 і на себе.

    exception++;
    Console.Write("8. Перевірка на простоту\nВведіть будь-яке ціле число: ");

    int prime = int.Parse(Console.ReadLine());
    bool primeResult = true;

    for (int i = 2; i <= prime / 2; i++)
    {
        if (prime % i == 0)
        {
            primeResult = false;
            break;
        }
    }

    if (primeResult)
    {
        Console.WriteLine("Це просте число!");
    }
    else
    {
        Console.WriteLine("Це не просте число!");
    }


}
catch (ArgumentNullException)
{
    Console.WriteLine($"Виник виняток \"ArgumentNullException\" в {exception} програмі!");
}
catch (FormatException)
{
    Console.WriteLine($"Виник виняток \"FormatException\" в {exception} програмі!");
}
catch (OverflowException)
{
    Console.WriteLine($"Виник виняток \"OverflowException\" в {exception} програмі!");
}
catch (IOException)
{
    Console.WriteLine($"Виник виняток \"IOException\" в {exception} програмі!");
}
catch (Exception)
{
    Console.WriteLine($"Виник невідомий виняток в {exception} програмі!");
}
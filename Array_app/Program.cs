using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 1.Створити масив із 10 елементів типу int. Присвоїти їм випадкові значення від -10 до 10,
// використовуючи клас Random (https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-8.0)
// Вивести на екран елементи масиву з парним індексом. (не парні значення, а саме парні індекси!!)

Console.WriteLine("1. Елементи масиву з парним індексом.\n");
int[] numbers = new int[10];
Random random = new Random();

Console.Write("Отриманий масив: ");

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(-10, 10);
    Console.Write(numbers[i] + " ");
}

Console.WriteLine("\n");

for (int i = 2; i < numbers.Length; i += 2)
{
    Console.WriteLine(i + " елемент масиву = " + numbers[i]);
}

Console.WriteLine();

// 2.Визначити, чи вірно, що сума елементів масиву з пункту 1 є невід'ємне число.

Console.WriteLine("2. Сума елементів масиву.\n");
int sumArray = 0;

foreach (int elem in numbers)
{
    sumArray += elem;
}

if (sumArray >= 0)
{
    Console.WriteLine(sumArray + " - невід'ємне число");
}
else
{
    Console.WriteLine(sumArray + " - від'ємне число");
}

Console.WriteLine();

// 3. Створити та заповнити двовимірний масив розміру 9х9 з результатами таблиці множення
// (у першому рядку мають бути записані добутки кожного з чисел від 1 до 9 на 1, у другому – на 2, ..., в останньому – на 9).
// Тобто в 1 строчці будуть значення від 1 до 9, а у другому 2,4,6,....,18 і т.д.

Console.WriteLine("3. Двовимірний масив розміру 9х9.\n");

int[,] nineArray = new int[9, 9];

int nineRows = nineArray.GetUpperBound(0);
int nineCols = nineArray.GetUpperBound(1);

for (int i = 0; i <= nineRows; i++)
{
    for (int j = 0; j <= nineCols; j++)
    {
        nineArray[i, j] = (i + 1) * (j + 1);

        if (nineArray[i, j] < 10 && j > 0)
        {
            Console.Write(" ");
        }

        Console.Write(nineArray[i, j] + " ");
    }
    Console.WriteLine();
}

// 4. Створити двовимірний масив 5х5. Заповнити його будь-якими числами.
// Визначити та вивести на екран: а) максимальний елемент масиву; б) мінімальний елемент масиву;
// в) координати мінімального елемента масиву. г) координати максимального елемента масиву.

Console.WriteLine("\n4. Двовимірний масив розміру 5х5.\n");

int[,] fiveArray = new int[5, 5];

int fiveRows = fiveArray.GetUpperBound(0);
int fiveCols = fiveArray.GetUpperBound(1);

for (int i = 0; i <= fiveRows; i++)
{
    for (int j = 0; j <= fiveCols; j++)
    {
        fiveArray[i, j] = random.Next(0, 99);

        if (fiveArray[i, j] < 10)
        {
            Console.Write(" ");
        }

        Console.Write(fiveArray[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

int minValue = fiveArray[0, 0], maxValue = fiveArray[0, 0];
int minRow = 0, minCol = 0;
int maxRow = 0, maxCol = 0;

for (int i = 0; i <= fiveRows; i++)
{
    for (int j = 0; j <= fiveCols; j++)
    {
        if (fiveArray[i, j] < minValue)
        {
            minValue = fiveArray[i, j];
            minRow = i;
            minCol = j;
        }
        else if (fiveArray[i, j] > maxValue)
        {
            maxValue = fiveArray[i, j];
            maxRow = i;
            maxCol = j;
        }
    }
}

Console.WriteLine($"Мінімальний елемент масиву = {minValue}, за координатами {minRow} {minCol}");
Console.WriteLine($"Максимальний елемент масиву = {maxValue}, за координатами {maxRow} {maxCol}");

// 5. За допомогою enum створити програму, що буде запитувати у користувача кількість днів,
// а потім рахувати який буде день через введену кількість, якщо рахувати від понеділка і виводити результат. Наприклад: 
// Приклад 1: Вхідний параметр: 13 Очікуваний вивід: Sunday
// Приклад 2: Вхідний параметр: 3 Очікуваний вивід: Thursday

Console.Write("\n5. Кількість днів.\nВведіть кількість днів: ");
int enterDay = int.Parse(Console.ReadLine());

int daysNumber = enterDay % 7;
WeekDays Days = (WeekDays)daysNumber;

switch (Days)
{
    case WeekDays.Saturday:
        Console.WriteLine(WeekDays.Saturday);
        break;
    case WeekDays.Monday:
        Console.WriteLine(WeekDays.Monday);
        break;
    case WeekDays.Tuesday:
        Console.WriteLine(WeekDays.Tuesday);
        break;
    case WeekDays.Wednesday:
        Console.WriteLine(WeekDays.Wednesday);
        break;
    case WeekDays.Thursday:
        Console.WriteLine(WeekDays.Thursday);
        break;
    case WeekDays.Friday:
        Console.WriteLine(WeekDays.Friday);
        break;
    case WeekDays.Sunday:
        Console.WriteLine(WeekDays.Sunday);
        break;
}
public enum WeekDays
{
    Saturday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Sunday
}
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

// 10.1. Перевiрити ім’я та прізвище.

Console.WriteLine($"10.1 Перевiрка ім’я та прізвища");

Console.Write("Введіть ім'я та прізвище: ");
string? fullName = Console.ReadLine();

int indexFirstName = fullName.IndexOf(" ");

if (indexFirstName == -1)
{
    Console.WriteLine("Некоректний ввід");
}
else
{
    if (fullName.Substring(0, 1) == fullName.Substring(indexFirstName + 1, 1))
    {
        Console.WriteLine("Прізвище починається на ту ж літеру, що і ім’я");
    }
    else
    {
        Console.WriteLine("Прізвище не починається на ту ж літеру, що і ім’я");
    }
}
Console.WriteLine();

// 10.2. Генерації текстового звіту.

StringBuilder myReport = new StringBuilder();

for (int i = 0; i < 5; i++)
{
    DateTime dateTime = DateTime.Now;
    Console.WriteLine($"\t\t\t10.2 Звіт.\nВведіть подію №{i + 1}:");

    myReport.Append($"{i + 1}. " +
                    $"{dateTime.ToString("dd/MMM HH:mm")} - " +
                    $"{Console.ReadLine()}\n");
    Console.Clear();
}

Console.WriteLine($"\t\t\t10.2 Звіт.\n{myReport}");

// 10.3. Видалення пробілiв.

Console.WriteLine("10.3 Видалення пробілів.");
Console.Write("Введіть декілька слів, розділяючи їх \',\': ");
string? withSpaces = Console.ReadLine();
string? withoutSpaces = withSpaces.Replace(" ", "");
Console.WriteLine($"Після видалення пробілів: {withoutSpaces}");
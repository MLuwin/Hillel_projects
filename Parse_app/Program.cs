using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// Запит на введення числа
Console.Write("Введіть число (ціле або з плаваючою комою): ");
string number = Console.ReadLine();

// Робота з типом byte
try
{
    byte result = Convert.ToByte(number);
    Console.WriteLine("byte - " + result);
}
catch (FormatException)
{
    Console.WriteLine("byte - Введено неправильний формат числа!");
}
catch (OverflowException)
{
    Console.WriteLine("byte - Число занадто велике!");
}
catch (Exception)
{
    Console.WriteLine("byte - Невідоме виключення");
}

// Робота з типом short
try
{
    short result = Convert.ToInt16(number);
    Console.WriteLine("short - " + result);
}
catch (FormatException)
{
    Console.WriteLine("short - Введено неправильний формат числа!");
}
catch (OverflowException)
{
    Console.WriteLine("short - Число занадто велике!");
}
catch (Exception)
{
    Console.WriteLine("short - Невідоме виключення");
}

// Робота з типом int
try
{
    int result = Convert.ToInt32(number);
    Console.WriteLine("int - " + result);
}
catch (FormatException)
{
    Console.WriteLine("int - Введено неправильний формат числа!");
}
catch (OverflowException)
{
    Console.WriteLine("int - Число занадто велике!");
}
catch (Exception)
{
    Console.WriteLine("int - Невідоме виключення");
}

// Робота з типом long
try
{
    long result = Convert.ToInt64(number);
    Console.WriteLine("long - " + result);
}
catch (FormatException)
{
    Console.WriteLine("long - Введено неправильний формат числа!");
}
catch (OverflowException)
{
    Console.WriteLine("long - Число занадто велике!");
}
catch (Exception)
{
    Console.WriteLine("long - Невідоме виключення");
}

// Робота з типом float
try
{
    float result = Convert.ToSingle(number);
    Console.WriteLine("float - " + result);
}
catch (FormatException)
{
    Console.WriteLine("float - Введено неправильний формат числа!");
}
catch (OverflowException)
{
    Console.WriteLine("float - Число занадто велике!");
}
catch (Exception)
{
    Console.WriteLine("float - Невідоме виключення");
}

// Робота з типом double
try
{
    double result = Convert.ToDouble(number);
    Console.WriteLine("double - " + result);
}
catch (FormatException)
{
    Console.WriteLine("double - Введено неправильний формат числа!");
}
catch (OverflowException)
{
    Console.WriteLine("double - Число занадто велике!");
}
catch (Exception)
{
    Console.WriteLine("double - Невідоме виключення");
}

// Робота з типом decimal
try
{
    decimal result = Convert.ToDecimal(number);
    Console.WriteLine("decimal - " + result);
}
catch (FormatException)
{
    Console.WriteLine("decimal - Введено неправильний формат числа!");
}
catch (OverflowException)
{
    Console.WriteLine("decimal - Число занадто велике!");
}
catch (Exception)
{
    Console.WriteLine("decimal - Невідоме виключення");
}
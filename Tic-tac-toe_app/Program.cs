// 7. Гра Хрестики-нолики.

using System.Text;

Console.OutputEncoding = Encoding.UTF8;

try
{
    char[] ticTacToe = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    int plaer = 1; // 1й гравець - непарні числа, 2й гравець - парні
    bool cellFull = false;

    do
    {
        Console.Clear();

        Console.WriteLine("7. Гра Хрестики-нолики.\n");
        Console.WriteLine("Перший гравець - 'X'.\nДругий гравець - 'O'.\n");

        // Виведення ігрового поля
        Console.WriteLine($" {ticTacToe[0]} | {ticTacToe[1]} | {ticTacToe[2]}");
        Console.WriteLine("-----------");
        Console.WriteLine($" {ticTacToe[3]} | {ticTacToe[4]} | {ticTacToe[5]}");
        Console.WriteLine("-----------");
        Console.WriteLine($" {ticTacToe[6]} | {ticTacToe[7]} | {ticTacToe[8]}");

        // Перевірка на перемогу або нічию
        if (ticTacToe[0] == ticTacToe[1] && ticTacToe[1] == ticTacToe[2] ||
                ticTacToe[3] == ticTacToe[4] && ticTacToe[4] == ticTacToe[5] ||
                ticTacToe[6] == ticTacToe[7] && ticTacToe[7] == ticTacToe[8] ||
                ticTacToe[0] == ticTacToe[3] && ticTacToe[3] == ticTacToe[6] ||
                ticTacToe[1] == ticTacToe[4] && ticTacToe[4] == ticTacToe[7] ||
                ticTacToe[2] == ticTacToe[5] && ticTacToe[5] == ticTacToe[8] ||
                ticTacToe[0] == ticTacToe[4] && ticTacToe[4] == ticTacToe[8] ||
                ticTacToe[2] == ticTacToe[4] && ticTacToe[4] == ticTacToe[6])
        {
            Console.WriteLine($"\nПереміг {plaer % 2 + 1}й гравець!");
            break;
        }
        else if (ticTacToe[0] != '1' && ticTacToe[1] != '2' && ticTacToe[2] != '3' &&
            ticTacToe[3] != '4' && ticTacToe[4] != '5' && ticTacToe[5] != '6' &&
            ticTacToe[6] != '7' && ticTacToe[7] != '8' && ticTacToe[8] != '9')
        {
            Console.WriteLine($"\nНічия!");
            break;
        }

        if (plaer % 2 == 0)
        {
            Console.WriteLine("\nХодить 2й гравець.");
        }
        else
        {
            Console.WriteLine("\nХодить 1й гравець.");
        }

        // Якщо вибрана клітинка зайнята
        if (cellFull)
        {
            Console.WriteLine("\nКлітинка вже зайнята!");
            cellFull = false;
        }

        Console.Write("\nВведіть число від 1 до 9: ");
        int cell = int.Parse(Console.ReadLine());

        // Перевірка чи зайнята вибрана клітина
        if (ticTacToe[cell - 1] != 'X' && ticTacToe[cell - 1] != 'O')
        {
            if (plaer % 2 == 0)
            {
                ticTacToe[cell - 1] = 'O';
                plaer++;
            }
            else
            {
                ticTacToe[cell - 1] = 'X';
                plaer++;
            }
        }
        else
        {
            cellFull = true;
        }
    }
    while (true);
}
catch (ArgumentNullException)
{
    Console.WriteLine("Ви передали порожнє значення!");
}
catch (FormatException)
{
    Console.WriteLine("Невірний формат даних!");
}
catch (OverflowException)
{
    Console.WriteLine("Виняток переповнення!");
}
catch (Exception)
{
    Console.WriteLine("Невідовий виняток!");
}
// 7. Гра Хрестики-нолики.

using System.Text;

Console.OutputEncoding = Encoding.UTF8;

try
{
    char[] ticTacToe = new char[9];
    for (int i = 0; i < ticTacToe.Length; i++)
    {
        ticTacToe[i] = '*';
    }

    int plaer = 1; // 1й гравець - непарні числа, 2й гравець - парні
    bool cellFull = false, number = false;
    char winer = 'X';
    int draw;

    do
    {
        Console.Clear();

        Console.WriteLine("7. Гра Хрестики-нолики.\n");
        Console.WriteLine("Перший гравець - 'X'.\nДругий гравець - 'O'.\n");

        // Виведення ігрового поля
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($" {ticTacToe[i * 3 + j]}");
                if (j < 2)
                {
                    Console.Write(" |");
                }
            }
            if (i < 2)
            {
                Console.WriteLine("\n-----------");
            }
        }

        Console.WriteLine();

        // Перевірка на перемогу або нічию
        draw = 0;
        for (int i = 0; i < ticTacToe.Length; i++)
        {
            if (ticTacToe[i] == '*')
            {
                draw++;
                break;
            }
        }

        if (ticTacToe[0] == winer && ticTacToe[1] == winer && ticTacToe[2] == winer ||
            ticTacToe[3] == winer && ticTacToe[4] == winer && ticTacToe[5] == winer ||
            ticTacToe[6] == winer && ticTacToe[7] == winer && ticTacToe[8] == winer ||
            ticTacToe[0] == winer && ticTacToe[3] == winer && ticTacToe[6] == winer ||
            ticTacToe[1] == winer && ticTacToe[4] == winer && ticTacToe[7] == winer ||
            ticTacToe[2] == winer && ticTacToe[5] == winer && ticTacToe[8] == winer ||
            ticTacToe[0] == winer && ticTacToe[4] == winer && ticTacToe[8] == winer ||
            ticTacToe[2] == winer && ticTacToe[4] == winer && ticTacToe[6] == winer)
        {
            Console.WriteLine($"\nПереміг {plaer % 2 + 1}й гравець!");
            break;
        }
        else if (draw == 0)
        {
            Console.WriteLine($"\nНічия!");
            break;
        }

        if (plaer % 2 == 0)
        {
            Console.WriteLine("\nХодить 2й гравець.");
            winer = 'O';
        }
        else
        {
            Console.WriteLine("\nХодить 1й гравець.");
            winer = 'X';
        }

        // Якщо ввели невірний номер
        if (number)
        {
            Console.WriteLine("\nНомер клітинки введено не вірно!");
            number = false;
        }

        // Якщо вибрана клітинка зайнята
        if (cellFull)
        {
            Console.WriteLine("\nКлітинка вже зайнята!");
            cellFull = false;
        }

        Console.Write("\nВведіть число від 1 до 9: ");
        int cell = int.Parse(Console.ReadLine());

        // Перевірка коректності вводу номера клітинки
        if (cell >= 1 && cell <= 9)
        {
            // Перевірка чи зайнята вибрана клітинка
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
        else
        {
            number = true;
        }
    }
    while (true);
}
catch (ArgumentNullException)
{
    Console.WriteLine("\nВи передали порожнє значення!");
}
catch (FormatException)
{
    Console.WriteLine("\nНевірний формат даних!");
}
catch (OverflowException)
{
    Console.WriteLine("\nВиняток переповнення!");
}
catch (Exception)
{
    Console.WriteLine("\nНевідовий виняток!");
}
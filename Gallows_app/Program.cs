using System.Text;

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.GetEncoding(1251);
Random random = new Random();

// 7. Гра "Шибениця"

Console.WriteLine("Вітаю у грі Шибениця!\nСпробуйте вгадати зашифроване слово!\n");

List<string> gallows = ["лекція", "собака", "табуретка", "квіти", "термос", "доміно", "карбюратор"];
string usingWord = gallows[random.Next(gallows.Count)];
char[] letters = usingWord.ToCharArray();
List<char> usedLetters = new List<char>();
int winner = 0, loser = letters.Length;

Console.WriteLine($"Кількість літер у слові: {letters.Length}");
Console.WriteLine($"Кількість можливих невірних спроб: {loser}\n");

do
{
    Console.Write("Введіть вашу літеру: ");
    char usersLetter = char.Parse(Console.ReadLine());
    int counter = 0;

    if (usedLetters.Contains(usersLetter))
    {
        Console.WriteLine($"Ви вже вводили літеру {usersLetter}!");
    }
    else
    {
        if (letters.Contains(usersLetter))
        {
            Console.Write($"Така літера є у слові! Позиція літери: ");
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] == usersLetter)
                {
                    if(counter > 0)
                    {
                        Console.Write(", ");
                    }
                    Console.Write($"{i + 1}");
                    counter++;
                    winner++;
                }
            }
            usedLetters.Add(usersLetter);
            Console.WriteLine();
        }
        else
        {
            loser--;
            Console.Write($"Такої літери немає! Залишилось спроб: {loser}\n");
            usedLetters.Add(usersLetter);
        }
    }
}
while (loser != 0 && winner != letters.Length);

if (loser == 0)
{
    Console.WriteLine($"\nВи не вгадали слово! Зашифроване слово: {usingWord}");
}
else if (winner == letters.Length)
{
    Console.WriteLine($"\nВітаю, ви вгадали слово! Зашифроване слово: {usingWord}");
}
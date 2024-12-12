using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Random random = new Random();

// 7. Гра "Шибениця"

Console.WriteLine("Вітаю у грі Шибениця!\nСпробуйте вгадати зишифроване слово!");

List<string> gallows = ["шибениця", "собака", "табуретка", "квіти", "термос", "доміно", "карбюратор"];
string word = gallows[random.Next(gallows.Count)];

Console.WriteLine(word);

Console.WriteLine("Кількість літер у слові: ");
Console.WriteLine("Кількість можливих невірних спроб: ");
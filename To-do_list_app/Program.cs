// 13.1 Список справ

using System.Text;

namespace To_do_list_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.GetEncoding(1251);

            try
            {
                Console.WriteLine("\tСписок справ!\n");
                List<string> toDoList = new List<string>();
                bool exit = true;

                do
                {
                    Console.WriteLine(
                        "Введіть необхідну команду:\n" +
                        "add - додати справу в список\n" +
                        "print - показати список справ\n" +
                        "done - помітити справу як виконану\n" +
                        "delete - видалити справу\n" +
                        "exit - завершити програму\n");
                    string? command = Console.ReadLine();

                    switch (command.ToLower())
                    {
                        case "add":
                            AddMyList(toDoList);
                            break;
                        case "print":
                            PrintMyList(toDoList);
                            break;
                        case "done":
                            DoneMyList(toDoList);
                            break;
                        case "delete":
                            DeleteMyList(toDoList);
                            break;
                        case "exit":
                            exit = false;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Команду введено не вірно!\n");
                            break;
                    }
                }
                while (exit);

            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverflowException!");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException!");
            }
            catch (Exception)
            {
                Console.WriteLine("Невідомий Exception!");
            }
        }

        // 1. Додавання справи
        static void AddMyList(List<string> addList)
        {
            Console.Clear();
            Console.Write("Введіть назву справи: ");
            string? caseName = Console.ReadLine();
            Console.Write("\nВведіть опис справи: ");
            string? caseDescription = Console.ReadLine();

            addList.Add(caseName + "\n   " + caseDescription);

            Console.Clear();
            Console.WriteLine("\tСписок справ!\n");
        }

        // 2. Виведення всіх справ
        static void PrintMyList(List<string> printList)
        {
            Console.Clear();

            if (printList.Count > 0)
            {
                Console.WriteLine("\tСписок справ!\n");
                for (int i = 0; i < printList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {printList[i]}\n");
                }
            }
            else
            {
                Console.WriteLine("Список справ пустий!\n");
            }
        }

        // 3. Відмітка про виконання
        static void DoneMyList(List<string> doneList)
        {
            Console.Clear();
            Console.Write("Введіть номер виконаної справи: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0 && number <= doneList.Count)
            {
                doneList[number - 1] = "ВИКОНАНО!\n   " + doneList[number - 1];
            }
            else
            {
                Console.WriteLine("Номер справи введено не вірно!");
            }

            Console.Clear();
            Console.WriteLine("\tСписок справ!\n");
        }

        // 4. Видалення справи
        static void DeleteMyList(List<string> deleteList)
        {
            Console.Clear();
            Console.Write("Введіть номер справи яку треба видалити: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0 && number <= deleteList.Count)
            {
                deleteList.RemoveAt(number - 1);
            }
            else
            {
                Console.WriteLine("Номер справи введено не вірно!");
            }

            Console.Clear();
            Console.WriteLine("\tСписок справ!\n");
        }
    }
}

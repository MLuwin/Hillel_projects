using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Random random = new Random();

// 1. Написати програму, що знаходить другий найбільший елемент масиву.

Console.WriteLine("1. Знайти другий найбільший елемент масиву.\n");

int[] array = new int[10];
int maxValue = 0, twoMaxValue = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0, 99);
    Console.Write($"{array[i]} ");
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > maxValue)
    {
        twoMaxValue = maxValue;
        maxValue = array[i];
    }
    else if (array[i] > twoMaxValue)
    {
        twoMaxValue = array[i];
    }
}

Console.WriteLine($"\n\nНайбільший елемент масиву = {maxValue}\nДругий найбільший елемент = {twoMaxValue}\n");

// 2. Написати програму, що буде сортувати за зростанням елементи двовимірного масиву.

Console.WriteLine("2. Відсортувати елементи масиву за зростанням.\n");

int[,] arraySort = new int[10, 10];

// Ініціалізація масиву
for (int i = 0; i <= arraySort.GetUpperBound(0); i++)
{
    for (int j = 0; j <= arraySort.GetUpperBound(1); j++)
    {
        arraySort[i, j] = random.Next(0, 99);

        if (arraySort[i, j] < 10)
        {
            Console.Write(" ");
        }
        Console.Write(arraySort[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("\nВідсортований масив:\n");

// Сортування масиву
for (int k = 0; k < arraySort.Length; k++)
{
    bool isSorted = true;
    int i, j;

    for (i = 0; i <= arraySort.GetUpperBound(0); i++)
    {
        for (j = 0; j < arraySort.GetUpperBound(1); j++)
        {
            if (arraySort[i, j] > arraySort[i, j + 1])
            {
                (arraySort[i, j + 1], arraySort[i, j]) = (arraySort[i, j], arraySort[i, j + 1]);
                isSorted = false;
            }
        }

        if (i < arraySort.GetUpperBound(0) && arraySort[i, j] > arraySort[i + 1, 0])
        {
            (arraySort[i + 1, 0], arraySort[i, j]) = (arraySort[i, j], arraySort[i + 1, 0]);
            isSorted = false;
        }
    }

    if (isSorted)
    {
        break;
    }
}

// Вивід масиву на консоль
for (int i = 0; i <= arraySort.GetUpperBound(0); i++)
{
    for (int j = 0; j <= arraySort.GetUpperBound(1); j++)
    {
        if (arraySort[i, j] < 10)
        {
            Console.Write(" ");
        }
        Console.Write(arraySort[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

// 3. Написати програму, що буде видаляти з масиву елемент за вказаним індексом.

Console.WriteLine("3. Видалення елементі масива за індексом.\n");

int[] arrayDel = new int[10];

for (int i = 0; i < arrayDel.Length; i++)
{
    arrayDel[i] = random.Next(0, 99);
    Console.Write($"{arrayDel[i]} ");
}

Console.Write("\n\nВведіть індекс елементу який потрібно видалити: ");
int index = Convert.ToInt32(Console.ReadLine());
int[] newArray = new int[arrayDel.Length - 1];

for (int i = 0, j = 0; i < arrayDel.Length; i++)
{
    if (i != index)
    {
        newArray[j] = arrayDel[i];
        j++;
    }
}

Console.WriteLine("Новий масив: \n");

foreach (int i in newArray)
{
    Console.Write($"{i} ");
}

Console.WriteLine("\n");

// 4. Написати програму, що буде знаходити суму елементів по діагоналі у двовимірному масиві.

Console.WriteLine("4. Знайти суму елементів по діагоналі.\n");

int[,] diagArray = new int[10, 10];

int diagSum = 0;

for (int i = 0; i <= diagArray.GetUpperBound(0); i++)
{
    for (int j = 0; j <= diagArray.GetUpperBound(1); j++)
    {
        diagArray[i, j] = random.Next(0, 99);

        if (diagArray[i, j] < 10)
        {
            Console.Write(" ");
        }

        Console.Write(diagArray[i, j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i <= diagArray.GetUpperBound(0); i++)
{
    for (int j = 0; j <= diagArray.GetUpperBound(1); j++)
    {
        if (i == j)
        {
            diagSum += diagArray[i, j];
            continue;
        }
    }
}

Console.WriteLine($"\nСума елементів по діагоналі = {diagSum}");
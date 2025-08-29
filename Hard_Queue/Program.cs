// See https://aka.ms/new-console-template for more information

// создана пустая очередь для хранения целых чисел
Queue<int> numberQueue = new Queue<int>();

// цикл для добавления в очередь 4 элементов с помощью ввода пользователя
for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"Введите число {i + 1}");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Ошибка ввода! Введите целое число:");
    }
    numberQueue.Enqueue(number);
}

// **** Версия решения с выводом элементов из очереди ****
Console.WriteLine("\nВывод каждого второго элемента из очереди:");

// счетчик позиции элемента
int position = 1;
// цикл для вывода каждого второго элемента очереди
foreach (int number in numberQueue)
{
    if (position % 2 == 0)
    {
        Console.WriteLine(number);
    }
    position++;
}

// **** Версия решения с выводом элементов из списка *****
List<int> numberList = new List<int>(numberQueue);

Console.WriteLine("\nВывод каждого второго элемента из списка:");

// вывод каждого второго элемента списка
for (int i = 1; i < numberList.Count; i+=2)
{
    Console.WriteLine(numberList[i]);
}
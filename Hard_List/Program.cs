// See https://aka.ms/new-console-template for more information

// создан пустой список для хранения целых чисел
List<int> numberList = new List<int>();

// цикл для добавления в список 4 элементов с помощью ввода пользователя
for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"Введите число {i + 1}");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Ошибка ввода! Введите целое число:");
    }
    numberList.Add(number);
}

// создание пустой строки для более понятного вывода
Console.WriteLine();

// вывод каждого второго элемента списка
for (int i = 1; i < numberList.Count; i+=2)
{
    Console.WriteLine(numberList[i]);
}
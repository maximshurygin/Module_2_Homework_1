// See https://aka.ms/new-console-template for more information

int[] numberArray = { 1, 6, 4 };
List<int> numberList = new List<int>(numberArray);

numberList.Add(10);
numberList.Add(-3);
numberList.Add(8);

// Функция для нахождения суммы элементов списка с помощью цикла for
void FindSumUsingFor(List<int> list)
{
    int sumFor = 0;
    for (int i = 0; i < list.Count; i++)
    {
        sumFor += list[i];
    }
    Console.WriteLine($"Сумма (for): {sumFor}");
}

// Вызов функции FindSumUsingFor
FindSumUsingFor(numberList);

// Функция для нахождения суммы элементов списка с помощью цикла foreach
void FindSumUsingForEach(List<int> list)
{
    int sumForEach = 0;
    foreach(int number in list)
    {
        sumForEach += number;
    }
    Console.WriteLine($"Сумма (foreach): {sumForEach}");
}

// // Вызов функции FindSumUsingForEach
FindSumUsingForEach(numberList);
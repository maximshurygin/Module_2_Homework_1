// See https://aka.ms/new-console-template for more information

int[] numberArray  = {1, 6, 4, -2, 8, 17};

// Функция для нахождения суммы элементов массива с помощью цикла for
void FindArraySumUsingFor(int[] array)
{
    int sumFor = 0;

    for (int i = 0; i < array.Length; i++)
    {
        sumFor += array[i];
    }
    Console.WriteLine($"Сумма (for): {sumFor}");
}

// Вызов функции FindArraySumUsingFor
FindArraySumUsingFor(numberArray);

// Функция для нахождения суииы элементов массива с помощью цикла while
void FindArraySumUsingWhile(int[] array)
{
    int sumWhile = 0;
    int index = 0;

    while (index < array.Length)
    {
        sumWhile += array[index];
        index++;
    }
    Console.WriteLine($"Сумма (while): {sumWhile}");
}

//Вызов функции FindArraySumUsingWhile
FindArraySumUsingWhile(numberArray);
// массив исходных массивов
string[][] inputArray = {
    new string[] { "hello", "2", "world", ":-)" },
    new string[] { "1234", "1567", "-2", "computer science" },
    new string[] { "Russia", "Denmark", "Kazan" }
};

// будут отбираться строки с длиной меньше или равной этому значению
const int FILTER_LENGTH = 3;

// функция отбора (фильтрации) строк из массива
//
// на входе: массив строк
// на выходе: массив с отфильтрованными строками
//
string[] FilterStringsArray(string[] stringArray)
{
    // счётчик строк, подходящих под критерий фильтрации
    int cntOfFilteredStrings = 0;

    // во время первого прохода просто подсчитываем количество подходящих по критерию строк
    for (int i = 0; i < stringArray.Length; ++i)
    {
        // если строка подходит под критерий фильтрации увеличиваем счётчик
        if (stringArray[i].Length <= FILTER_LENGTH)
            cntOfFilteredStrings++;
    }

    // создаём массив длиной, равной как раз количеству найденных строк
    string[] result = new string[cntOfFilteredStrings];

    // нашли хоть одну подходящую строку?
    if (cntOfFilteredStrings != 0)
    {
        // индекс выходного массива
        int j = 0;

        // выполняем второй проход по входному массиву и заполняем выходной подходящими строками
        for (int i = 0; i < stringArray.Length; ++i)
        {
            // если строка подходит под критерий фильтрации то заносим её
            // в выходной массив и увеличиваем индекс выходного массива
            if (stringArray[i].Length <= FILTER_LENGTH)
            {
                result[j] = stringArray[i];
                j++;
            }
        }
    }
    // возвращаем выходной массив
    return result;
}

// основной цикл программы
for (int i = 0; i < inputArray.Length; ++i)
{
    Console.WriteLine($"Исходный массив: [{string.Join(", ", inputArray[i])}]");

    // отбираем необходимые строки
    string[] filteredArray = FilterStringsArray(inputArray[i]);

    Console.Write("Результирующий массив: ");

    if (filteredArray.Length == 0)
    {
        // ничего не было найдено
        Console.WriteLine("ПУСТОЙ");
    }
    else
    {
        // что-то нашли
        Console.WriteLine($"[{string.Join(", ", filteredArray)}]");
    }

    // выводим пустую строку просто для красоты
    Console.WriteLine();
}

#!/usr/bin/python3

# массив исходных массивов
inputArray = [['hello', '2', 'world', ':-)'],
              ['1234', '1567', '-2', 'computer science'],
              ['Russia', 'Denmark', 'Kazan']]

# будут отбираться строки с длиной меньше или равной этому значению
FILTER_LENGTH = 3;

# функция отбора (фильтрации) строк из массива
def FilterStringsArray(stringArray):
    # возвращаемый массив пока пустой
    result = []

    # просматриваем все строки во входном массиве
    for string in stringArray:
        if len(string) <= FILTER_LENGTH:
            # если строка удовлетворяет критерию фильтрации то добавляем её в результирующий массив
            result.append(string)

    # возвращаем построенный выходной массив
    return result

# основной цикл программы
for array in inputArray:
    outArray = ', '.join(array)
    print(f'Исходный массив: {outArray}')

    resArray = FilterStringsArray(array)

    if not resArray:
        print(f'Результирующий массив: ПУСТОЙ')
    else:
        outArray = ', '.join(resArray)
        print(f'Результирующий массив: [{outArray}]')

    # выводим пустую строку просто для красоты
    print()

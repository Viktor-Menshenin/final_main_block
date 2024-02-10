//using System;

//Чистим консоль
Console.Clear();

// Вводим исходный массив строк с клавиатуры
Console.WriteLine("Введите элементы массива, разделяя их запятой: ");
string input = Console.ReadLine();
string[] originalArray = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

// Формируем новый массив из строк, длина которых меньше либо равна 3 символам
string[] newArray = FilterArray(originalArray);

// Выводим результат
Console.WriteLine("Новый массив:");
foreach (string str in newArray)
{
    Console.WriteLine(str);
}

string[] FilterArray(string[] array){
    int count = 0;

    // Считаем количество строк, удовлетворяющих условию
    foreach (string str in array)
    {
        if (str.Length <= 3)
        {
            count++;
        }
    }

    // Создаем новый массив нужного размера
    string[] resultArray = new string[count];
    int index = 0;

    // Заполняем новый массив
    foreach (string str in array)
    {
        if (str.Length <= 3)
        {
            resultArray[index] = str;
            index++;
        }
    }

    return resultArray;
}
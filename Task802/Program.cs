// Задача № 2: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Программа считает сумму элементов в каждой строке и выдаёт номер
// строки с наименьшей суммой элементов: 1 строка

/// <summary>
/// Метод вывода сообщения с запросом для пользователя 
/// </summary>
/// <param name="message"> текстовое сообщение </param>
/// <returns></returns>
int InputUser(string message)
{
    Console.Write(message);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

/// <summary>
/// Метод заполнения созданного двумерного массива рандомными числами от 0 до 99
/// </summary>
/// <param name="array"> созданный в теле программы двумерный массив </param>
int[,] GenerateArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 100);
        }
    }
    return array;
}

/// <summary>
/// Метод вывода на экран созданного ранее двумерного массива
/// </summary>
/// <param name="array"> созданный ранее двумерный массив </param>
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t"); // Знак табуляции используется для красоты вывода на экран
        }
        Console.WriteLine();
    }
}

/// <summary>
/// Метод нахождения суммы элементов в строке
/// </summary>
/// <param name="array"> созданный ранее двумерный массив </param>
/// <param name="row"> строка созданного массива </param>
/// <returns></returns>
int SumElementsInLine(int[,] array, int row)
{
    int sumRow = array[row, 0]; // Объявление переменной для последующего суммирования
    for (int col = 1; col < array.GetLength(1); col++)
    {
        sumRow = sumRow + array[row, col];
    }
    return sumRow;
}

Console.WriteLine("Программа, которая находит строку с наименьшей суммой элементов");
System.Console.WriteLine(); // Пустая строка для красоты отобращения в консоли

int row = InputUser("Введите количество строк в двумерном массиве -> ");
int col = InputUser("Введите количество в столбцов в двумерном массиве -> ");

System.Console.WriteLine(); // Пустая строка для красоты отобращения в консоли

int[,] myArray = new int[row, col]; // Создание двумерного массива
GenerateArray(myArray); // Заполнение массива рандомными значениями при помощи метода
PrintArray(myArray); // Вывод на экран массива при помощи метода 

int minSumLine = 0; // Объявление переменной для нахождения строки с минимальной суммой элементов
int sumLine = SumElementsInLine(myArray, 0); // Объявляем, что работает с первым значением суммы
for (int i = 1; i < myArray.GetLength(0); i++)
{
    int tempSumLine = SumElementsInLine(myArray, i);
    if (sumLine > tempSumLine) // Условие нахождения минимального значения 
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

System.Console.WriteLine(); // Пустая строка для красоты вывода
Console.WriteLine($"В указанном выше двумерном массиве наименьшая сумма элементов ({sumLine}) находится на {minSumLine + 1}-ой строке");
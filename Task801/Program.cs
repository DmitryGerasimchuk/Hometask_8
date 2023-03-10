// Задача № 1: 
// Задайте двумерный массив. 
// Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

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
/// Метод упорядочивания по убыванию элементов строки созданного двумерного массива
/// </summary>
/// <param name="array"> созданный в теле программы двумерный массив </param>
void DescendingSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {                                 // Сортировка "пузырьком"
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

Console.WriteLine("Программа, которая упорядочивает по убыванию элементы строки двумерного массива");
System.Console.WriteLine(); // Пустая строка для красоты отобращения в консоли

int row = InputUser("Введите количество строк в двумерном массиве -> ");
int col = InputUser("Введите количество в столбцов в двумерном массиве -> ");

System.Console.WriteLine(); // Пустая строка для красоты отобращения в консоли

int[,] myArray = new int[row, col]; // Создание двумерного массива
GenerateArray(myArray); // Заполнение массива рандомными значениями при помощи метода
PrintArray(myArray); // Вывод на экран массива при помощи метода 

System.Console.WriteLine(); // Пустая строка для красоты отобращения в консоли
Console.WriteLine("Отсортированный по условию задачи массив выглядит следующим образом:");
System.Console.WriteLine(); // Пустая строка для красоты отобращения в консоли

DescendingSort(myArray); // Сортировка массива по убываю построчно с помощью метода
PrintArray(myArray); // Вывод на экран отсортированного массива при помощи метода 
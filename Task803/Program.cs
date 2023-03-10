// Задача № 3: 
// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

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
            array[i, j] = random.Next(0, 10);
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
/// Метод нахождения произведения двух матриц
/// </summary>
/// <param name="firstArray"> первая матрица </param>
/// <param name="secondArray"> вторая матрица </param>
/// <param name="finalArray"> матрица - результат от проивзедения </param>
void MultiplyArray(int[,] firstArray, int[,] secondArray, int[,] finalArray)
{
    for (int i = 0; i < finalArray.GetLength(0); i++)
    {
        for (int j = 0; j < finalArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                sum = sum + firstArray[i, k] * secondArray[k, j]; // Нахождение произведения в каждой из строк 
            }
            finalArray[i, j] = sum;
        }
    }
}

Console.WriteLine("Программа для нахождения произведения двух матриц");
System.Console.WriteLine(); // Пустая строка для красоты отобращения в консоли

int row1 = InputUser("Введите количество строк в первой матрице -> ");
int col1 = InputUser("Введите количество в столбцов в первой матрице -> ");
int col2 = InputUser("Введите количество в столбцов во второй матрице -> ");

System.Console.WriteLine(); // Пустая строка для красоты отобращения в консоли

int[,] myFirstArray = new int[row1, col1]; // Создание двумерного массива - матрицы № 1
GenerateArray(myFirstArray); // Заполнение массива рандомными значениями при помощи метода
System.Console.WriteLine("Матрица № 1:");
PrintArray(myFirstArray); // Вывод на экран массива при помощи метода
System.Console.WriteLine(); // Пустая строка для красоты отобращения в консоли

int[,] mySecondArray = new int[row1, col2]; // Создание двумерного массива - матрицы № 2
GenerateArray(mySecondArray); // Заполнение массива рандомными значениями при помощи метода
System.Console.WriteLine("Матрица № 2:");
PrintArray(mySecondArray); // Вывод на экран массива при помощи метода 
System.Console.WriteLine(); // Пустая строка для красоты отобращения в консоли

int[,] finalArray = new int[row1, col2];
MultiplyArray(myFirstArray, mySecondArray, finalArray);
Console.WriteLine("Произведение матрицы № 1 на матрицу № 2 будет равным:");
PrintArray(finalArray);
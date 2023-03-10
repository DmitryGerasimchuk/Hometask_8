// Задача № 4: 
// Напишите программу, 
// которая заполнит спирально квадратный массив. 

/// <summary>
/// Метод вывода сообщения с запросом о размерности массива для пользователя 
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
/// Метод вывода значений квадратного массива 
/// </summary>
/// <param name="array"> созданный в теле программы квадратный массив </param>
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0) // Подсмотрел решение в сети Интернет
                Console.Write($" {array[i, j]}   ");

            else Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Программа для нахождения произведения двух матриц");
System.Console.WriteLine(); // Пустая строка для красоты отобращения в консоли

int n = InputUser("Введите размерность квадратного массива -> ");
int[,] myArray = new int[n, n]; // Обязательное условие, чтобы row = col

int temp = 1;
int row = 0;
int col = 0;

while (temp <= myArray.GetLength(0) * myArray.GetLength(1))
{
    myArray[row, col] = temp;
    temp = temp + 1;
    if (row <= col + 1 && row + col < myArray.GetLength(1) - 1)
    {
        col = col + 1;
    }
    else if (row < col && row + col >= myArray.GetLength(0) - 1) // Подсмеотрел в сети Интернет такую консутруцию (для дополнительного условия)
    {
        row = row + 1;
    }
    else if (row >= col && row + col > myArray.GetLength(1) - 1) // Подсмеотрел в сети Интернет такую консутруцию (для дополнительного условия)
    {
        col = col - 1;
    }
    else
    {
        row = row - 1;
    }
}

System.Console.WriteLine(); // Пустая строка для красоты вывода
System.Console.WriteLine("Двадратный массив, заполненный спирально числами будет выглядить:");
System.Console.WriteLine(); // Пустая строка для красоты вывода

PrintArray(myArray);
using System;

class Program
{
    static void Main()
    {
        // Пример двумерного массива (можно изменить на свой)
        int[,] myArray = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // Получение позиции от пользователя
        Console.Write("Введите номер строки: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int col = int.Parse(Console.ReadLine());

        // Поиск значения элемента по позиции
        int result = GetElementValue(myArray, row, col);

        if (result != int.MinValue)
        {
            Console.WriteLine($"Значение элемента на позиции [{row},{col}]: {result}");
        }
        else
        {
            Console.WriteLine("Такого элемента не существует в массиве.");
        }
    }

    // Функция для получения значения элемента по позиции
    static int GetElementValue(int[,] array, int row, int col)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        // Проверка, находится ли указанная позиция в пределах массива
        if (row >= 0 && row < numRows && col >= 0 && col < numCols)
        {
            return array[row, col];
        }
        else
        {
            // Если позиция находится вне диапазона массива, возвращаем int.MinValue (можно выбрать другое значение по умолчанию)
            return int.MinValue;
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        // Пример двумерного массива (можно изменить на свой)
        int[,] myArray = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(myArray);

        // Меняем местами первую и последнюю строки
        SwapFirstAndLastRows(myArray);

        Console.WriteLine("\nМассив после замены:");
        PrintArray(myArray);
    }

    // Функция для вывода массива в консоль
    static void PrintArray(int[,] array)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    // Функция для замены первой и последней строк массива
    static void SwapFirstAndLastRows(int[,] array)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        // Проверка, что в массиве есть хотя бы две строки
        if (numRows >= 2)
        {
            // Замена первой и последней строк с использованием временного массива
            int[] temp = new int[numCols];
            for (int i = 0; i < numCols; i++)
            {
                temp[i] = array[0, i];
                array[0, i] = array[numRows - 1, i];
                array[numRows - 1, i] = temp[i];
            }
        }
        else
        {
            Console.WriteLine("Массив содержит менее двух строк. Невозможно поменять местами.");
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        // Пример прямоугольного двумерного массива (можно изменить на свой)
        int[,] myArray = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
            {10, 11, 12}
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(myArray);

        int minRowIndex = FindRowWithMinSum(myArray);

        if (minRowIndex != -1)
        {
            Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minRowIndex}");
        }
        else
        {
            Console.WriteLine("Массив пустой.");
        }
    }

    // Функция для вывода массива в консоль
    static void PrintArray(int[,] array)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    // Функция для поиска строки с наименьшей суммой элементов
    static int FindRowWithMinSum(int[,] array)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        // Инициализация переменных для хранения индекса строки с минимальной суммой и самой минимальной суммы
        int minSum = int.MaxValue;
        int minRowIndex = -1;

        // Перебор строк и подсчет суммы элементов в каждой строке
        for (int i = 0; i < numRows; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < numCols; j++)
            {
                rowSum += array[i, j];
            }

            // Проверка на минимальную сумму
            if (rowSum < minSum)
            {
                minSum = rowSum;
                minRowIndex = i;
            }
        }

        return minRowIndex;
    }
}
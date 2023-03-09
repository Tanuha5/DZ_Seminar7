// Задача 50: Напишите программу, которая на вход 
// принимает координаты элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 ,  7 -> такого числа в массиве нет

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 21);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int rows = ReadInt("Введите индекс строки матрицы: ");
int cols = ReadInt("Введите индекс столбца матрицы: ");
int[,] matrix = new int[6, 8];
System.Console.WriteLine();
FillArray(matrix);
PrintMatrix(matrix);
Position(matrix);

void Position(int[,] matrix)
{
    if (rows < matrix.GetLength(0) && cols < matrix.GetLength(1))
    {
        Console.WriteLine(matrix[rows, cols]);
    }
    else Console.WriteLine($"[{rows}, {cols}] - Такого элемента в массиве нет.");
}



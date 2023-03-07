// Задача 1. Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.

// m = 3, n = 4.

// 0,5  7  -2  -0,2

// 1  -3,3  8  -9,9

// 8  7,8  -7,1  9

// На этом методе я создал массив, дал ему каркас (row, col) и объем (- 900, 1000) 

int[,] GenerateArray(int row, int col)
{
    int[,] array = new int[row, col]; // Создаем 2-мерный массив
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-900, 1000) ;
        }
    }
    return array;
}

// метод с функцей void вывел в консоль наш массив именно вещественные числа. 
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]/10.0}\t");
        }
    }
    Console.WriteLine();
}

int[,] matrix = GenerateArray(3, 4);
PrintArray(matrix);


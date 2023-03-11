// Задайте двумерный массив. Напишите программу, которая упорядочивает 
// по убыванию элементы каждой строки двумерного массива.

int[,] GenerateArray(int row, int col)
{
    int[,] array = new int[row, col]; // Создаем 2-мерный массив
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-9, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
    }
    Console.WriteLine();
}

int[,] RebuildAnArray(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k]< array[i, k + 1])  
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
}

//
// // Функция сортировки элементов в строке двумерного массива, по убыванию
// void SortMatrixByRowDesc(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         SortRow(array, i);
//     }
// }

// void SortRow(int[,] array, int i)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int k = 0; k < array.GetLength(1) - 1; k++)
//         {
//             if (array[i, k] < array[i, k + 1])
//             {
//                 Swap(array, k, i);
//             }
//         }
//     }
// }

// void Swap(int[,] array, int i, int row)
// {
//     int temp = array[row, i + 1];
//     array[row, i + 1] = array[row, i];
//     array[row, i] = temp;
// }

int[,] MyArray = GenerateArray(3, 3);
PrintArray(MyArray);
PrintArray(RebuildAnArray(MyArray));
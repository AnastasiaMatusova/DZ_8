// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array= new int[rows, cols];
// FillArrayRandomNumbers(array);
// Console.WriteLine();
// Console.WriteLine("Заданный массив до упорядочивания ");
// ShowArray(array);

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1) - 1; j++)
//     {
//         for (int z = 0; z < array.GetLength(1) - 1; z++)
//         {
//             if (array[i, z] < array[i, z + 1])
//             {
//                 int temp = 0;
//                 temp = array[i, z];
//                 array[i, z] = array[i, z + 1];
//                 array[i, z + 1] = temp;
//             }
//         }
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Массив с упорядоченными значениями по убыванию");
// ShowArray(array);

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {

//         for (int j = 0; j < array.GetLength(1); j++) 
//         {
//             Console.Write(array[i, j] + " ");
//         }

//         Console.WriteLine("");
//     }
// }


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.Write("Введите количество строк ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.Write("Задайте диапазон случайных значений: от 1 до  ");
// int range = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[x, y];
// CreateArray(array);
// ShowArray(array);

// int minSum = 0;
// int sum = SumElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//     int tempSum = SumElements(array, i);
//     if (sum > tempSum)
//     {
//         sum = tempSum;
//         minSum = i;
//     }
// }

// Console.WriteLine($"{minSum + 1} - номер строки с наименьшей суммой элементов равной {sum}  ");

// int SumElements(int[,] array, int i)
// {
//     int sum = array[i, 0];
//     for (int j = 1; j < array.GetLength(1); j++)
//     {
//         sum += array[i, j];
//     }
//     return sum;
// }


// void CreateArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(range);
//         }
//     }
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, columns];
// int[,] secondMatrix = new int[rows, columns];
// int[,] resultMatrix = new int[rows, columns];

// GetMatrixRandom(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();

// GetMatrixRandom(secondMatrix);
// PrintMatrix(secondMatrix);
// Console.WriteLine();

// if (matrix.GetLength(0) != secondMatrix.GetLength(1))
// {
//     Console.WriteLine(" Нельзя перемножить ");
//     return;
// }
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < secondMatrix.GetLength(1); j++)
//     {
//         resultMatrix[i, j] = 0;
//         for (int k = 0; k < matrix.GetLength(1); k++)
//         {
//             resultMatrix[i, j] += matrix[i, k] * secondMatrix[k, j];
//         }
//     }
// }
// PrintMatrix(resultMatrix);

// void GetMatrixRandom(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// Дополнительная задача
// Задача 60. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int row = 4, column = 4;
int[,] MatrixSpiral = new int[row, column];
GetMatrixSpiral(MatrixSpiral, row);
PrintMatrix(MatrixSpiral);

void GetMatrixSpiral(int[,] MatrixSpiral, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { MatrixSpiral[i, j++] = value++; } 
        while (++k < n - 1);
        for (k = 0; k < n - 1; k++) MatrixSpiral[i++, j] = value++;
        for (k = 0; k < n - 1; k++) MatrixSpiral[i, j--] = value++;
        for (k = 0; k < n - 1; k++) MatrixSpiral[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void PrintMatrix(int[,] MatrixSpiral)
{
    for (int i = 0; i < MatrixSpiral.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixSpiral.GetLength(1); j++)
        {
            if (MatrixSpiral[i, j] < 10)
            {
                Console.Write("0" + MatrixSpiral[i, j]);
                Console.Write(" ");
            }
            else Console.Write(MatrixSpiral[i, j] + " ");
        }
        Console.WriteLine();
    }
}
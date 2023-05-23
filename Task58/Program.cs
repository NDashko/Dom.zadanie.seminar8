// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillArray1(int numberRow, int numberColumn)
{
    int[,] array1 = new int[numberRow, numberColumn];
    Random rnd = new Random();

    System.Console.WriteLine();
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i, j] = rnd.Next(0, 10);
            System.Console.Write($"{array1[i, j]}   ");
        }
        System.Console.WriteLine("\n");
    }
    return array1;
}

int[,] FillArray2(int numberRow, int numberColumn)
{
    int[,] array2 = new int[numberRow, numberColumn];
    Random rnd = new Random();

    System.Console.WriteLine();
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array2[i, j] = rnd.Next(0, 10);
            System.Console.Write($"{array2[i, j]}   ");
        }
        System.Console.WriteLine("\n");
    }
    return array2;
}

static int[,] Multiplication(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)

            {
                array3[i, j] += array1[i, k] * array2[k, j];
                
            }
            Console.WriteLine($"{array3[i, j]} ");
        }


    }

    return array3;
}

int[,] array1 = FillArray1(2, 2);
int[,] array2 = FillArray2(2, 2);
Multiplication(array1, array2);


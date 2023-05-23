// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] FillArray(int numberRow, int numberColumn)
{
     int[,] array = new int[numberRow, numberColumn];
    Random rnd = new Random();

    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
            System.Console.Write($"{array[i, j]}   ");
        }
        System.Console.WriteLine("\n");
    }
    return array;
}

void ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(1) - 1; n++)

            {
                if (array[i, n] < array[i, n + 1])
                {
                    int temp = array[i, n + 1];
                    array[i, n + 1] = array[i, n];
                    array[i, n] = temp;
                }
            }
        }
    }
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine("\n");
    }
}

int[,] array = FillArray(4,4);
ChangeArray(array);
Console.WriteLine();
PrintArray(array);
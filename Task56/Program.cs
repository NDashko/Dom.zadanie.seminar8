// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int[,] array = FillArray(5, 4);
int min = 0;
int sumLine = SumLine(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int temp = SumLine(array, i);
  if (sumLine > temp)
  {
    sumLine = temp;
    min = i;
  }
}
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {min+1}");


int SumLine(int[,] array, int i)
{
  int sumLine = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
    
  }
  Console.WriteLine($"Строка {i+1} - " +sumLine);
  return sumLine;
}
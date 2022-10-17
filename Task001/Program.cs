// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int [,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("|");
            Console.Write(array[i, j]);
        }

        Console.WriteLine("|");
    }
  
    Console.WriteLine();
}

void BubbleSort(int[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {    
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if (array[k, i] < array[k, j])
                {
                    int res = array[k, i];
                    array[k, i] = array[k, j];
                    array[k, j] = res;
                }  
            }
        }
    }
}

Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine();

Console.WriteLine("Рандомно заполненый массив m*n: ");

int[,] array = FillArray(m, n);
PrintArray(array);

Console.WriteLine("Массив упорядоченный по убыванию элементов в строке: ");
BubbleSort(array);
PrintArray(array);

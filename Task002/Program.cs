// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей
// суммой элементов: 1 строка (нумерация строк начинается с 1)

int [,] FillArray(int r, int c)
{
    int[,] array = new int[r, c];

    for (int ir = 0; ir < r; ir++)
    {
        for (int ic = 0; ic < c; ic++)
        {
            array[ir, ic] = new Random().Next(1, 10);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int ir = 0; ir < array.GetLength(0); ir++)
    {
        for (int ic = 0; ic < array.GetLength(1); ic++)
        {
            Console.Write("|");
            Console.Write(array[ir, ic]);
        }

        Console.WriteLine("|");
    }
  
    Console.WriteLine();
}

void SumRowArray(int [,] array)
{   
    int min = int.MaxValue;
    int minNum = 0;

    for (int ir = 0; ir < array.GetLength(0); ir++)
    {
        int sum = 0;
        for (int ic = 0; ic < array.GetLength(1); ic++)
        {
            sum += array[ir,ic];
        }  

        if (sum < min)
        {
            min = sum;
            minNum = ir;
        }
    } 
    Console.Write($"{minNum + 1} строка");
}

Console.Write("Введите r: ");
int r = int.Parse(Console.ReadLine()!);
Console.Write("Введите c: ");
int c = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int [,] array = FillArray(r, c);
PrintArray(array);
SumRowArray(array);


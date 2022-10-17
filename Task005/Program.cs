// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int [,] FillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int count = 1;
    int r = 0;
    int c = 0;

    while (count <= array.Length)
    {
        array[r, c] = count;
        count++;
        
        if (r <= c + 1 && r + c < array.GetLength(1) - 1)
            c++;
        else if (r < c && r + c >= array.GetLength(0) - 1)
            r++;
        else if (r >= c && r + c > array.GetLength(1) - 1)
            c--;
        else
            r--;
    }
    return array;
}



void WriteArray (int[,] array)
{
  for (int r = 0; r < array.GetLength(0); r++)
  {
    for (int c = 0; c < array.GetLength(1); c++)
    {
        if (array[r,c] < 10)
            Console.Write($"0{array[r,c]} ");
        else 
            Console.Write($"{array[r,c]} ");        
    }

    Console.WriteLine();
  }
}
	
Console.Write("Введите количество строк в масиве: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов в масиве: ");
int columns = int.Parse(Console.ReadLine()!);

if (rows == columns)
{
    int[,] array = FillArray(rows, columns);
    WriteArray(array);
}
else
{
    Console.WriteLine("Массив не квадратный");
}

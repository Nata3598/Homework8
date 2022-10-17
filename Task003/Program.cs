// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49
int [,] FillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int r = 0; r < rows; r++)
    {
        for (int c = 0; c < columns; c++)
        {
            array[r, c] = new Random().Next(1, 10);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
        {
            Console.Write("|");
            Console.Write(array[r, c]);
        }

        Console.WriteLine("|");
    }
  
    Console.WriteLine();
}

int [,] MulArray(int [,] arrayOne, int[,] arrayTwo)
{
    int [,] resultarray = new int [arrayOne.GetLength(0),arrayTwo.GetLength(1)];
    for (int r = 0; r < arrayOne.GetLength(0); r++)
    {
        for (int c = 0; c < arrayTwo.GetLength(1); c++)
        {
            resultarray[r, c] = 0;
            for (int k = 0; k < arrayOne.GetLength(1); k++)
            {   
                resultarray[r, c] += arrayOne[r, k] * arrayTwo[k, c];
               
            }
        }
        
    }
    return resultarray;
}

Console.Write("Введите количество строк в первой матрице rows: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в первой матрице columns: ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int [,] arrayOne = FillArray(rows, columns);
PrintArray(arrayOne);

Console.Write("Введите количество строк во второй матрице rows: ");
rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в первой матрице columns: ");
columns = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int [,] arrayTwo = FillArray(rows, columns);
PrintArray(arrayTwo);

if (arrayOne.GetLength(0) != arrayTwo.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
}
else 
{
    Console.WriteLine("Результат сложения двух ");
    Console.WriteLine();
    int [,] result = MulArray(arrayOne, arrayTwo);
    PrintArray(result);
}
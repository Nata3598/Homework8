// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [,,] FillArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];

    for (int ix = 0; ix < x; ix++)
    {
        for (int iy = 0; iy < y; iy++)
        {
            for (int iz = 0; iz < z; iz++)
            {
                array[ix, iy, iz] = new Random().Next(10, 100);
            }
        }
    }

    return array;
}
void PrintArray(int[,,] array)
{
    for (int ix = 0; ix < array.GetLength(0); ix++)
    {
        for (int iy = 0; iy < array.GetLength(1); iy++)
        {
            for (int iz = 0; iz < array.GetLength(2); iz++)
            {
                Console.WriteLine($"{array[ix, iy, iz]} ({ix}; {iy}; {iz})");
            }
        }
    }
  
    Console.WriteLine();
}

int x = 2;
int y = 2;
int z = 2;

int[,,] array = FillArray(x, y, z);
PrintArray(array);
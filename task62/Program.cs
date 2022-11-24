// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] matrix = new int[4, 4];
PrintArray(matrix);
FillArray(0,0);
PrintArray(matrix);


void FillArray(int row, int col)
{
    if (matrix[row, col] == 0)
    {
        matrix[row, col] = 1;
        FillArray(row - 1, col);
        FillArray(row, col - 1);
        FillArray(row + 1, col);
        FillArray(row, col + 1);

    }
}
void  FillArray(int[,] array)
{
    int step = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = step;
            step++;
            Console.Write("{0,5:F0}", array[i, j] + " ");
        }
        if(i==array.GetLength(0)) 
        {
            j++
        }
        Console.WriteLine();
    }
}



void PrintArray(int[,] array)
{
    int step = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = step;
            step++;
            Console.Write("{0,5:F0}", array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
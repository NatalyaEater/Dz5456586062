// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Задайте размерность количества строк в матрице:");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Задайте размерность количества столбцов в матрице:");
int m = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[n, m];
PrintArray(ArraySpiral(matrix));

int[,] ArraySpiral(int[,] array)
{
    int numStep = (array.GetLength(0)) * (array.GetLength(1)); // кол-во ячеек для заполнения в матрице 
    int i = 0; //индекс строк
    int j = 0; //индекс столбцов
    int jMax = 0;
    int jMin = 0;
    int iMax = 0;
    int iMin = 0;
    int step = 1;
    while (step <= numStep)
    {
        array[i, j] = step;
        if (i == iMin && j < (array.GetLength(1) - jMax - 1)) //запись пока (не доходи одного шага до конца по столбцам)
        {
            ++j;
        }
        else if (j == array.GetLength(1) - jMax - 1 && i < (array.GetLength(0) - iMax - 1))//запись пока (не доходи одного шага до конца по строкам)
        {
            ++i;
        }
        else if (i == array.GetLength(0) - iMax - 1 && j > jMin)
        {
            --j;
        }
        else
        {
            --i;
        }
        if (i == iMin + 1 && j == jMin)
        {
            ++iMin;
            ++iMax;
            ++jMin;
            ++jMax;
        }
        ++step;
    }
    return array;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,5:F0}", array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
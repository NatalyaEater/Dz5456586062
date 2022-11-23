//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] matrix = new int[4, 4];

Console.WriteLine("Задан массив");

GetArray(matrix);
PrintArray(matrix);

Console.WriteLine("Упорядоченный по убыванию  массив");

NewArray(matrix);
PrintArray(matrix);
void NewArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int f = 0; f < array.GetLength(1) - 1; f++)
            {
                if (array[i, f] < array[i, j])
                {
                    int step = 0;
                    step = array[i, j];
                    array[i, j] = array[i, f];
                    array[i, f] = step;
                }
            }
        }
    }
}


void GetArray(int[,] inArray) //заполнение матрицы
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            inArray[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array) // фиксация матрицы
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

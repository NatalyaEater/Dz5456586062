//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int[,] matrixOne = new int[2, 2];
int[,] matrixTwo = new int[2, 2];
int[,] matrixRes = new int[2, 2];
GetArray(matrixOne);
Console.WriteLine("Первая матрица");
PrintArray(matrixOne);

GetArray(matrixTwo);
Console.WriteLine("Вторая  матрица");
PrintArray(matrixTwo);

ResyltArray(matrixOne, matrixTwo, matrixRes);
Console.WriteLine("Произведение  матриц");
PrintArray(matrixRes);


void ResyltArray(int[,] oneArray, int[,] twoArray, int[,] resArray)
{
    for (int i = 0; i < resArray.GetLength(0); i++)
    {
        for (int j = 0; j < resArray.GetLength(1); j++)
        {
            int sumRes = 0;
            for (int f = 0; f < oneArray.GetLength(1); f++)
            {
                sumRes = sumRes + (oneArray[i, f] * twoArray[f, j]);
            }
            resArray[i, j] = sumRes;
        }
    }
}

void GetArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            inArray[i, j] = new Random().Next(1, 10);
        }
    }
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

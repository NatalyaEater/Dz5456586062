//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] matrix = new int[3, 3];

GetArray(matrix);
SumArray(matrix);

void SumArray(int[,] array)
{
    int index = 0;
    int min = 999;
    for (int n = 0; n < array.GetLength(0); n++)
    {
        int sum = 0;
        for (int l = 0; l < array.GetLength(1); l++)
        {
            sum = sum + array[n, l];
        }
        Console.WriteLine("Сумма элементов в " + (n + 1) + " строке: " + "{0,0:F0}", sum);
        if (sum < min)
        {
            min = sum;
            index = index + 1;
        }
    }
    Console.WriteLine("Номер строки с наименьшей суммой элементов:" + "{0,0:F0}", index);
}

void GetArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            inArray[i, j] = new Random().Next(0, 10);
            Console.Write("{0,5:F0}", inArray[i, j]);
        }
        Console.WriteLine();
    }
}

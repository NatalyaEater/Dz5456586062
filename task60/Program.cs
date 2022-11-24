// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите три аргумента размерности трехмерного массива");
Console.WriteLine("Введите первый аргумент:");
int oneArgyment = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второй аргумент:");
int twoArgyment = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите третий аргумент:");
int threeArgyment = int.Parse(Console.ReadLine() ?? "0");

int[,,] matrix = new int[oneArgyment, twoArgyment, threeArgyment];
GetArray(matrix);
PrintArray(matrix);

void GetArray(int[,,] inArray)
{
    int step = 10;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int f = 0; f < inArray.GetLength(2); f++)
            {
                inArray[i, j, f] = step;
                step++;
            }
        }
    }
}



void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int f = 0; f < array.GetLength(2); f++)
            {
                Console.Write("{0,5:F0}", array[i, j, f] + "" + "(" + i + "," + j + "," + f + ")\t");
            }
            Console.WriteLine();
        }
    }
}
//Задача 3. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void Print_Arr(int[,] square)
{
    for (int i = 0; i < square.GetLength(0); i++)
    {
        for (int j = 0; j < square.GetLength(1); j++)
        {
            Console.Write($"{square[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Find_Num_Arr(int[,] matrix)
{
    double sum1 = 0;
    double sum2 = 0;
    double sum3 = 0;
    double sum4 = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        for (int i = 0; i < matrix.GetLength(0); i++)
        {

            sum1 = matrix[0, 0] + matrix[1, 0] + matrix[2, 0];
            sum2 = matrix[0, 1] + matrix[1, 1] + matrix[2, 1];
            sum3 = matrix[0, 2] + matrix[1, 2] + matrix[2, 2];
            sum4 = matrix[0, 3] + matrix[1, 3] + matrix[2, 3];
        }

    }
    Console.Write("{0:f1} ", sum1 / 3);
    Console.Write("{0:f1} ", sum2 / 3);
    Console.Write("{0:f1} ", sum3 / 3);
    Console.Write("{0:f1} ", sum4 / 3);
}
int[,] magic = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
Console.WriteLine();
Print_Arr(magic);
Console.WriteLine();

Find_Num_Arr(magic);


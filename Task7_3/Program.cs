//Задача 4. Со звездочкой(*). Найдите максимальное значение в матрице по 
//каждой строке, ссумируйте их. Затем найдети минимальное значение по каждой 
//колонке, тоже ссумируйте их. 
//Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

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


int Find_Max_Str_Sum_Arr(int[,] matrix)
{

    int res = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int max1 = matrix[i, 0];
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > max1)
            {
                max1 = matrix[i, j];
            }
        }
        res += max1;
    }
    return res;

}
int Find_Min_Col_Sum_Arr(int[,] matrix)
{

    int res = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int max1 = matrix[0, j];
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, j] < max1)
            {
                max1 = matrix[i, j];
            }
        }
        res += max1;
    }
    return res;

}
int[,] magic = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
Console.WriteLine();
Print_Arr(magic);
Console.WriteLine();
int s_max = Find_Max_Str_Sum_Arr(magic);
int s_min = Find_Min_Col_Sum_Arr(magic);
int result = s_max - s_min;
Console.WriteLine($"{result}");

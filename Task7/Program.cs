//Задача 1. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

int Promt(string message)
{

    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void Print_Arr(double[,] square)
{
    for (int i = 0; i < square.GetLength(0); i++)
    {
        for (int j = 0; j < square.GetLength(1); j++)
        {
            Console.Write($"{square[i,j]:0.00} ");
        }
        Console.WriteLine();
    }
}
void Rand_Num_Arr(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = 5 - new Random().Next(0, 10) + new Random().NextDouble();
            
        }
    }
}


System.Console.WriteLine("Задайте двумерный массив размером m x n :");
int m = Promt("Введите число строк m > ");
int n = Promt("Введите число столбцов n > ");
double[,] magic = new double[m, n];
Console.WriteLine();
Rand_Num_Arr(magic);
Print_Arr(magic);
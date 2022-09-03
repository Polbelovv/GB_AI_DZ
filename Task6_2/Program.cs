//Задача 3. Со Звездочкой (*). Сгенерировать двумерный массив со 
//случайными числами, вывести его на экран, 
//оформить в виде функций (пригодится в дальнейшем)

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
void Rand_Num_Arr(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
int[,] magic = new int[5, 5];
Console.WriteLine();
Rand_Num_Arr(magic);
Print_Arr(magic);
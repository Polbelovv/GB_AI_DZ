//Задача 2. Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, и возвращает значение 
//этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
int Promt(string message)
{

    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

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

int Find_Num_Arr(int[,] matrix, int posi, int posj)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (posi > 2)
            return -1;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (posj > 2)
                return -1;
            if (matrix[i, j] == matrix[posi, posj])
            {

                return matrix[i, j];
            }

        }

    }
    return 0;
}

int[,] magic = new int[,] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
int number1 = Promt("Введите позицию i искомого элемента > ");
int number2 = Promt("Введите позицию j искомого элемента > ");
Console.WriteLine();
Print_Arr(magic);
int s = Find_Num_Arr(magic, number1, number2);
if (s > -1)
{
    Console.Write($"Число в позиции i,j -> {s} ");
}
else
{
    Console.Write($"{number1} ");
    Console.Write($"{number2} ->");
    Console.Write("{такого числа в массиве нет} ");
}

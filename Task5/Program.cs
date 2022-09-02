//Задача 1: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int Promt(string message)
{
    
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
int Even_number(int[] arrA)
{   
    int count = 0;
    for(int i=0;i<5;i++)
    {
        if(arrA[i]%2==0)
        {
            count++;
        }
    }
    return count;
}
int [] arrA = new int[5];
System.Console.WriteLine("Введите случайные трёхзначные 5 чисел:");
for (int i = 0; i < 5; i++){
    arrA[i] = Promt("Введите числа для заполнения массива А > ");
}
System.Console.WriteLine("Количество четных чисел в массиве:"); 
        int n = Even_number(arrA);
        Console.WriteLine(n);


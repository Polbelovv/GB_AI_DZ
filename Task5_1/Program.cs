//Задача 2: Задайте одномерный массив, 
//заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int Promt(string message)
{
    
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
int Even_number(int[] arrA)
{   
    int sum = 0;
    for(int i=0;i<5;i++)
    {
        if(!(i%2==0))
        {
            sum=sum+arrA[i];
        }
    }
    return sum;
}
int [] arrA = new int[5];
System.Console.WriteLine("Введите случайные 5 чисел:");
for (int i = 0; i < 5; i++){
    arrA[i] = Promt("Введите числа для заполнения массива А > ");
}
System.Console.WriteLine("Сумма нечетных чисел в массиве:"); 
        int n = Even_number(arrA);
        Console.WriteLine(n);
//Задача 3: Задайте массив вещественных чисел. Найдите 
//разницу между максимальным и минимальным элементов массива.
//[3 7.3 22.2 2 78] -> 76

double Promt(string message)
{
    
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    double result = double.Parse(readValue);
    return result;
}
double Difference_number(double[] arrA)
{   
    double max = arrA[0];
    double min = arrA[0];
    double diff = 0;
    for(int i=0;i<5;i++)
    {
        if (arrA[i] > max)
        max = arrA[i];
        if (min > arrA[i])
        min = arrA[i];
    }
    diff = max-min;
    return diff;
}
double [] arrA = new double[5];
System.Console.WriteLine("Введите случайные 5 чисел:");
for (int i = 0; i < 5; i++){
    arrA[i] = Promt("Введите числа для заполнения массива А > ");
}
System.Console.WriteLine("Разница минимального и максимального числа в массиве:"); 
        double n = Difference_number(arrA);
        Console.WriteLine(n);

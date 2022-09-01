//Задача 2: Напишите программу, которая принимает на вход число и 
//выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int Promt(string message)
{

    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
int SumVal(int num)
{
    int n = num; 
    int sum = 0;
    
    while (n!=0)
    {
        int r = n % 10;
        sum = sum + r;
        n = n / 10;        
    }
    return (sum);
      
}
System.Console.WriteLine("Введите число для суммирования цифр в данном числе");
    int value1 = Promt("Введите число > ");
    int n = SumVal(value1);
    Console.WriteLine($"Сумма цифр числа составляет:{n}");
    

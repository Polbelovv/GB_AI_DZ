int Promt(string message)
{

    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
System.Console.WriteLine("Введите числа для сравнения");
int value1 = Promt("Введите первое число > ");
int value2 = Promt("Введите второе число > ");
if(value1 > value2)
    System.Console.WriteLine($"Max {value1}, Min {value2}");
else
    System.Console.WriteLine($"Max {value2}, Min {value1}");

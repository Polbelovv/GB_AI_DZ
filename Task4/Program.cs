int Promt(string message)
{

    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
System.Console.WriteLine("Введите загаданное число N");
int value1 = Promt("Введите число > ");
//int value2 = Promt("Введите второе число > ");
for(int i=1; i < value1; i++)
    if(i % 2 == 0)
        System.Console.WriteLine($"{i}");
//else
    //System.Console.WriteLine($"Max {value2}, Min {value1}");

int Promt(string message)
{

    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
System.Console.WriteLine("Введите число для выяснения четности");
int value1 = Promt("Введите испытуемое число > ");
//int value2 = Promt("Введите второе число > ");
if(value1 % 2 == 0)
    System.Console.WriteLine($"{value1} is an even number");
else
    System.Console.WriteLine($"{value1} is an odd number");

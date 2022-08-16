int Promt(string message)
{

    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
System.Console.WriteLine("Введите заданное число");
int value1 = Promt("Введите число > ");

int value2, value3, value4, value5;

value2 = value1 % 10;
value3 = value1 / 10 % 10;
value4 = value1 / 100 % 10;
value5 = value1 / 1000 % 100;

if(value4 != 0 && value5 == 0)
    System.Console.WriteLine($"> {value2}");
else if(value5 != 0)
    System.Console.WriteLine($"> {value3}");
else
{
   System.Console.WriteLine("Третьей цифры нет"); 
}
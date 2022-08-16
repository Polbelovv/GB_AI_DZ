int Promt(string message)
{

    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}


System.Console.WriteLine("Введите трёхзначное число");
int value1 = Promt("Введите число > ");
int value2 = 0;

value2 = value1 / 10 % 10;
System.Console.WriteLine($"Вторая цифра числа: {value2}");

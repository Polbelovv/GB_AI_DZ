/*int Promt(string message)
{

    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}*/
System.Console.WriteLine("Случайное трёхзначное число без средней цифры");
int value1, value2, value3;
int num = new Random().Next(100, 999);
System.Console.WriteLine("Случайное трёхзначное число до преобразования:");
System.Console.WriteLine($"> {num}");

value1 = num % 10;
value2 = num / 10 % 10;
value3 = num / 100 % 10;
System.Console.WriteLine("Случайное трёхзначное число после преобразования:");
System.Console.Write($"> {value3}");
System.Console.Write($"{value1}");

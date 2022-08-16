int Promt(string message)
{

    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
System.Console.WriteLine("Введите номер дня недели");
int value1 = Promt("Введите число > ");
//int value2 = Promt("Введите второе число > ");
if(value1 != 6 && value1 != 7)
    System.Console.WriteLine("День рабочий");
else
    System.Console.WriteLine("День выходной");

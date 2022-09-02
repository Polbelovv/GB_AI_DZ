//Задача 2: Напишите программу, которая найдёт точку пересечения двух 
//прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Promt(string message)
{

    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
double line1(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double line1 = k1 * x + b1;

    return line1;
}
double line2(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double line2 = k2 * x + b2;
    return line2;
}

System.Console.WriteLine("Введите координаты значения b1, k1, b2 и k2:");
double b1 = Promt("Введите b1 > ");
double k1 = Promt("Введите k1 > ");
double b2 = Promt("Введите b2 > ");
double k2 = Promt("Введите k2 > ");
string result1 = string.Format("{0:f1}", line1(b1, k1, b2, k2));
string result2 = string.Format("{0:f1}", line2(b1, k1, b2, k2));
System.Console.WriteLine($"первая координата точки: {result1}");
System.Console.WriteLine($"вторая координата точки: {result2}");

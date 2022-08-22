//Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.
//////////////////////////////////////////
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int Promt(string message)
{

    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
void Dot_distance(double Ax, double Ay, double Az, double Bx, double By, double Bz)
{
    double valP=Math.Pow((Bx-Ax),2) + Math.Pow((By-Ay),2) + Math.Pow((Bz-Az),2);
    double resD=Math.Sqrt(valP);
    string result = string.Format("{0:f2}", resD);
    System.Console.WriteLine($"Расстояние м/д 2-я точками в 3-d пространстве: {result}");
}
System.Console.WriteLine("Введите координаты точки A в 3-d пространстве:");
double valueAx = Promt("Введите число для Ах > ");
double valueAy = Promt("Введите число для Аy > ");
double valueAz = Promt("Введите число для Аz > ");
System.Console.WriteLine("Введите координаты точки B в 3-d пространстве:");
double valueBx = Promt("Введите число для Bх > ");
double valueBy = Promt("Введите число для By > ");
double valueBz = Promt("Введите число для Bz > ");

Dot_distance(valueAx, valueAy, valueAz, valueBx, valueBy, valueBz);


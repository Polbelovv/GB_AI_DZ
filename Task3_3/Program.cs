//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int Promt(string message)
{

    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void pow(int val)
{
    int p = 0;
    for(int i = 1; i <= val; i++)
    {
        p = i*i*i;
        System.Console.WriteLine($"{p}");
    }
}
System.Console.WriteLine("Введите число для создания таблицы кубов от 1 до N");
int value1 = Promt("Введите число > ");
pow(value1);

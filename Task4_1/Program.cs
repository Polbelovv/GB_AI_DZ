//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Promt(string message)
{

    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void pow(double n, int a)
{
    double p = 0;
    p = n;
    
    if (a == 0){        
        n = 1;
        Console.WriteLine($"{n}");
    }

    if (n == 0){
        n = 0;
        Console.WriteLine($"{n}");
    }

    if (a < 0){
        for(int i = 1; i < a; i++) {
        n*=p;  
               
    }
    Console.WriteLine($"{1/n}");
    }

    if (a > 0){
        for(int i = 1; i < a; i++) {
        n*=p;         
    }
    Console.WriteLine($"{n}");
    }
}
System.Console.WriteLine("Введите основание степени и показатель степени:");
int value1 = Promt("Введите основание степени > ");
int value2 = Promt("Введите показатель степени > ");
pow(value1, value2);
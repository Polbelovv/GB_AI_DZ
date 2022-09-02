//Задача 1: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int Promt(string message)
{

    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
int Even_number(int[] arrA)
{
    int count = 0;
    for (int i = 0; i < arrA.Length; i++)
    {
        if (arrA[i] > 0)
        {
            count++;
        }
    }
    return count;
}
System.Console.WriteLine("Укажие то количество цифр которое желаете ввести:");
int val = Promt("Введите число > ");
int[] arrA = new int[val];
System.Console.WriteLine("Введите желаемое количество случайных чисел:");
for (int i = 0; i < val; i++)
{
    arrA[i] = Promt("Введите числа > ");
}
System.Console.WriteLine("Количество чисел > 0:");
int n = Even_number(arrA);
Console.WriteLine(n);
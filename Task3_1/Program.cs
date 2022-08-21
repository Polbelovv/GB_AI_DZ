//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

int Promt(string message)
{

    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int isPalindrome(int num)
{
    int n = num; 
    int rev = 0;
    int bol;
    while (n!=0)
    {
        int r = n % 10;
        rev = rev * 10 + r;
        n = n / 10;
    }
    if (num == rev)
        bol = 1;
    else
        bol = 0;
    return (bol);
}

System.Console.WriteLine("Введите число для проверки на палиндром");
int value1 = Promt("Введите число > ");
if (isPalindrome(value1)==1) {
        System.Console.WriteLine("Palindrome");
    }
    else {
        System.Console.WriteLine("Not Palindrome");
    }

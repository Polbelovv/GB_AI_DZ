//Задача 3: Напишите программу, которая задаёт массив из 8 элементов,
//выводит их на экран. И ищет второй максимум 
//(элемент меньше максимального, но больше всех остальных)
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33], 19

int Promt(string message)
{
    
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
void Sort_insert(int[] arrA)
{
    for(int i=1;i<8;i++){
		for(int j=i; j>0 && arrA[j-1]>arrA[j];j--){
			int tmp=arrA[j-1];
			arrA[j-1]=arrA[j];
			arrA[j]=tmp;
		}
    }
System.Console.WriteLine("Второе максимальное число в массиве:"); 
        Console.WriteLine(arrA[6]);
}
int [] arrA = new int[8];
System.Console.WriteLine("Введите случайные 8 чисел:");
for (int i = 0; i < 8; i++){
    arrA[i] = Promt("Введите числа для заполнения массива А > ");
}

Sort_insert(arrA);

// сортировка массива вставками

int Promt(string message)
{
    
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
void Sort_insert(int[] arrA)
{
    for(int i=1;i<10;i++){
		for(int j=i; j>0 && arrA[j-1]>arrA[j];j--){
			int tmp=arrA[j-1];
			arrA[j-1]=arrA[j];
			arrA[j]=tmp;
		}
    }
   int count = arrA.Length;
    for(int i = 0; i < count; i++)  
        Console.WriteLine(arrA[i]);
}
int [] arrA = new int[10];
System.Console.WriteLine("Введите случайные 10 чисел:");
for (int i = 0; i < 10; i++){
    arrA[i] = Promt("Введите числа для заполнения массива А > ");
}

Sort_insert(arrA);




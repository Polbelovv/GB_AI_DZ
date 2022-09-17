// Написать программу, которая из имеющегося массива строк формирует массив
// из строк, длянна которых меньше либо равна 3 символа.


void Replase(ref char[] text, int index)
{

    char[] newText = new char[text.Length - 1];

    for (int i = 0; i < index; i++)
    {
        newText[i] = text[i];
    }
    for (int i = index + 1; i < text.Length; i++)
    {
        newText[i - 1] = text[i];
    }

    text = newText;

}
void Remove(ref char[] text)
{
    Replase(ref text, text.Length - 1);
    Replase(ref text, text.Length - 2);


    Console.WriteLine(text);
}



string sometext = "Hello";
char[] text = sometext.ToCharArray();
Remove(ref text);

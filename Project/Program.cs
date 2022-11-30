// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо 
// равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении 
// не рекомендуется пользоваться коллекциями, лучше обойтись 
// исключительно массивами.

string[] text = {"Hello", "World", "!!!", ";-)"};
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}
int FindSizeNewArray(string[] text)
{
    int lengthNewArray = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if(text[i].Length <= 3)
        lengthNewArray++;
    }
    return lengthNewArray;
}
string[] CreateNewArray(string[] text, int size)
{
    int pos = 0;
    int chr = 3;
    string[] newArray = new string[size];
    for (int i = 0; i < text.Length; i++)
    {
        if(text[i].Length <= chr) 
        {
            newArray[pos] = text[i];
            pos++;
        }
    }
    return newArray;
}
PrintArray(text);
Console.Write(" -> ");
int length = FindSizeNewArray(text);
string[] array = CreateNewArray(text,length);
PrintArray(array);


// Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.WriteLine("Enter the words separated by a space into a line:");
string String = Console.ReadLine()!;
string[] array = String.Split(" ");
int size = SortArray(array);


int SortArray(string[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result++;
        }
    }
    return result;
}

string[] NewArray(int size)
{
    string[] ArrayResult = new string[size];
    int i = 0;
    int j = 0;
    while (i < array.Length)
    {
        if (array[i].Length <= 3)
        {
            ArrayResult[j] = array[i];
            j++;
        }
        i++;
    }
    return ArrayResult;

}

Console.WriteLine($" [{String.Join(", ", NewArray(size))}]");
Console.ReadLine();


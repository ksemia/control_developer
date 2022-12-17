using static System.Console;
Clear();


string[]array = {"hello","bye","nice","yes"};
int len = 3;
string[] GetNewArray(string[]array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if(array[i].Length <= len)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);
    return result;
}

void PrintArray(string[] array)
{
    if(array.Length == 0)
    {
        Console.WriteLine("массив пустой");
    }
    else
    {
        Array.ForEach(array, (str) => Console.Write($"{str} "));
        Console.WriteLine();
    }
}
void PrintFinal(string[] array)
{
    Console.WriteLine("Исходный массив: ");
    PrintArray(array);
    string[] Array2 = GetNewArray(array);
    Console.WriteLine($"Финальный массив (слова в массиве меньше или равны {len} символам):");
    PrintArray(Array2);
    Console.WriteLine();
}
PrintFinal(array);
string[] array = { "Moscow", "Stavropol", ":-)", "26" };
string[] newArray = new string[array.Length];

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]   ->   ");
    //Console.WriteLine();
}

void FillNewArray(string[] newArray)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[i] = array[i];
        }
    }
}

void PrintNewArray(string[] newArray)
{
    Console.Write("[");
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"{newArray[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}

PrintArray(array);
FillNewArray(newArray);
PrintNewArray(newArray);


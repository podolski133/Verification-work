string[] array1 = new string[7] {"999", "zorro", "and", "555666", "888", "and", "777"};
string[] array2 = new string[array1.Length];

void Array(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
Console.Write("Меньше либо равно 3 символа => ");

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Array(array1, array2);
PrintArray(array2);
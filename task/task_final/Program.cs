string[] arrayOne = new string[8] { "888", "15", "string", "hithere", "bro", "475", "kate", "wohoo" };
string[] arrayTwo = new string[arrayOne.Length];

void AccessoryArray(string[] arrayOne, string[] arrayTwo)
{
    int count = 0;
    for (int i = 0; i < arrayOne.Length; i++)
    {
        if (arrayOne[i].Length <= 3)
        {
            arrayTwo[count] = arrayOne[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
AccessoryArray(arrayOne, arrayTwo);
PrintArray(arrayTwo);
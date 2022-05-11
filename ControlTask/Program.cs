void MyNewArray(string[] inputArray, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < 11; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            newArray[count] = inputArray[i];
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

string[] inputArray = new string[11]
{"hallo", "2", "world", ":-)", "1234", "1567", "-2",
"computer science", "Rus", "Denmark", "Kazan"};
string[] newArray = new string[11];

MyNewArray(inputArray, newArray);
PrintArray(newArray);



string[] words(string[] array)
{

    string[] NewWords = new string[11];

    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            NewWords[count] = array[i];
            count++;
        }
    }
    return NewWords;
}

void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
}

string[] NewArray = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };

Print(words(NewArray));

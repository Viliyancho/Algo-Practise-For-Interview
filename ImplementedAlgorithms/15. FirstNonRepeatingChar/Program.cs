// Given a string, return the first character that does not repeat.


string word = Console.ReadLine();

char[] sequence = word.ToCharArray();

for (int i = 0; i < sequence.Length; i++)
{
    if (CountOfChar(sequence[i]) == 1)
    {
        Console.WriteLine(sequence[i]);
        return;
    }
}
Console.WriteLine("There is no non-repeating character in this word!");

int CountOfChar(char v)
{
    int count = 0;

    foreach (var item in sequence)
    {
        if(v == item)
        {
            count++;
        }
    }

    return count;   
}
// Given a sentence, find the longest word in it


string[] sentence = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

if(sentence.Length == 0)
{
    Console.WriteLine("The sequence is empty!");
    return;
}

string longestWord = sentence[0];

for (int i = 1; i < sentence.Length; i++)
{
    if (sentence[i].Length > longestWord.Length)
    {
        longestWord = sentence[i];
    }
}

Console.WriteLine(longestWord);
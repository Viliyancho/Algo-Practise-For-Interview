// Given a string, count the number of vowels (a, e, i, o, u) in it.

using System.Diagnostics.Tracing;

string word = Console.ReadLine();
string vowels = "aeiouAEIOU";
int count = 0;

for (int i = 0; i < word.Length; i++)
{
    if (vowels.Contains(word[i]))
    {
        count++;
    }
}

Console.WriteLine(count);
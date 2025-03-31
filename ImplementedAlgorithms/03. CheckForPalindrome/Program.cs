//Given a string, determine if it reads the same forward and backward.

string word = Console.ReadLine();

if(word.Length == 0)
{
    throw new Exception("Empty word");
}

int count = word.Length / 2;
bool isPalindrome = true;

while (count > 0)
{
    if (word[count] != word[word.Length - count - 1])
    {
        isPalindrome = false;
        break;
    }
    count--;
}
Console.WriteLine(isPalindrome);
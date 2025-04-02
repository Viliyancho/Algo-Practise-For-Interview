// Given two strings, determine if they are anagrams of each other.

string a = Console.ReadLine();
string b = Console.ReadLine();

if(a.Length != b.Length)
{
    Console.WriteLine("The words are not anagrams!");
    return;
}

char[] charsA = a.ToCharArray();
char[] charsB = b.ToCharArray();

int countA = 0;
while (a.Length / 2 > countA)
{
    char temp = charsA[countA];
    charsA[countA] = charsA[a.Length - 1 - countA];
    charsA[a.Length - 1 - countA] = temp;

    countA++;
}
//Array.Sort(charsA);


int countB = 0;
while (b.Length / 2 > countB)
{
    char temp = charsB[countB];
    charsB[countB] = charsB[b.Length - 1 - countB];
    charsB[b.Length - 1 - countB] = temp;

    countB++;
}
//Array.Sort(charsB);

if(charsA.ToString() == charsB.ToString())
{
    Console.WriteLine("The words are anagrams!");
    return;
}
Console.WriteLine("The words are not anagrams!");
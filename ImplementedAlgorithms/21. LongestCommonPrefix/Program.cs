// Given an array of strings, find the longest common prefix among them. от началната точка 

string[] words = Console.ReadLine().Split().ToArray();

string prefix = words[0];

if (prefix.Length == 0)
{
    throw new Exception();
}

for (int i = 1; i < words.Length; i++)
{
    while (true)
    {
        if (words[i].Contains(prefix))
        {
            break;
        }
        prefix = prefix.Substring(0, prefix.Length - 1);
        if(prefix.Length == 0)
        {
            Console.WriteLine("There is now commong prefix among the words!");
            return;
        }
    }
}
Console.WriteLine(prefix);
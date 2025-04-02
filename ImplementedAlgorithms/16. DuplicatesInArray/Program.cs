// Given an array, find all duplicate elements.

int[] arr = new int[] { 1, 1, 3, 3, 4, 5, 6, 10, 12, 12, 20, 3, 1 };

Dictionary<int, int> dic = new Dictionary<int, int>();

foreach (int i in arr)
{
    if(dic.ContainsKey(i))
    {
        dic[i]++;
    }
    else
    {
        dic[i] = 1;
    }
}

foreach (var i in dic)
{
    if(i.Value > 1)
    {
        Console.Write($"{i.Key}, ");
    }
}

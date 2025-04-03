// Given an array of size n, find the element that appears
// more than n/2 times. If no such element exists, return null.



int[] numbers = new int[] { 1, 2, 3, 4, 1, 1, 1 };

Console.WriteLine(FindMajorityElement(numbers));

T FindMajorityElement<T>(T[] numbers)
{
    Dictionary<T, int> dic = new();
    int count = numbers.Length / 2 + 1;

    foreach (T number in numbers)
    {
        if(dic.ContainsKey(number))
        {
            dic[number]++;
            continue;
        }
        dic.Add(number, 1);
    }

    foreach (var kvp in dic)
    {
        if(kvp.Value >= count)
        {
            return kvp.Key;
        }
    }

    return default(T);
}

// Given an array of integers, find the element that appears most frequently. 
// If there are multiple, return any one of them.


int[] numbers = new int[] { 1, 2, 3, 4, 1, 1, 8 , 2, 3, 10, 11, 1, 3, 3};

Console.WriteLine(string.Join(", ", MostFrequentNum(numbers)));

List<T> MostFrequentNum<T>(T[] numbers)
{
    if(numbers.Length == 0)
    {
        throw new Exception();
    }

    List<T> list = new List<T>();
    Dictionary<T, int> dic = new Dictionary<T, int>();

    foreach (var item in numbers)
    {
        if (dic.ContainsKey(item))
        {
            dic[item]++;
            continue;
        }
        else
        {
            dic.Add(item, 1);
        }
    }

    int maxCount = 0;

    foreach (var kvp in dic)
    {
        if(kvp.Value > maxCount)
        {
            maxCount = kvp.Value;
        }
    }

    foreach (var kvp in dic)
    {
        if(kvp.Value == maxCount)
        {
            list.Add(kvp.Key);
        }
    }


    return list;
}
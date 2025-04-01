int[] arr = new int[] { 1, 42323, 124, 62, -523, 12, 4, 5, 6 };

Console.WriteLine(FindMin(arr));
Console.WriteLine(FindMax(arr));

static int FindMin(int[] arr)
{
    if(arr.Length == 0)
    {
        throw new Exception();
    }
    int min = arr[0];
    foreach(int i in arr)
    {
        if(i < min)
        {
            min = i;
        }
    }
    return min;
}

static int FindMax(int[] arr)
{
    if (arr.Length == 0)
    {
        throw new Exception();
    }
    int max = arr[0];
    foreach (int i in arr)
    {
        if (i > max)
        {
            max = i;
        }
    }
    return max;
}
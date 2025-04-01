//Merge two sorted arrays into one sorted array.

int[] n = new int[] { 4, 124, 24, 56, 1, 4 };
int[] m = new int[] { 1, 214, 3, 4,16, 20};

int[] newArr = new int[n.Length + m.Length];
newArr = MergeArrays(n, m);

Array.Sort(newArr);

Console.WriteLine(string.Join(", ", newArr));

static int[] MergeArrays(int[] n, int[] m)
{
    List<int> list = new List<int>();

	foreach (var item in n)
	{
		list.Add(item);
	}

    foreach (var item in m)
    {
        list.Add(item);
    }

    return list.ToArray();
}
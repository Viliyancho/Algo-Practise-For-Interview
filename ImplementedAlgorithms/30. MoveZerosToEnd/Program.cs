//Given an array, move all 0s to the end while maintaining
//the order of the other elements.

int[] arr = new int[] {1, 0 , 3, 0 , 5, 1, 2, 0, 6, 10, 11, 0 };

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == 0)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            arr[j - 1] = arr[j];
        }
        arr[arr.Length - 1] = 0;
    }
}

Console.WriteLine(string.Join(", ", arr));
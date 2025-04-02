// Implement the Selection Sort algorithm.
// Пряка селекция
// О(n^2)


int[] arr = new int[] { 1, 5, 9, 3, 11, 15, 7, 13 };

SelectionSort(arr);

Console.WriteLine(string.Join(", ", arr));

void SelectionSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
}
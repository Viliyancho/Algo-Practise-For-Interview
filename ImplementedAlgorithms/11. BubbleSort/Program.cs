// Implement the Bubble Sort algorithm to sort an array.


int[] arr = new int[] { 1, 5, 9, 3, 11, 15, 7, 13 };

BubbleSort(arr);

Console.WriteLine(string.Join(", ", arr));

void BubbleSort(int[] arr)
{
	for (int i = 0; i < arr.Length - 1; i++)
	{
		int temp = arr[0];
		for (int j = 0; j < arr.Length - 1 - i; j++)
		{
			if (arr[j] > arr[j + 1])
			{
				temp = arr[j];
				arr[j] = arr[j + 1];
				arr[j + 1] = temp;
			}
		}
	}
}
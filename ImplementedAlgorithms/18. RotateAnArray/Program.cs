// Rotate an array to the right by k positions.


int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Select count positions: ");
int count = int.Parse(Console.ReadLine());

RotateArray(arr, count);

Console.WriteLine(string.Join(", ", arr));

void RotateArray(int[] arr, int count)
{
	for (int i = 0; i < count; i++)
	{
		int lastNum = arr[arr.Length - 1];

		for (int j = arr.Length - 2; j > -1; j--)
		{
			arr[j+ 1] = arr[j];
		}
		arr[0]  = lastNum;
	}
}
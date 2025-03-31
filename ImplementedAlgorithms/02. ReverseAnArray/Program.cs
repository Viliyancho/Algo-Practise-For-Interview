//Given an array, reverse its elements in place.

int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine(string.Join(", ", arr));  

int count = 0;
while(arr.Length / 2 > count)
{
    int temp = arr[arr.Length - count - 1];
    arr[arr.Length - count - 1] = arr[count];
    arr[count] = temp;

    count++;
}
Console.WriteLine(string.Join(", ", arr));
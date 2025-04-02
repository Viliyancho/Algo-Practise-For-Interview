// Given an array containing n-1 numbers from 1 to n, find the missing number.

int[] arr = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

int count = 0;

for (int i = 0; i < arr.Length - 1; i++)
{
    if (arr[i] + 1 != arr[i + 1])
    {
        count++;
    }
}
if(count != 1)
{
    throw new Exception("Its not the right order");
}

for (int i = 0;i < arr.Length - 1; i++)
{
    if (arr[i] + 1 != arr[i+1])
    {
        Console.WriteLine(arr[i] + 1);
        return;
    }
}
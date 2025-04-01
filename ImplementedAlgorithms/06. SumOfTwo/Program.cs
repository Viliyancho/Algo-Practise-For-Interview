//Given an array and a target sum, find two numbers that add up to the target.

int[] n = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int num = int.Parse(Console.ReadLine());

for (int i = 0; i < n.Length - 1; i++)
{
    for (int j = i + 1; j < n.Length; j++)
    {
        if (n[i] + n[j] == num)
        {
            Console.WriteLine($"First: {n[i]}, Second: {n[j]}\n");
        }
    }
}
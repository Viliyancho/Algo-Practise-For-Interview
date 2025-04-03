// Given an integer, determine if it is a power of two.


int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= Math.Sqrt(n); i++)
{
    for (int j = 1; j <= Math.Sqrt(n); j++)
    {
        if(Math.Pow(i, j) == n)
        {
            Console.WriteLine($"First is: {i}; Second is {j}");
        }
    }
}
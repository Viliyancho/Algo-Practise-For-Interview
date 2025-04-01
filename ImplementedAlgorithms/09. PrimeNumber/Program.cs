// Determine if a given number n is prime.

int n = int.Parse(Console.ReadLine());

Console.WriteLine(IsPrime(n));


static bool IsPrime(int num)
{
    if (num < 1)
    {
        return false;
    }
    for (int i = 2; i < num; i++)
    {
        if(num % i == 0)
        {
            return false;
        }
    }
    return true;
}
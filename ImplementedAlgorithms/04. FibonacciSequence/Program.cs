//Generate n count of the Fibonacci numbers using iteration.

int n = int.Parse(Console.ReadLine());
List<int> list = new List<int>();   
list.Add(1);
list.Add(1);

if(n < 1)
{
    throw new Exception("Invalid count of numbers");
}
else if(n == 1)
{
    Console.WriteLine(list[0]);
    return;
}

for(int i = 0; i < n; i++)
{
    if(list.Count <= i)
    {
        list.Add(list[i - 1] + list[i - 2]);
    }
}

Console.WriteLine(string.Join(", ", list));
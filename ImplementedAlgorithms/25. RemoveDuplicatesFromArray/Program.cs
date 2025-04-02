// Given an array, remove all duplicate elements and return the new array
// with unique values.

int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

HashSet<int> result = new HashSet<int>(numbers);

Console.Write($"After removing the duplicates the array is: ");
Console.WriteLine(string.Join(", ", result));
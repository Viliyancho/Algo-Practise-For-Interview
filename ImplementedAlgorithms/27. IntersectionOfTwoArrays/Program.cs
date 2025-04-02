// Given two arrays, return an array containing
// only the elements that appear in both.

int[] numbers1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int[] numbers2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

HashSet<int> numbersFirst = new HashSet<int>(numbers1);
HashSet<int> numbersSecond = new HashSet<int>(numbers2);

List<int> intersectionList = new List<int>();

foreach (int number in numbersFirst)
{
    if (numbersSecond.Contains(number))
    {
        intersectionList.Add(number);
    }
}
if(intersectionList.Count != 0)
Console.WriteLine(string.Join(", ", intersectionList));
else
    Console.WriteLine("There are no similar numbers in the arrays!");
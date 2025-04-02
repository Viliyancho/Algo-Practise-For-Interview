// Given an array of numbers, find the second largest element.

int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

Array.Sort(numbers);

int secondLargest = numbers[numbers.Length - 2];

//if (numbers.Length == 0)
//{
//    Console.WriteLine("Empty array!");
//    return;
//}
//else if(numbers.Length == 1)
//{
//    Console.WriteLine("There is only one number, so there is no second largest one!");
//    return;
//}

//int largest = numbers[0];
//int secondLargest = numbers[0];

//for (int i = 1; i < numbers.Length; i++)
//{
//    if (numbers[i] > largest)
//    {
//        secondLargest = largest;
//        largest = numbers[i];
//    }
//}

Console.WriteLine($"Second largest number in the array is: {secondLargest}");
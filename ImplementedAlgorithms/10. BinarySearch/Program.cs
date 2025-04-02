// Implement binary search on a sorted array to find a target element.
// O(log n)

int[] arr = new int[] { 1, 3, 5, 7, 9, 11, 13, 15 };

Console.WriteLine(FindBinarySearchIndex(arr, 7));



static int FindBinarySearchIndex(int[] arr, int number)
{
    if(arr.Length == 0)
    {
        throw new ArgumentException();
    }

    int left = 0; 
    int right = arr.Length - 1;
    int mid = 0;

    while(left <= right)
    {
        mid = left + (right - left) / 2;
        if (arr[mid] == number)
        {
            return mid;
        }

        if (arr[mid] > number)
        {
            right = mid - 1;
        }
        else if (arr[mid] < number)
        {
            left = mid + 1;
        }
    }


    return -1;
}
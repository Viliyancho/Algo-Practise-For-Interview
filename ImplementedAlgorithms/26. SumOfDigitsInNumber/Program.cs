// Given an integer, return the sum of its digits.

int number = int.Parse(Console.ReadLine());
number = Math.Abs(number);
int sum = 0;
string numberAsString = number.ToString();

foreach (char digit in numberAsString)
{
    sum += (int)digit - '0';
}
Console.WriteLine($"Sum of the digits of the number is: {sum}");
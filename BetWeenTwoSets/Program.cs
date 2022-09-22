/*
There will be two arrays of integers. Determine all integers that satisfy the following two conditions:

List a = The elements of the first array are all factors of the integer being considered
List b = The integer being considered is a factor of all elements of the second array
These numbers are referred to as being between the two arrays. Determine how many such numbers exist.

*/



List<int> a = new List<int>() { 2, 4};
List<int> b = new List<int>() { 16, 32 , 96};
List<int> numOfElements = new List<int>() { 2, 3};

Console.WriteLine(Convert.ToString(getTotalX(a, b)));

int getTotalX(List<int> a, List<int> b)
{
    int count = 0;

    for (int i = 1; i <= 100; i++)
    {
        if (a.All(x => i % x == 0) && b.All(x => x % i == 0))
        {
            count++;
        }
    }
    return count;
}
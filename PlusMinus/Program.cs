using System.ComponentModel;

Console.WriteLine("How much numbers do you want?: ");
int n = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();

List<int> arr = new List<int>(n);

Console.WriteLine("The number of the array: ");
for (int i = 0; i < arr.Count; i++)
{
    arr[i] = rnd.Next(-100, 100);
    Console.Write($"{arr[i]} ");
}

int positive = 0, negative = 0, zero = 0;
foreach(int i in arr)
{
    if (i > 0)
        positive++;
    else if (i < 0)
        negative++;
    else
        zero++;
}

Console.WriteLine($"\n{Math.Round((positive / (double)n),6)}");
Console.WriteLine($"{(negative / (double)n).ToString("n6")}");
Console.WriteLine($"{(zero / (double)n).ToString("n6")}");
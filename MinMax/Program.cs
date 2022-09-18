Random rnd = new Random();
List<int> inputNumbers = new List<int>(5);

Console.WriteLine("Numbers of the input array: ");
for (int i = 0; i < inputNumbers.Count; i++)
{
    inputNumbers[i] = rnd.Next(1, 10);
    Console.Write(" " + inputNumbers[i]);
}



Int64 minSum = 0, maxSum = 0;

inputNumbers.Sort();

for (int i = 0; i < inputNumbers.Count - 1; i++)
{
    minSum += inputNumbers[i];
}

for (int i = 1; i < inputNumbers.Count; i++)
{
    maxSum += inputNumbers[i];
}


Console.WriteLine($"\nThe min and max sum: {minSum} and {maxSum}.");

Console.WriteLine($"{Convert.ToInt64(minSum)} {Convert.ToInt64(maxSum)}");
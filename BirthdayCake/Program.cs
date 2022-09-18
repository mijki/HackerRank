/*  You are in charge of the cake for a child's birthday.
    You have decided the cake will have one candle for each year of their total age. 
    They will only be able to blow out the tallest of the candles. Count how many candles are tallest.

    Returns
    int: the number of candles that are tallest 
*/

using System;

List<int> inputData = new List<int>() {3, 2, 1, 3};

int maxNum = 0, count = 0;
inputData.Sort();

for (int i = 0; i < inputData.Count; i++)
{
    if (inputData[i] > maxNum)
    {
        maxNum = inputData[i];
        count = 1;
    }
    else if (inputData[i] == maxNum)
    {
        count++;
    }
}

Console.WriteLine($"{maxNum} {count}");
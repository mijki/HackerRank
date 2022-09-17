int stairCaseNum = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= stairCaseNum; i++)
{
    for (int j = 1; j <= stairCaseNum; j++)
    {
        if (j <= stairCaseNum - i)
            Console.Write(" ");
        else
            Console.Write("#");
    }
    Console.WriteLine();
}
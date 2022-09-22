/*
 * Maria plays college basketball and wants to go pro. 
 * Each season she maintains a record of her play. 
 * She tabulates the number of times she breaks her season record for most points and least points in a game.
*/

int numberOfGames = 9;
List<int> scores = new List<int>() { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };

breakingRecords(scores);


List<int> breakingRecords(List<int> scores)
{
    int numOfRecordBreaksHigh = 0;
    int numOfRecordBreaksLow = 0;

    int maxScore = 0;
    int minScore = scores.First();

    for (int i = 0; i<scores.Count; i++)
    {
        if (scores[i] > maxScore)
        {
            maxScore = scores[i];
            if(i != 0) numOfRecordBreaksHigh++;
        }
        else if (scores[i] < minScore)
        {
            minScore = scores[i];
            numOfRecordBreaksLow++;
        }
    }

    Console.WriteLine($"{numOfRecordBreaksHigh} {numOfRecordBreaksLow}");
    
    return new List<int>() { numOfRecordBreaksHigh, numOfRecordBreaksLow };
}
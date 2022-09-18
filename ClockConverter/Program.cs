/*
 * Given a time in -hour AM/PM format, convert it to military (24-hour) time.

    Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
    - 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

    Function Description
    Complete the timeConversion function in the editor below. It should return a new string representing the input time in 24 hour format.

    timeConversion has the following parameter(s):
    string s: a time in  hour format

    Returns
    string: the time in  hour format
*/

using System.Threading.Tasks.Dataflow;

string sample1 = "12:23:23AM";
string sample2 = "07:23:52PM";

TimeTo24HourClock(sample1);
TimeTo24HourClock(sample2);



static string TimeTo24HourClock(string s)
{
    string sCopy = s.Remove(8,2);
    string[] tempString = sCopy.Split(':');

    if (s.Contains("AM"))
    {
        if (tempString[0] == "12") tempString[0] = "00";
    }

    if (s.Contains("PM"))
    {
        if (tempString[0] != "12")
        {
            tempString[0] = Convert.ToString(Convert.ToInt32(tempString[0]) + 12);
        }
    }

    sCopy = string.Join(":", tempString);
    Console.WriteLine(sCopy);
    return sCopy;
}
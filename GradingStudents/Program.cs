/*
    HackerLand University has the following grading policy:

    Every student receives a  in the inclusive range from 0 to 100.
    Any  less than  40 is a failing grade.
    Sam is a professor at the university and likes to round each student's  according to these rules:

    If the difference between the grade and the next multiple of  5 is less than , 3 round  up to the next multiple of 5.
    If the value of  grade is less than 38, no rounding occurs as the result will still be a failing grade.
*/

List<int> grades = new List<int> { 73, 67, 38, 33 , 66, 84,};

gradingStudents(grades);


static List<int> gradingStudents(List<int> grades)
{
    for (int i = 0; i < grades.Count; i++)
    {
        if (grades[i] >= 38)
        {
            if (grades[i] % 5 >= 3)
            {
                grades[i] = grades[i] + (5 - (grades[i] % 5));
            }
        }
    }

    return grades;
}
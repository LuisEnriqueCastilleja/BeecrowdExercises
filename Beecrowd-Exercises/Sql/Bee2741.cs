namespace Beecrowd_Exercises.Sql
{
    public class Bee2741
    {
        /*
       The semester is over at South Transylvania University. Every grade was closed, and only Alchemy 104 haven’t published 
       its list of approved students.
       Therefore, you should show the word 'Approved: ' alongisde the the name of a student and the grade, for those who
       have been approved (grade ≥7).
       Remember to sort the list by grade (higher grades first). (BEE 2741)



       -- SOLUTION --
       SELECT CONCAT('Approved: ', name), grade from students
       where grade >= 7
       ORDER BY grade DESC;
       */
    }
}

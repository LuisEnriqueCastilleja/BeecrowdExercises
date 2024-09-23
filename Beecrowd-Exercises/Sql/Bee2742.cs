namespace Beecrowd_Exercises.Sql
{
    public class Bee2742
    {
        /*
        Richard is a famous scientist because of his multiverse theory, where he describes every hypothetical set of 
        parallel universes by means of a database. Thanks to that you now have a job.
        As your first task, you must select every Richard from dimensions C875 and C774, together with its existence
        probability (the famous factor N) with three decimal places of precision.
        Remember that the N factor is calculated by multiplying the omega value by 1,618. The data must be sorted by the 
        least omega value. (BEE 2742)



        -- SOLUTION --
        SELECT l.name, ROUND((l.omega * 1.618), 3) as "Fator N" from life_registry l
        JOIN dimensions d on l.dimensions_id = d.id
        WHERE d.name in ('C875', 'C774') AND l.name LIKE 'Richard%'
        ORDER BY l.omega ASC;
        */
    }
}

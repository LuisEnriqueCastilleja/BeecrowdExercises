namespace Beecrowd_Exercises.Sql
{
    public class Bee2739
    {
        /*
        The Central Bank of Financing lost many registers after a server failure that happened last October. 
        The collection dates for the parcels where lost.
        The bank requested your help to select the names and day of month in which each client must pay theirs parcel.
        OBS: The day of month must be an integer. (BEE 2739)




        -- SOLUTION --
        SELECT name, CAST(EXTRACT(DAY FROM payday) AS INT) as day
        FROM loan
        */
    }
}

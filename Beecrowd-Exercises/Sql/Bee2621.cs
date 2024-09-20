namespace Beecrowd_Exercises.Sql
{
    public class Bee2621
    {
        /*
    When it comes to delivering the report on how many products the company has in stock, a part of the report has 
    become corrupted, so the stock keeper asked for help, he wants you to display the following data for him.
    Display the name of products whose amount are between 10 and 20 and whose name of the supplier starts with the 
    letter 'P'. (BEE 2621)





    -- SOLUTION -- 
    SELECT p.name from products as p
    inner join providers as pr ON p.id_providers = pr.id
    WHERE p.amount BETWEEN 10 AND 20 AND pr.name LIKE 'P%';
*/
    }
}

namespace Beecrowd_Exercises.Sql
{
    public class Bee2623
    {
        /*
       The sales industry needs a report to know what products are left in stock.
       To help the sales industry, display the product name and category name for products whose amount is greater 
       than 100 and the category ID is 1,2,3,6 or 9. Show the results in ascendent order by category ID. (BEE 2623)




       -- SOLUTION --
       SELECT p.name, c.name from products as p
       INNER JOIN categories as c 
       ON p.id_categories = c.id
       WHERE p.amount > 100 AND c.id IN (1,2,3,6,9)
       ORDER BY c.id ASC;
       */
    }
}

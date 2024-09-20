namespace Beecrowd_Exercises.Sql
{
    public class Bee2625
    {
        /*
        Your company's communications managers want a report on the natural person customer data that is registered 
        in the database. But the old report had a problem. customers CPF data came without validation.
        So your job now is to select all the CPFs of all the customers, and apply a mask on the return of the data.
        The CPF mask looks like: '000.000.000-00'. (BEE 2625)





        -- SOLUTION --
        SELECT CONCAT(
            SUBSTRING(cpf, 1, 3), '.', 
            SUBSTRING(cpf, 4, 3), '.', 
            SUBSTRING(cpf, 7, 3), '-', 
            SUBSTRING(cpf, 10, 2)
        ) AS CPF FROM natural_person AS n
        INNER JOIN customers AS c
        ON n.id_customers = c.id;
        */
    }
}

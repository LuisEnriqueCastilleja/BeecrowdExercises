namespace Beecrowd_Exercises.Sql
{
    public class Bee3483
    {
        /*
        Encuentre la ciudad con la segunda población más grande y luego la ciudad con la segunda 
        población más pequeña. (Bee3483)




        -- SOLUTION --
        (
        SELECT city_name, population
        FROM cities
        ORDER BY population DESC
        LIMIT 1 OFFSET 1
        )
        UNION ALL
        (
        SELECT city_name, population
        FROM cities
        ORDER BY population ASC
        LIMIT 1 OFFSET 1
        );
        */

    }
}

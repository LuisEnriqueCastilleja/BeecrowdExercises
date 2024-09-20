namespace Beecrowd_Exercises.Sql
{
    public class Bee2740
    {
        /*
        The International Underground Excavation League is a success between alternative sports, however the staff 
        responsible for organizing the events doesn’t understand computers at all, they only know how to dig and the 
        sport rule set. As such, you were hired to solve the League’s problem.
        Select the three first placed with the initial phrase "Podium: " and select the last two, which will be demoted to
        a lower league with the initial phrase “Demoted:". (BEE 2740)





        -- SOLUTION --
        SELECT 
            CASE 
                WHEN position <= 3 THEN CONCAT('Podium: ', team)
                WHEN position >= 14 THEN CONCAT('Demoted: ', team)
            END AS name
        FROM league
        WHERE position <= 3 OR position >= 14;







        -- OTHER SOLUTION
        (SELECT CONCAT('Podium: ', team) AS name FROM league 
        WHERE position = 1)

        UNION ALL

        (SELECT CONCAT('Podium: ', team) AS name FROM league 
        WHERE position = 2)

        UNION ALL

        (SELECT CONCAT('Podium: ', team) AS name FROM league 
        WHERE position = 3)

        UNION ALL

        (SELECT CONCAT('Demoted: ', team) AS name FROM league 
        WHERE position = 14)

        UNION ALL

        (SELECT CONCAT('Demoted: ', team) AS name FROM league 
        WHERE position = 15);
        */
    }
}

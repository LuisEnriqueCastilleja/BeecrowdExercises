﻿namespace Beecrowd_Exercises.Sql
{
    public class Bee2745
    {
        /*
        You are going to the International Personal Tax meeting and your proposal is: every individual with income 
        higher than 3000 must pay a tax to the government, which is 10% of his/her income.
        Show the name and the tax value of each person who earns more than 3000, with two decimal places 
        of precision. (BEE 2745)



        -- SOLUTION --
        SELECT name, ROUND((salary * 0.10),2) AS "tax" from people
        WHERE salary > 3000;
        */
    }
}

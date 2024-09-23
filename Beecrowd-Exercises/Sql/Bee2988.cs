namespace Beecrowd_Exercises.Sql
{
    public class Bee2988
    {
        /*
        The Soccer Cearense Championship attracts thousands of fans every year and you work for a newspaper and are 
        in charge to calculate the score table. Show a table with the following rows: the team name, number of
        matches, victories, defeats, draws, and scores. Knowing that the score is calculated with each victory 
        valuing 3 points, draw valuing 1 and defeat valuing 0. In the end, show your table with the score from the
        highest to the lowest. (BEE 2988)

        SELECT t.name,
        COUNT(t.id) as matches,
        SUM(
            CASE 
            WHEN t.id =m.team_1 AND m.team_1_goals > m.team_2_goals THEN 1
            WHEN t.id = m.team_2 AND m.team_2_goals > m.team_1_goals THEN 1 else 0  END) as victories,
        SUM(
            CASE
            WHEN t.id = m.team_1 AND m.team_1_goals < m.team_2_goals THEN 1
            WHEN t.id = m.team_2 AND m.team_2_goals < m.team_1_goals THEN 1 else 0 ENd) as defeats,
        SUM(
            CASE
            WHEN t.id = m.team_1 AND m.team_1_goals = m.team_2_goals THEN 1
            WHEN t.id = m.team_2 AND m.team_2_goals = m.team_1_goals THEN 1 else 0 END) as draws,
        SUM(
            CASE
            WHEN t.id =m.team_1 AND m.team_1_goals > m.team_2_goals OR t.id =m.team_2 AND m.team_2_goals > m.team_1_goals THEN 3
            WHEN t.id =m.team_1 AND m.team_2_goals = m.team_1_goals OR t.id =m.team_2 AND m.team_2_goals = m.team_1_goals THEN 1 
        else 0 END) as score
        FROM teams AS t
        INNER JOIN matches as m
        ON t.id = m.team_1 OR t.id = m.team_2
        GROUP BY t.name
        ORDER BY victories DESC;
        */
    }
}

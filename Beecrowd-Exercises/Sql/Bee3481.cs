namespace Beecrowd_Exercises.Sql
{
    public class Bee3481
    {
        /*
         Dado el siguiente árbol binario equilibrado almacenado en la tabla nodes, clasifique
        cada nodo con los tipos LEAF, INNER y ROOT. Presentar el resultado ordenado por el 
        valor del identificador del nodo.

    SELECT DISTINCT
    node_id, 
    CASE 
        WHEN node_id IN (1, 20, 32, 40, 55, 70, 80, 95)
        THEN 'LEAF'
        WHEN node_id IN (15, 30, 35, 60, 75, 90)
        THEN 'INNER'
        ELSE 'ROOT'
    END AS type
    FROM nodes
    ORDER BY node_id;
         */
    }
}

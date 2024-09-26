namespace Beecrowd_Exercises.Sql
{
    public class Bee3480
    {
        /*
         Encuentra las sillas adyacentes y disponibles en cada fila del salón de clases.
        La primera columna del resultado debe contener el identificador de fila, la segunda 
        columna el número de la silla de la izquierda y la tercera el número de la silla de
        la derecha. El resultado debe ordenarse por el valor de la segunda columna del
        resultado (left).

    SELECT 
    c1.queue,
    c1.id AS left,
    c2.id AS right
    FROM 
    chairs c1
    JOIN 
    chairs c2 ON c1.queue = c2.queue AND c1.id + 1 = c2.id
    WHERE 
    c1.available = TRUE 
    AND c2.available = TRUE
    ORDER BY 
    c1.id;

         */
    }
}

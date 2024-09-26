namespace Beecrowd_Exercises.Principiante
{
    public class Bee1006
    {
        /*
      Leer tres valores (variables A, B y C), que son las tres notas de
     estudiantes. Entonces, calcule el promedio, considerando que la nota A tiene 
     peso 2, la nota B tiene peso 3 y la nota C tiene peso 5. Cosiderar que cada
     nota puede ser del 0 al 10.0, siempre con un punto decimal.

     Entrada
     El archivo de entrada contiene 3 valores de punto flotante (double) con un 
     dígito decimal después de la coma.

     Salida
     Imprime el mensaje "MEDIA"(Promedio en Portugués) y el promedio de los estudiantes 
     de acuerdo con el siguiente ejemplo, con un espacio en blanco antes y después del 
     signo igual.
        
         
    
    -- SOLUTION --
    float a = float.Parse(Console.ReadLine());
    float b = float.Parse(Console.ReadLine());
    float c = float.Parse(Console.ReadLine());
    float aPlusBplusC = (float)(a * 2 + b * 3 + c * 5);
    float promedio = (float)(aPlusBplusC / (2 + 3 + 5));
    Console.WriteLine($"MEDIA = {promedio.ToString("F1")}");
    */


    }
}

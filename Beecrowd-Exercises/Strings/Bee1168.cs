namespace Beecrowd_Exercises.Strings
{
    public class Bee1168
    {
        //John quiere configurar un panel que contenga diferentes números con LEDs. No posee muchos
        //LEDs y no está seguro de si él será capaz de montar el número deseado. Considerando la
        //configuración de los LEDs de los siguientes números, realice un algoritmo que le ayude a
        //descubrir el número de LEDs necesarios para establecer el valor.

        //Nota: Para los programadores de Javascript, se recomienda usar "input.trim().split('\n')"
        //para evitar errores conocidos.




        //Entrada
        //La entrada contiene un entero N, (1 ≤ N ≤ 2000) correspondiente al número de casos de prueba,
        //seguido por N líneas, cada línea que contiene un número (1 ≤ V ≤ 10100) correspondiente al
        //valor que John quiere establecer con el Leds.

        //Salida
        //Para cada caso de prueba, imprima una línea que contenga el número de LEDs que John necesita
        //para establecer el valor deseado, seguido por la palabra "leds".

        //Ejemplos de Entrada	Ejemplos de Salida
        //3
        //115380                27 leds
        //2819311               29 leds 
        //23456                 25 leds

        /*
         1 = 2 Leds.
         2 = 5 Leds.
         3 = 5 Leds.
         4 = 4 Leds.
         5 = 5 Leds.
         6 = 6 Leds.
         7 = 3 Leds.
         8 = 7 Leds.
         9 = 6 Leds.
         0 = 6 Leds.
        */


        //        int length = int.Parse(Console.ReadLine());
        //        List<string> values = new List<string>();
        //        List<int> valuesToPrint = new List<int>();
        //        int numberOfLeds = 0;

        //for (int i = 0; i<length; i++)
        //{
        //    values.Add(Console.ReadLine());
        //}

        //foreach (var item in values)
        //{
        //    for (int i = 0; i<item.Length; i++)
        //    {
        //        switch (item[i])
        //        {
        //            case '1':
        //                numberOfLeds += 2;
        //                break;
        //            case '2':
        //                numberOfLeds += 5;
        //                break;
        //            case '3':
        //                numberOfLeds += 5;
        //                break;
        //            case '4':
        //                numberOfLeds += 4;
        //                break;
        //            case '5':
        //                numberOfLeds += 5;
        //                break;
        //            case '6':
        //                numberOfLeds += 6;
        //                break;
        //            case '7':
        //                numberOfLeds += 3;
        //                break;
        //            case '8':
        //                numberOfLeds += 7;
        //                break;
        //            case '9':
        //                numberOfLeds += 6;
        //                break;
        //            case '0':
        //                numberOfLeds += 6;
        //                break;
        //        }
        //    }
        //    valuesToPrint.Add(numberOfLeds);
        //numberOfLeds = 0;
        //}

        //foreach (var item in valuesToPrint)
        //{
        //    Console.WriteLine($"{item} leds");
        //}
    }
}

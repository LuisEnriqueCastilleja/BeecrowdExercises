namespace Beecrowd_Exercises.Principiante
{
    public class Bee1012
    {
        /*
    Escriba un programa que lea tres valores de punto flotante: A, B y C. Luego, calcular y
   mostrar:
   a) El área del triángulo rectángulo de base A y altura C.
   b) El área del círculo de radio C (Pi = 3.14159).
   c) El área del trapecio el cual tiene A y B como bases, y C como altura.
   d) El área del cuadrado de lado B.
   e) El área del rectángulo de lados A y B.

   Entrada
   La entrada contiene tres valores de doble precisión con un dígito luego del punto decimal.

   Salida
   La salida contiene 5 renglones. Cada uno de los renglones corresponde a las áreas descriptas
   anteriormente, siempre con el mensaje correspondiente (en portugués) y un espacio entre los
   dos puntos y el valor. El valor calculado debe ser presentado con 3 dígitos luego del punto
   decimal.

   string values = Console.ReadLine();
   values.ToCharArray();
   string[] valuesToPrint = values.Split(' ');
   double a = double.Parse(valuesToPrint[0]);
   double b = double.Parse(valuesToPrint[1]);
   double c = double.Parse(valuesToPrint[2]);

   double triangle = (a * c) / 2;
   double circulo = (c * c) * 3.14159;
   double trapezio = ((a + b) * c) / 2;
   double quadrado = b * b;
   double retangulo = a * b;

   Console.WriteLine($"TRIANGULO: {triangle.ToString("F3")}");
   Console.WriteLine($"CIRCULO: {circulo.ToString("F3")}");
   Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3")}");
   Console.WriteLine($"QUADRADO: {quadrado.ToString("F3")}");
   Console.WriteLine($"RETANGULO: {retangulo.ToString("F3")}");
    */
    }
}

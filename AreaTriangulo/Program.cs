using System;
using System.Globalization;

namespace AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangulo x, y;

                x = new Triangulo();
                y = new Triangulo();

                Console.WriteLine("Entre com as medidas do triângulo X: ");
                x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Entre com as medidas do triângulo Y: ");
                y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                x.CalcularArea();
                y.CalcularArea();

                Console.WriteLine($"Área de x = {x.Area.ToString("F4", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Área de x = {y.Area.ToString("F4", CultureInfo.InvariantCulture)}");

                if (x.Area > y.Area)
                    Console.WriteLine("Maios área: X");
                else if (x.Area == y.Area)
                    Console.WriteLine("Os dois triângulos possuem a mesma área");
                else
                    Console.WriteLine("Maior área: Y");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Erro de formatação: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro inesperado: {e.Message}");
            }
        }
    }
}

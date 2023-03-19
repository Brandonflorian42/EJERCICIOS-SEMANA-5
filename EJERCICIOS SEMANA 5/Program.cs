//1) Crear una funcion que calcule el area de un circulo, recibiendo como parametro el radio.
using System;
class Program
{
    static void Main(string[] args)
    {
        // Solicitar el radio del usuario
        Console.Write("Ingrese el radio del círculo: ");
        double radio = double.Parse(Console.ReadLine());
        // Calcular el área del círculo
        double area = Math.PI * radio * radio;
        // Mostrar el resultado al usuario
        Console.WriteLine("El área del círculo es: " + area);

    }
}

//2) Crear una funcion que calcule el perimetro de un retangulo, recibiendo como parametros el ancho y la altura
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Por favor, Ingresar el ancho del rectangulo: ");
        double ancho = double.Parse(Console.ReadLine());

        Console.Write("Por favor, Ingresar el altura del rectangulo: ");
        double altura = double.Parse(Console.ReadLine());

        double perimetro = 2 * (ancho + altura);

        Console.WriteLine("El perimetro del rentangulo es: " + perimetro);
    }

    static double Calcularperimetro(double ancho, double altura)
    {
        return 2 * (ancho + altura);
    }
}

//3) Crear una funcion que calcule el promedio de una lista de numeros, recibiendo como parametro la cadena

using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 5, 10, 15, 20 };
        double average = CalcularPromedio(numbers);
        Console.WriteLine("El promedio de la lista de números es: {0}", average);
    }
    static double CalcularPromedio(List<int> numeros)
    {
        int suma = 0;
        foreach (int numero in numeros)
        {
            suma += numero;
        }
        double promedio = (double)suma / numeros.Count;
        return promedio;
    }
}

// 4) Crear una funcion que determine si un numero es par o impar, recibiendo como parametro el numero

using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita al usuario que ingrese un número
            Console.Write("Ingrese un número entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Llama a la función EsPar para determinar si el número es par o impar
            if (EsPar(numero))
            {
                Console.WriteLine("El número es par");
            }
            else
            {
                Console.WriteLine("El número es impar");
            }
        }

        // Función que determina si un número es par o impar
        static bool EsPar(int numero)
        {
            // Comprueba si el número es divisible entre 2
            if (numero % 2 == 0)
            {
                return true; // El número es par
            }
            else
            {
                return false; // El número es impar
            }
        }
    }
}

// 5) Crear una funcion que convierta una cadena a mayusculas, recibiendo como parametro la cadena

using System;

namespace ConvertirMayusculas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita al usuario que ingrese una cadena
            Console.Write("Ingrese una cadena: ");
            string cadena = Console.ReadLine();

            // Llama a la función ConvertirAMayusculas para convertir la cadena a mayúsculas
            string cadenaMayusculas = ConvertirAMayusculas(cadena);

            // Imprime la cadena convertida a mayúsculas
            Console.WriteLine("La cadena en mayúsculas es: " + cadenaMayusculas);
        }

        // Función que convierte una cadena a mayúsculas
        static string ConvertirAMayusculas(string cadena)
        {
            string cadenaMayusculas = cadena.ToUpper();
            return cadenaMayusculas;
        }
    }
}

// 6) Crear una funcion que calcule la distancia entre dos puntos en un plano cartesiano, recibiendo como parametro las coordenadas x e y de ambos puntos 
using System;

namespace DistanciaEntrePuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita al usuario que ingrese las coordenadas del primer punto
            Console.Write("Ingrese la coordenada X del primer punto: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la coordenada Y del primer punto: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            // Solicita al usuario que ingrese las coordenadas del segundo punto
            Console.Write("Ingrese la coordenada X del segundo punto: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la coordenada Y del segundo punto: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            // Llama a la función CalcularDistancia para calcular la distancia entre los dos puntos
            double distancia = CalcularDistancia(x1, y1, x2, y2);

            // Imprime la distancia entre los dos puntos
            Console.WriteLine("La distancia entre los dos puntos es: " + distancia);
        }

        // Función que calcula la distancia entre dos puntos en un plano cartesiano
        static double CalcularDistancia(double x1, double y1, double x2, double y2)
        {
            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distancia;
        }
    }
}


//7) Crear una funcion que calcule la suma de los primeros n numeros naturales, recibiendo como parametro el numero n.
using System;

namespace SumaNumerosNaturales
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita al usuario que ingrese un número
            Console.Write("Ingrese un número: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Llama a la función SumarNumerosNaturales para calcular la suma de los primeros n números naturales
            int suma = SumarNumerosNaturales(n);

            // Imprime la suma de los primeros n números naturales
            Console.WriteLine("La suma de los primeros " + n + " números naturales es: " + suma);
        }

        // Función que calcula la suma de los primeros n números naturales
        static int SumarNumerosNaturales(int n)
        {
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
                suma += i;
            }
            return suma;
        }
    }
}

// 8) Crear una funcion que calcule el factorial de un numero, recibiendo como parametro el numero.

using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {

            // Solicita al usuario que ingrese un número
            Console.Write("Ingrese un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Llama a la función CalcularFactorial para calcular el factorial del número ingresado
            int factorial = CalcularFactorial(numero);

            // Imprime el factorial del número ingresado
            Console.WriteLine("El factorial de " + numero + " es: " + factorial);
        }

        // Función que calcula el factorial de un número
        static int CalcularFactorial(int numero)
        {
            int factorial = 1;
            for (int i = 2; i <= numero; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}

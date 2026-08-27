/*
 * EJERCICIO:
 * - Crea ejemplos de funciones básicas que representen las diferentes
 *   posibilidades del lenguaje:
 *   Sin parámetros ni retorno, con uno o varios parámetros, con retorno...
 * - Comprueba si puedes crear funciones dentro de funciones.
 * - Utiliza algún ejemplo de funciones ya creadas en el lenguaje.
 * - Pon a prueba el concepto de variable LOCAL y GLOBAL.
 * - Debes hacer print por consola del resultado de todos los ejemplos.
 *   (y tener en cuenta que cada lenguaje puede poseer más o menos posibilidades)
 *
 * DIFICULTAD EXTRA (opcional):
 * Crea una función que reciba dos parámetros de tipo cadena de texto y retorne un número.
 * - La función imprime todos los números del 1 al 100. Teniendo en cuenta que:
 *   - Si el número es múltiplo de 3, muestra la cadena de texto del primer parámetro.
 *   - Si el número es múltiplo de 5, muestra la cadena de texto del segundo parámetro.
 *   - Si el número es múltiplo de 3 y de 5, muestra las dos cadenas de texto concatenadas.
 *   - La función retorna el número de veces que se ha impreso el número en lugar de los textos.
 *
 * Presta especial atención a la sintaxis que debes utilizar en cada uno de los casos.
 * Cada lenguaje sigue una convenciones que debes de respetar para que el código se entienda.
 */

 // Función sin parámetros ni retorno
static void Saludar()
{
    Console.WriteLine("¡Hola! Esta es una función sin parámetros ni retorno.");
}

// Se utiliza asi:
Saludar();

// Función con un parámetro y sin retorno
static void SaludarConNombre(string nombre)
{
    Console.WriteLine($"¡Hola, {nombre}! Esta es una función con un parámetro y sin retorno.");
}

// Se utiliza asi:
SaludarConNombre("Sergio");

// Función que devuelve un valor
static int Sumar(int a, int b)
{
    return a + b;
}   

// Se utiliza asi:
int resultado = Sumar(5, 10);
Console.WriteLine($"El resultado de la suma es: {resultado}");

// Función que devuelve un string
static string ObtenerNombre(){
    return "Sergio Conrado";
}

// Se utiliza asi:
string nombreCompleto = ObtenerNombre();
Console.WriteLine($"El nombre completo es: {nombreCompleto}");

//Función que devuelve un boolean
static bool EsMayorDeEdad(int edad)
{
    return edad >= 18;
}

// Se utiliza asi:
bool esMayor = EsMayorDeEdad(20);
Console.WriteLine($"¿Es mayor de edad? {esMayor}");

// Función con varios parametros
static double CalcularPromedio(double a, double b, double c)
{
    return (a + b + c) / 3;
}

// Se utiliza asi:
double promedio = CalcularPromedio(5.0, 10.0, 15.0);
Console.WriteLine($"El promedio es: {promedio}");   

// Función que utiliza if
static string ObtenerResultado(int calificacion)
{
    if (calificacion > 6)
    {
        return "Aprobado.";
    }
    else
    {
        return "Reprobado.";
    }
}

// Se utiliza asi:
string resultadoCalificacion = ObtenerResultado(7); 
Console.WriteLine($"El resultado de la calificación es: {resultadoCalificacion}");

// Función que utiliza un for
static void ImprimirNumeros(int limite)
{
    for (int i = 1; i <= limite; i++)
    {
        Console.WriteLine(i);
    }
}

// Se utiliza asi:
ImprimirNumeros(10);

// función que utiliza un while
static void ContarHasta(int limite)
{
    int contador = 1;
    while (contador <= limite)
    {
        Console.WriteLine(contador);
        contador++;
    }
}

// Se utiliza asi:
ContarHasta(5);

// Función que devuelve un array
static int[] GenerarArray() 
{
    return new int[] { 1, 2, 3, 4, 5 };
}

// Se utiliza asi:
int[] array = GenerarArray();
Console.WriteLine("El array generado es: " + string.Join(", ", array));

// Función con params
static int SumarNumeros(params int[] numeros)
{
    int suma = 0;
    foreach (int numero in numeros)
    {
        suma += numero;
    }
    return suma;
}

// Se utiliza asi:
int sumaTotal = SumarNumeros(1, 2, 3, 4, 5);
Console.WriteLine($"La suma total es: {sumaTotal}");

// EXTRA DIFICULTAD
static int ImprimirNumerosConTexto(string texto1, string texto2)
{
    int contadorNumeros = 0;
    for (int i = 1; i <= 100; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine(texto1 + texto2);
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine(texto1);
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine(texto2);
        }
        else
        {
            Console.WriteLine(i);
            contadorNumeros++;
        }
    }
    return contadorNumeros;
}
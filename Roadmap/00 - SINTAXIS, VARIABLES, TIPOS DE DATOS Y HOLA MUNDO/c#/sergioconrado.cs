//https://dotnet.microsoft.com/es-es/languages/csharp

// Comentario de una sola linea

/*
    Este es un comentario de varias lineas
*/

/// Comentarios XML: Son comentarios especiales utilizados principalmente 
/// para documentar clases, métodos, propiedades, parametros, etc
/// al utilizar alguna funcion el IDE puedo mostrar la documentacion


String nombre = "Sergio";
const double PI = 3.1416;

String texto = "Este es un texto";
int numero = 1;
double precio = 99.99;
float temperatura = 25.5f;
decimal salario = 15000.50m;
char inicial = "S";
bool estudiante = true;

// C# tambien permite declarar variables utilizando var
// El compilador determina automaticamente el tipo:

var nombre = "Sergio";  // String
var edad = 23;          // Int
var precio = 99.99;     // Double

// Tambien existe redondly, que es diferente de const
// Una variable readonly puede recibir su valor durante la inicialización o 
// dentro del constructor de una clase, pero después no puede modificarse.

// readonly solo puede utilizarse como miembro de una clase o struct.

Console.WriteLine("Hola C#");

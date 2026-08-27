/*
 * EJERCICIO:
 * - Crea ejemplos utilizando todos los tipos de operadores de tu lenguaje:
 *   Aritméticos, lógicos, de comparación, asignación, identidad, pertenencia, bits...
 *   (Ten en cuenta que cada lenguaje puede poseer unos diferentes)
 * - Utilizando las operaciones con operadores que tú quieras, crea ejemplos
 *   que representen todos los tipos de estructuras de control que existan
 *   en tu lenguaje:
 *   Condicionales, iterativas, excepciones...
 * - Debes hacer print por consola del resultado de todos los ejemplos.
 
 * DIFICULTAD EXTRA (opcional):
 * Crea un programa que imprima por consola todos los números comprendidos
 * entre 10 y 55 (incluidos), pares, y que no son ni el 16 ni múltiplos de 3.
*/

// Operadores aritmeticos

int a = 10;
int b = 3;

Console.WriteLine("Suma: " + (a + b));
Console.WriteLine("Resta: " + (a - b));
Console.WriteLine("Multiplicacion: " + (a * b));
Console.WriteLine("Division: " + (a / b));
Console.WriteLine("Modulo: " + (a % b));    

//operadores de comparacion

Console.WriteLine("Igual: " + (a == b));
Console.WriteLine("Distinto: " + (a != b));
Console.WriteLine("Mayor: " + (a > b));
Console.WriteLine("Menor: " + (a < b));
Console.WriteLine("Mayor o igual: " + (a >= b));
Console.WriteLine("Menor o igual: " + (a <= b));    

//operadores logicos
bool c = true;
bool d = false;

Console.WriteLine("AND: " + (c && d));
Console.WriteLine("OR: " + (c || d));
Console.WriteLine("NOT: " + (!c));

//operadores de asignacion
int e = 5;
e += 2; // e = e + 2
e -= 1; // e = e - 1
e *= 3; // e = e * 3
e /= 2; // e = e / 2
e %= 4; // e = e % 4
e++; // e = e + 1 
e--; // e = e - 1
Console.WriteLine("Asignacion: " + e);

//operadores de identidad
int f = 10;
int g = 10;
Console.WriteLine("Identidad: " + (f == g));

//operadores de pertenencia
int[] numeros = {1, 2, 3, 4, 5};
Console.WriteLine("Pertenencia: " + (Array.Exists(numeros, element => element == 3)));

//operadores de bits
int h = 5; // 0101 en binario
int i = 3; // 0011 en binario
Console.WriteLine("AND: " + (h & i)); // 0001 en binario
Console.WriteLine("OR: " + (h | i)); // 0111 en binario
Console.WriteLine("XOR: " + (h ^ i)); // 0110 en binario
Console.WriteLine("NOT: " + (~h)); // 1010 en binario
Console.WriteLine("Desplazamiento a la izquierda: " + (h << 1)); // 1010 en binario
Console.WriteLine("Desplazamiento a la derecha: " + (h >> 1)); // 0010 en binario

// Estructuras de control
// Condicionales

//if
int edad = 20;
if (edad >= 18)
{
    Console.WriteLine("Eres mayor de edad.");
}

//if else
if (edad < 18)
{
    Console.WriteLine("Eres menor de edad.");
}
else
{
    Console.WriteLine("Eres mayor de edad.");
}

//if else if
if (edad < 13)
{
    Console.WriteLine("Eres un niño.");
}
else if (edad < 18)
{
    Console.WriteLine("Eres un adolescente.");
}
else
{
    Console.WriteLine("Eres un adulto.");
}

//switch
int dia = 7;
switch (dia)
{
    case 1:
        Console.WriteLine("Lunes");
        break;
    case 2:
    Console.WriteLine("Martes");
        break;
    case 3:
        Console.WriteLine("Miércoles");
        break;
    case 4:
        Console.WriteLine("Jueves");
        break;
    case 5:
        Console.WriteLine("Viernes");
        break;
    case 6:
        Console.WriteLine("Sábado");
        break;
    case 7:
        Console.WriteLine("Domingo");
        break;
    default:
        Console.WriteLine("Día inválido");
        break;
}

// Iterativas
//for
for (int j = 0; j < 5; j++)
{
    Console.WriteLine("For: " + j);
}

//while
int k = 0;
while (k < 5)
{
    Console.WriteLine("While: " + k);
    k++;
}

//do while
int l = 0;
do
{
    Console.WriteLine("Do While: " + l);
    l++;
} while (l < 5);

//foreach
String[] nombres = {"Juan", "María", "Pedro"};
foreach (String nombre in nombres)
{
    Console.WriteLine("Foreach: " + nombre);
}

//Estructuras de salto
//break
for (int m = 0; m < 10; m++)
{
    if (m == 5)
    {
        break;
    }
    Console.WriteLine("Break: " + m);
}

//continue
for (int n = 0; n < 10; n++)
{
    if (n == 5)
    {
        continue;
    }
    Console.WriteLine("Continue: " + n);
}

// return
static int Sumar(int x, int y)
{
    return x + y;
}

//throw
try
{
    throw new Exception("Esto es una excepción");
}
catch (Exception ex)
{
    Console.WriteLine("Excepción: " + ex.Message);
}

//finally
try
{
    throw new Exception("Esto es una excepción");
}               
catch (Exception ex)
{
    Console.WriteLine("Excepción: " + ex.Message);
}
finally
{
    Console.WriteLine("Bloque finally");
}   

// DIFICULTAD EXTRA

for (int p = 10; p <= 55; p++)
{
    if (p % 2 == 0 && p!= 16 && p%3 != 0)
    {
        Console.WriteLine("Número válido: " + p);
    }
}
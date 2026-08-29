/*
 * EJERCICIO:
 * - Muestra ejemplos de creación de todas las estructuras soportadas por defecto en tu lenguaje.
 * - Utiliza operaciones de inserción, borrado, actualización y ordenación.
 *
 * DIFICULTAD EXTRA (opcional):
 * Crea una agenda de contactos por terminal.
 * - Debes implementar funcionalidades de búsqueda, inserción, actualización y eliminación de contactos.
 * - Cada contacto debe tener un nombre y un número de teléfono.
 * - El programa solicita en primer lugar cuál es la operación que se quiere realizar, y a continuación
 *   los datos necesarios para llevarla a cabo.
 * - El programa no puede dejar introducir números de teléfono no númericos y con más de 11 dígitos.
 *   (o el número de dígitos que quieras)
 * - También se debe proponer una operación de finalización del programa.
 */

 //arreglo

 int[] numeros = { 10, 20, 30, 40, 50 };
 Console.WriteLine(numeros[0]); // 10

  /*
 Ventajas:
Acceso rápido por índice (O(1)).
Bajo consumo de memoria.

Desventajas:
Tamaño fijo.
Insertar o eliminar elementos es costoso.
  */

//lista

 List<string> frutas = new List<string>();
 frutas.Add("Manzana");
 frutas.Add("Banana");
 frutas.Add("Naranja");
 Console.WriteLine(frutas[1]); // Banana

// Metodos Principales de List<T>:

frutas.Add("Uva"); // Agrega "Uva" al final de la lista
frutas.Remove("Banana"); // Elimina "Banana"
frutas.RemoveAt(0); // Elimina el elemento en la posición 0
frutas.Insert(1, "Fresa"); // Inserta "Fresa" en la posición 1
frutas.Sort(); // Ordena la lista alfabéticamente       

// Stack

 Stack<int> pila = new Stack<int>();
 pila.Push(1);
 pila.Push(2);
 pila.Push(3);
 Console.WriteLine(pila.Pop()); // 3
 Console.WriteLine(pila.Peek()); // 2  Muestra el elemento en la cima sin eliminarlo

 // Queue       

    Queue<string> cola = new Queue<string>();
    cola.Enqueue("Primero");
    cola.Enqueue("Segundo");
    Console.WriteLine(cola.Dequeue()); // "Primero"

// Dictionary<TKey, TValue>
// Almacena pares clave-valor y permite acceder a los valores mediante sus claves. Es útil para búsquedas rápidas y asociaciones de datos.

    Dictionary<string, int> edades = new Dictionary<string, int>();
    edades.Add("Juan", 25);
    edades.Add("María", 30);
    Console.WriteLine(edades["Juan"]); // 25

//recorrer

    foreach (var edad in edades)
    {
        Console.WriteLine($"Nombre: {edad.Key}, Edad: {edad.Value}");
    }

/* HashSet<T>
Almacena elementos únicos y no permite duplicados. Es útil para verificar 
rápidamente si un elemento está presente en la colección.
*/

    HashSet<string> conjunto = new HashSet<string>();
    conjunto.Add("A");
    conjunto.Add("B");
    conjunto.Add("C");
    Console.WriteLine(conjunto.Contains("B")); // True  


/* LinkedList<T>
Permite insertar y eliminar elementos en cualquier posición de la lista de 
manera eficiente. Es útil cuando se requiere un acceso rápido a los elementos 
y se realizan muchas inserciones y eliminaciones.
*/

    LinkedList<int> listaEnlazada = new LinkedList<int>();
    listaEnlazada.AddLast(1);
    listaEnlazada.AddLast(2);
    listaEnlazada.AddLast(3);
    Console.WriteLine(listaEnlazada.First.Value); // 1

    foreach (var item in listaEnlazada)
    {
        Console.WriteLine(item);
    }



Console.WriteLine("Terminal de contactos.");
Console.WriteLine("Seleccione una opción:");
Console.WriteLine("1. Agregar contacto");
Console.WriteLine("2. Buscar contacto");
Console.WriteLine("3. Actualizar contacto");
Console.WriteLine("4. Eliminar contacto");
Console.WriteLine("5. Salir");
int opcion = Convert.ToInt32(Console.ReadLine());

Dictionary<string, string> agenda = new Dictionary<string, string>();

switch (opcion)
{
    case 1:
        Console.WriteLine("Ingrese el nombre del contacto:");
        string nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el número de teléfono:");
        string telefono = Console.ReadLine();
        if (telefono.Length <= 11 && telefono.All(char.IsDigit))
        {
            agenda[nombre] = telefono;
            Console.WriteLine("Contacto agregado.");
        }
        else
        {
            Console.WriteLine("Número de teléfono inválido.");
        }
        break;
    case 2:
        Console.WriteLine("Ingrese el nombre del contacto a buscar:");
        nombre = Console.ReadLine();
        if (agenda.ContainsKey(nombre))
        {
            Console.WriteLine($"Número de teléfono: {agenda[nombre]}");
        }
        else
        {
            Console.WriteLine("Contacto no encontrado.");
        }
        break;
    case 3:
        Console.WriteLine("Ingrese el nombre del contacto a actualizar:");
        nombre = Console.ReadLine();
        if (agenda.ContainsKey(nombre))
        {
            Console.WriteLine("Ingrese el nuevo número de teléfono:");
            telefono = Console.ReadLine();
            if (telefono.Length <= 11 && telefono.All(char.IsDigit))
            {
                agenda[nombre] = telefono;
                Console.WriteLine("Contacto actualizado.");
            }
            else
            {
                Console.WriteLine("Número de teléfono inválido.");
            }
        }
        else
        {
            Console.WriteLine("Contacto no encontrado.");
        }
        break;
    case 4:
        Console.WriteLine("Ingrese el nombre del contacto a eliminar:");
        nombre = Console.ReadLine();
        if (agenda.ContainsKey(nombre))
        {
            agenda.Remove(nombre);
            Console.WriteLine("Contacto eliminado.");
        }
        else
        {   
            Console.WriteLine("Contacto no encontrado.");
        }
        break;
    case 5:
        Console.WriteLine("Saliendo del programa.");
        break;
    default:
        Console.WriteLine("Opción inválida.");
        break;
}
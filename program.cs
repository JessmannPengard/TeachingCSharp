using System;

namespace CS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicializamos la variable opcion
            string opcion = "";
            // Pedimos al usuario que introduzca un número
            Console.WriteLine("Introduce un número:");
            // Lo guardamos en la variable num1
            string num1 = Console.ReadLine();
            // Pedimos al usuario que introduzca otro número
            Console.WriteLine("Introduce otro número:");
            // Lo guardamos en la variable num2
            string num2 = Console.ReadLine();
            // Ejecutamos un bucle que muestra el menú
            // hasta que el usuario introduzca la opción 3 (salir)
            do
            {
                // Mostramos el menú
                Console.WriteLine("Selecciona una opción:");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Mayor");
                Console.WriteLine("3. Salir");
                // Leemos la opción introducida por el usuario
                opcion = Console.ReadLine();
                // Dependiendo de la opción seleccionada hacemos los cálculos correspondientes
                switch (opcion)
                {
                    case "1": // Suma
                        // Sumamos los dos números y los guardamos en la variable suma
                        // Dado que Console.ReadLine nos devuelve un 'string' (cadena de texto)
                        // usamos 'int.Parse()' para convertirlo a 'int' (número entero)
                        int suma = int.Parse(num1) + int.Parse(num2);
                        // Mostramos el resultado
                        Console.WriteLine("La suma de los dos números es: " + suma);
                        Console.WriteLine("-----------------------------");
                        break;
                    case "2": // Número mayor
                        // Inicializamos una variable donde guardaremos el número mayor
                        var mayor = "";
                        // Si el primer número es mayor lo almacenamos en la variable mayor
                        if (int.Parse(num1) > int.Parse(num2)){
                            mayor = num1;
                        } else
                        // Si no guardamos en la variable el segundo número
                        {
                            mayor = num2;
                        }
                        // Mostramos el resultado
                        Console.WriteLine("El número mayor es: " + mayor);
                        Console.WriteLine("-----------------------------");
                        break;
                    case "3": // Salir
                        Console.WriteLine("Hasta la próxima!");
                        Console.WriteLine("-----------------");
                        break;
                    default: // Opción no válida
                        Console.WriteLine("Introduce una opción válida (1-3)");
                        Console.WriteLine("---------------------------------");
                        break;
                }
            } while (opcion != "3");
        }
    }
}

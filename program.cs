using System;

namespace CS
{
    class Program
    {
        static void Main(string[] args)
        {
            var opcion="";
            Console.WriteLine("Introduce un número:");
            var num1 = Console.ReadLine();
            Console.WriteLine("Introduce otro número:");
            var num2 = Console.ReadLine();
            do
            {
                Console.WriteLine("Selecciona una opción:");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Mayor");
                Console.WriteLine("3. Salir");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        int suma=int.Parse(num1)+int.Parse(num2);
                        Console.WriteLine("La suma de los dos números es: " + suma);
                        Console.WriteLine("-----------------------------");
                        break;
                    case "2":
                        var mayor="";
                        if (int.Parse(num1)>int.Parse(num2)){
                            mayor=num1;
                        }else
                        {
                            mayor=num2;
                        }
                        Console.WriteLine("El número mayor es: " + mayor);
                        Console.WriteLine("-----------------------------");
                        break;
                    case "3":
                        // Salir
                        break;
                    default:
                        Console.WriteLine("Introduce una opción válida (1-3)");
                        Console.WriteLine("---------------------------------");
                        break;
                }
            } while (opcion!="3");
        }
    }
}

using System;

class Program {
    static void Main() {
        // 1. Declarar variables (aquí hay que decir qué TIPO son: "string")
        string contrasenaSecreta = "Gatito123";
        string intentoUsuario = "";

        Console.WriteLine("--- SISTEMA DE SEGURIDAD ---");

        // 2. El Bucle WHILE (¡La lógica es idéntica!)
        while (intentoUsuario != contrasenaSecreta) {
            
            Console.Write("Ingrese la contraseña: ");
            
            // Así se pide el dato al usuario en C#
            intentoUsuario = Console.ReadLine();

            if (intentoUsuario != contrasenaSecreta) {
                Console.WriteLine("Acceso denegado. Intente de nuevo.");
            }
        }

        Console.WriteLine("¡Acceso Concedido! Bienvenido al sistema.");
    }
}

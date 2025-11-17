using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria mi_cuenta = new CuentaBancaria("22151468", "Natalie", 2000);

            Console.WriteLine("=== CUENTA BANCARIA ===");
            Console.WriteLine("Saldo inicial: $" + mi_cuenta.GetSaldo());

            // Intentar depósito que exceda los $50,000
            Console.WriteLine("\nIntentando depositar $48,000...");
            if (mi_cuenta.DepositarSaldo(48000))
                Console.WriteLine("Depósito exitoso. Saldo: $" + mi_cuenta.GetSaldo());
            else
                Console.WriteLine("Error: No se puede exceder los $50,000.");

            // Intentar retirar más de $9,000
            Console.WriteLine("\nIntentando retirar $10,000...");
            if (mi_cuenta.RetirarSaldo(10000))
                Console.WriteLine("Retiro exitoso. Saldo: $" + mi_cuenta.GetSaldo());
            else
                Console.WriteLine("Error: No se puede retirar más de $9,000 por operación.");

            // Intentar retirar más de lo que hay en la cuenta
            Console.WriteLine("\nIntentando retirar $50,000...");
            if (mi_cuenta.RetirarSaldo(50000))
                Console.WriteLine("Retiro exitoso. Saldo: $" + mi_cuenta.GetSaldo());
            else
                Console.WriteLine("Error: No se puede tener saldo negativo.");

            // Mostrar saldo final
            Console.WriteLine("\nSaldo final de la cuenta: $" + mi_cuenta.GetSaldo());

            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}

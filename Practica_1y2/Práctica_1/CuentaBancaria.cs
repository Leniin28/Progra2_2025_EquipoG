using System;

namespace ConsoleApp1
{
    internal class CuentaBancaria
    {
        private string numeroCuenta;
        private string titular;
        private double saldo;

        // Constructor
        public CuentaBancaria(string numeroCuenta, string titular, double saldoInicial)
        {
            this.numeroCuenta = numeroCuenta;
            this.titular = titular;
            this.saldo = saldoInicial <= 50000 ? saldoInicial : 50000; // No exceder el límite
        }

        // Método para depositar
        public bool DepositarSaldo(double cantidad)
        {
            if (cantidad <= 0) return false;

            if (saldo + cantidad > 50000) 
            {
                return false;
            }

            saldo += cantidad;
            return true;
        }

        // Método para retirar
        public bool RetirarSaldo(double cantidad)
        {
            if (cantidad <= 0) return false;

            if (cantidad > 9000) 
            {
                return false;
            }

            if (saldo - cantidad < 0) 
            {
                return false;
            }

            saldo -= cantidad;
            return true;
        }

        // Método para consultar saldo
        public double GetSaldo()
        {
            return saldo;
        }
    }
}

using System;

namespace ConsoleApp1
{
    internal class CuentaBancaria
    {
        private string numeroCuenta;
        private string titular;
        private double saldo;

        public CuentaBancaria(string numeroCuenta, string titular, double saldoInicial)
        {
            this.numeroCuenta = numeroCuenta;
            this.titular = titular;
            this.saldo = saldoInicial <= 50000 ? saldoInicial : 50000;
        }

        // Métodos para la nueva interfaz
        public string GetNumeroCuenta() { return numeroCuenta; }
        public string GetTitular() { return titular; }
        public double GetSaldo() { return saldo; }

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
    }
}
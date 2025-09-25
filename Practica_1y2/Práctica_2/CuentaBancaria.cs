using System;

namespace BancoGUI
{
    public class CuentaBancaria
    {
        private string numeroCuenta;
        private string titular;
        private decimal saldo;

        public CuentaBancaria(string numeroCuenta, string titular, decimal saldoInicial)
        {
            this.numeroCuenta = numeroCuenta;
            this.titular = titular;
            this.saldo = saldoInicial;
        }

        public decimal GetSaldo()
        {
            return saldo;
        }

        public bool DepositarSaldo(decimal monto)
        {
            if (monto <= 0 || (saldo + monto) > 50000)
                return false;

            saldo += monto;
            return true;
        }

        public bool RetirarSaldo(decimal monto)
        {
            if (monto <= 0 || monto > 9000 || monto > saldo)
                return false;

            saldo -= monto;
            return true;
        }
    }
}

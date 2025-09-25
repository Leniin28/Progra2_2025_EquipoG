using ConsoleApp1;
using System;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class Form1 : Form
    {
        private CuentaBancaria mi_cuenta;

        public Form1()
        {
            InitializeComponent();
            InicializarCajero();
        }

        private void InicializarCajero()
        {
            mi_cuenta = new CuentaBancaria("22151468", "Natalie", 2000);
            ActualizarInterfaz();
        }

        private void ActualizarInterfaz()
        {
            lblNumeroCuenta.Text = $"Número de Cuenta: {mi_cuenta.GetNumeroCuenta()}";
            lblTitular.Text = $"Titular: {mi_cuenta.GetTitular()}";
            lblSaldoActual.Text = $"Saldo Actual: ${mi_cuenta.GetSaldo()}";
            lblMensaje.Text = "Esperando una operación...";
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtMonto.Text, out double monto))
            {
                if (mi_cuenta.DepositarSaldo(monto))
                {
                    lblMensaje.Text = "✅ Depósito exitoso.";
                    ActualizarInterfaz();
                }
                else
                {
                    lblMensaje.Text = "❌ Error: No se puede exceder los $50,000 o la cantidad es inválida.";
                }
            }
            else
            {
                lblMensaje.Text = "❌ Error: Por favor, ingrese un monto válido.";
            }
            txtMonto.Clear();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtMonto.Text, out double monto))
            {
                if (mi_cuenta.RetirarSaldo(monto))
                {
                    lblMensaje.Text = "✅ Retiro exitoso.";
                    ActualizarInterfaz();
                }
                else
                {
                    lblMensaje.Text = "❌ Error: No se puede retirar más de $9,000 o no hay suficiente saldo.";
                }
            }
            else
            {
                lblMensaje.Text = "❌ Error: Por favor, ingrese un monto válido.";
            }
            txtMonto.Clear();
        }
    }
}
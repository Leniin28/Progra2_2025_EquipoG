using System;
using System.Windows.Forms;

namespace BancoGUI
{
    public partial class Form1 : Form
    {
        private CuentaBancaria miCuenta;

        public Form1()
        {
            InitializeComponent();
            miCuenta = new CuentaBancaria("22151468", "Natalie", 2000);
            lblSaldo.Text = "Saldo: $" + miCuenta.GetSaldo();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                if (miCuenta.DepositarSaldo(monto))
                    lblSaldo.Text = "Saldo: $" + miCuenta.GetSaldo();
                else
                    MessageBox.Show("Error: No se puede exceder los $50,000.");
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.");
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                if (miCuenta.RetirarSaldo(monto))
                    lblSaldo.Text = "Saldo: $" + miCuenta.GetSaldo();
                else
                    MessageBox.Show("Error: Retiro no permitido.");
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.");
            }
        }
    }
}

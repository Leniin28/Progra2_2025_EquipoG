using System;
using System.Globalization;
using System.Windows.Forms;

namespace WinFormsCalculator
{
    public partial class Form1 : Form
    {
        private double _accumulator = 0;
        private string _pendingOp = "";
        private bool _resetDisplay = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void AppendDigit(string text)
        {
            if (_resetDisplay || display.Text == "0")
            {
                display.Text = text;
                _resetDisplay = false;
            }
            else
            {
                display.Text += text;
            }
        }

        private void Digit_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                AppendDigit(btn.Text);
            }
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            if (_resetDisplay)
            {
                display.Text = "0";
                _resetDisplay = false;
            }
            if (!display.Text.Contains(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                display.Text += CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            _accumulator = 0;
            _pendingOp = "";
            _resetDisplay = false;
            display.Text = "0";
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;

            double current = ParseDisplay();

            if (string.IsNullOrEmpty(_pendingOp))
            {
                _accumulator = current;
            }
            else
            {
                _accumulator = Compute(_accumulator, current, _pendingOp);
                display.Text = _accumulator.ToString();
            }

            _pendingOp = btn.Text;
            _resetDisplay = true;
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            double current = ParseDisplay();
            if (!string.IsNullOrEmpty(_pendingOp))
            {
                _accumulator = Compute(_accumulator, current, _pendingOp);
                display.Text = _accumulator.ToString();
                _pendingOp = "";
                _resetDisplay = true;
            }
        }

        private double Compute(double a, double b, string op)
        {
            switch (op)
            {
                case "+": return a + b;
                case "-": return a - b;
                case "×": return a * b;
                case "÷":
                    if (b == 0)
                    {
                        MessageBox.Show("No se puede dividir entre cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return a;
                    }
                    return a / b;
                default: return b;
            }
        }

        private double ParseDisplay()
        {
            double.TryParse(display.Text, out var value);
            return value;
        }
    }
}
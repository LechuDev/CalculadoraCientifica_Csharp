using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculadoraCientifica
{
    public partial class CalculatorForm : Form
    {
        private bool darkMode = true;

        public CalculatorForm()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void btnToggleTheme_Click(object sender, EventArgs e)
        {
            darkMode = !darkMode;
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            if (darkMode)
            {
                this.BackColor = Color.FromArgb(20, 20, 20);
                this.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
            }
        }

        // Operaciones básicas
        private double Sumar(double a, double b) => a + b;
        private double Restar(double a, double b) => a - b;
        private double Multiplicar(double a, double b) => a * b;
        private double Dividir(double a, double b) => b != 0 ? a / b : double.NaN;

        // Funciones científicas
        private double Seno(double x) => Math.Sin(x);
        private double Coseno(double x) => Math.Cos(x);
        private double Tangente(double x) => Math.Tan(x);
        private double RaizCuadrada(double x) => Math.Sqrt(x);
        private double Potencia(double x, double y) => Math.Pow(x, y);
        private double Logaritmo(double x) => Math.Log(x);
        private double LogaritmoBase10(double x) => Math.Log10(x);
        private double Exponencial(double x) => Math.Exp(x);
        private double ValorAbsoluto(double x) => Math.Abs(x);

        // Método para registrar en historial
        private void RegistrarHistorial(string operacion, double resultado)
        {
            lstHistorial.Items.Insert(0, $"{DateTime.Now:HH:mm:ss} - {operacion} = {resultado}");
            if (lstHistorial.Items.Count > 10)
                lstHistorial.Items.RemoveAt(10);
        }
    }
}
using System;
using System.Windows.Forms;
using System.Drawing;

namespace CalculadoraCientifica
{
    partial class CalculatorForm
    {
        private Button btnToggleTheme;
        private TextBox txtInput1, txtInput2;
        private Label lblResultado;

        private Button btnSumar, btnRestar, btnMultiplicar, btnDividir;
        private Button btnSeno, btnCoseno, btnTangente;
        private Button btnRaiz, btnPotencia, btnLog, btnLog10, btnExp, btnAbs;
private ListBox lstHistorial;

private void InitializeComponent()
{
    this.ClientSize = new System.Drawing.Size(800, 600);
    this.Text = "Calculadora Científica";
    this.Font = new Font("Segoe UI", 12, FontStyle.Regular);

    // Entradas
    txtInput1 = new TextBox() { Location = new Point(10, 60), Width = 120 };
    txtInput2 = new TextBox() { Location = new Point(150, 60), Width = 120 };
    this.Controls.Add(txtInput1);
    this.Controls.Add(txtInput2);

    // Resultado
    lblResultado = new Label()
    {
        Location = new Point(10, 100),
        Size = new Size(500, 30),
        Text = "Resultado: ",
        ForeColor = Color.LightGreen
    };
    this.Controls.Add(lblResultado);

    // Historial
    lstHistorial = new ListBox()
    {
        Location = new Point(600, 60),
        Size = new Size(180, 400),
        BackColor = Color.FromArgb(30, 30, 30),
        ForeColor = Color.White
    };
    this.Controls.Add(lstHistorial);

    // Botones básicos con símbolos
    AddStyledButton(out btnSumar, "+", 10, 150, (s, e) => { double r = Sumar(Parse(txtInput1), Parse(txtInput2)); lblResultado.Text = $"Resultado: {r}"; RegistrarHistorial("+", r); });
    AddStyledButton(out btnRestar, "−", 120, 150, (s, e) => { double r = Restar(Parse(txtInput1), Parse(txtInput2)); lblResultado.Text = $"Resultado: {r}"; RegistrarHistorial("−", r); });
    AddStyledButton(out btnMultiplicar, "×", 230, 150, (s, e) => { double r = Multiplicar(Parse(txtInput1), Parse(txtInput2)); lblResultado.Text = $"Resultado: {r}"; RegistrarHistorial("×", r); });
    AddStyledButton(out btnDividir, "÷", 340, 150, (s, e) => { double r = Dividir(Parse(txtInput1), Parse(txtInput2)); lblResultado.Text = $"Resultado: {r}"; RegistrarHistorial("÷", r); });

    // Botones científicos
    AddStyledButton(out btnSeno, "sin", 10, 200, (s, e) => { double r = Seno(Parse(txtInput1)); lblResultado.Text = $"Resultado: {r}"; RegistrarHistorial("sin", r); });
    AddStyledButton(out btnCoseno, "cos", 120, 200, (s, e) => { double r = Coseno(Parse(txtInput1)); lblResultado.Text = $"Resultado: {r}"; RegistrarHistorial("cos", r); });
    AddStyledButton(out btnTangente, "tan", 230, 200, (s, e) => { double r = Tangente(Parse(txtInput1)); lblResultado.Text = $"Resultado: {r}"; RegistrarHistorial("tan", r); });
    AddStyledButton(out btnRaiz, "√", 340, 200, (s, e) => { double r = RaizCuadrada(Parse(txtInput1)); lblResultado.Text = $"Resultado: {r}"; RegistrarHistorial("√", r); });
    AddStyledButton(out btnPotencia, "xʸ", 10, 250, (s, e) => { double r = Potencia(Parse(txtInput1), Parse(txtInput2)); lblResultado.Text = $"Resultado: {r}"; RegistrarHistorial("xʸ", r); });
    AddStyledButton(out btnLog, "ln", 120, 250, (s, e) => { double r = Logaritmo(Parse(txtInput1)); lblResultado.Text = $"Resultado: {r}"; RegistrarHistorial("ln", r); });
    AddStyledButton(out btnLog10, "log₁₀", 230, 250, (s, e) => { double r = LogaritmoBase10(Parse(txtInput1)); lblResultado.Text = $"Resultado: {r}"; RegistrarHistorial("log₁₀", r); });
    AddStyledButton(out btnExp, "exp", 340, 250, (s, e) => { double r = Exponencial(Parse(txtInput1)); lblResultado.Text = $"Resultado: {r}"; RegistrarHistorial("exp", r); });
    AddStyledButton(out btnAbs, "|x|", 10, 300, (s, e) => { double r = ValorAbsoluto(Parse(txtInput1)); lblResultado.Text = $"Resultado: {r}"; RegistrarHistorial("|x|", r); });
}

private void AddStyledButton(out Button btn, string text, int x, int y, EventHandler handler)
{
    btn = new Button()
    {
        Text = text,
        Location = new Point(x, y),
        Size = new Size(100, 40),
        FlatStyle = FlatStyle.Flat,
        BackColor = Color.FromArgb(40, 40, 40),
        ForeColor = Color.White
    };
    btn.FlatAppearance.BorderSize = 0;
    btn.Click += handler;
    this.Controls.Add(btn);
}

private double Parse(TextBox txt)
{
    return double.TryParse(txt.Text, out double val) ? val : 0;
}
    }
}
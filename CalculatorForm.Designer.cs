namespace CalculadoraCientifica
{
    partial class CalculatorForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnToggleTheme;
        private Button btnSumar, btnRestar, btnMultiplicar, btnDividir;
        private Button btnSeno, btnCoseno, btnTangente;
        private Button btnRaiz, btnPotencia, btnLog, btnLog10, btnExp, btnAbs;
        private TextBox txtInput1, txtInput2;
        private Label lblResultado;

        private void InitializeComponent()
        {
            this.btnToggleTheme = new Button();
            this.btnSumar = new Button();
            this.btnRestar = new Button();
            this.btnMultiplicar = new Button();
            this.btnDividir = new Button();
            this.btnSeno = new Button();
            this.btnCoseno = new Button();
            this.btnTangente = new Button();
            this.btnRaiz = new Button();
            this.btnPotencia = new Button();
            this.btnLog = new Button();
            this.btnLog10 = new Button();
            this.btnExp = new Button();
            this.btnAbs = new Button();
            this.txtInput1 = new TextBox();
            this.txtInput2 = new TextBox();
            this.lblResultado = new Label();

            // Configuración general
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Text = "Calculadora Científica";

            // Botón de tema
            this.btnToggleTheme.Text = "Modo Claro/Oscuro";
            this.btnToggleTheme.Location = new System.Drawing.Point(10, 10);
            this.btnToggleTheme.Click += new EventHandler(this.btnToggleTheme_Click);
            this.Controls.Add(this.btnToggleTheme);

            // Entradas
            this.txtInput1.Location = new System.Drawing.Point(10, 50);
            this.txtInput2.Location = new System.Drawing.Point(150, 50);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.txtInput2);

            // Resultado
            this.lblResultado.Location = new System.Drawing.Point(10, 90);
            this.lblResultado.Size = new System.Drawing.Size(500, 30);
            this.Controls.Add(this.lblResultado);

            // Botones básicos
            AddButton(this.btnSumar, "Sumar", 10, 130, (s, e) => lblResultado.Text = $"Resultado: {Sumar(Parse(txtInput1), Parse(txtInput2)}");
            AddButton(this.btnRestar, "Restar", 120, 130, (s, e) => lblResultado.Text = $"Resultado: {Restar(Parse(txtInput1), Parse(txtInput2)}");
            AddButton(this.btnMultiplicar, "Multiplicar", 230, 130, (s, e) => lblResultado.Text = $"Resultado: {Multiplicar(Parse(txtInput1), Parse(txtInput2)}");
            AddButton(this.btnDividir, "Dividir", 340, 130, (s, e) => lblResultado.Text = $"Resultado: {Dividir(Parse(txtInput1), Parse(txtInput2)}");

            // Botones científicos
            AddButton(this.btnSeno, "Seno", 10, 180, (s, e) => lblResultado.Text = $"Resultado: {Seno(Parse(txtInput1))}");
            AddButton(this.btnCoseno, "Coseno", 120, 180, (s, e) => lblResultado.Text = $"Resultado: {Coseno(Parse(txtInput1))}");
            AddButton(this.btnTangente, "Tangente", 230, 180, (s, e) => lblResultado.Text = $"Resultado: {Tangente(Parse(txtInput1))}");
            AddButton(this.btnRaiz, "Raíz", 340, 180, (s, e) => lblResultado.Text = $"Resultado: {RaizCuadrada(Parse(txtInput1))}");
            AddButton(this.btnPotencia, "Potencia", 10, 230, (s, e) => lblResultado.Text = $"Resultado: {Potencia(Parse(txtInput1), Parse(txtInput2))}");
            AddButton(this.btnLog, "Log", 120, 230, (s, e) => lblResultado.Text = $"Resultado: {Logaritmo(Parse(txtInput1))}");
            AddButton(this.btnLog10, "Log10", 230, 230, (s, e) => lblResultado.Text = $"Resultado: {LogaritmoBase10(Parse(txtInput1))}");
            AddButton(this.btnExp, "Exp", 340, 230, (s, e) => lblResultado.Text = $"Resultado: {Exponencial(Parse(txtInput1))}");
            AddButton(this.btnAbs, "Abs", 10, 280, (s, e) => lblResultado.Text = $"Resultado: {ValorAbsoluto(Parse(txtInput1))}");
        }

        private void AddButton(Button btn, string text, int x, int y, EventHandler handler)
        {
            btn.Text = text;
            btn.Location = new System.Drawing.Point(x, y);
            btn.Click += handler;
            this.Controls.Add(btn);
        }

        private double Parse(TextBox txt)
        {
            return double.TryParse(txt.Text, out double val) ? val : 0;
        }
    }
}

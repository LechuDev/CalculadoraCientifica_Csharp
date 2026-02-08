# 🔢 Calculadora Científica – con C#

por Jorge A. Fuentes (Lechu)

Este proyecto forma parte de mi **portafolio 2026**.  
Es una calculadora científica desarrollada en **C#** con **WinForms**, que incluye alternancia entre **modo claro y modo oscuro**.

---

## 🚀 Tecnologías utilizadas
- Lenguaje: **C# (NET 6.0/7.0)**
- Paradigma: **Programación Orientada a Objetos (POO)**
- Arquitectura: **MVC simplificado** (separación entre lógica y UI)
- IDE: **Visual Studio Community 2022** *(gratuito)*
- Entorno: **Windows 11**

---

## ✨ Características
- Operaciones básicas: suma, resta, multiplicación, división.
- Funciones científicas: seno, coseno, tangente, raíz cuadrada, potencia.
- Alternancia entre **modo claro y modo oscuro**.
- Interfaz gráfica amigable con **WinForms**.
- Código modular y documentado.

---

## 📂 Estructura
- `src/` → Código fuente.
- `Program.cs` → Punto de entrada.
- `CalculatorForm.cs` → Lógica de la calculadora.
- `CalculatorForm.Designer.cs` → Diseño de la interfaz.

---

## ▶️ Ejecución
1. Clonar el repositorio:
   ```bash
   git clone https://github.com/lechudev/CalculadoraCientifica.git
   ```
2. Abrir en **Visual Studio Community 2022**.
3. Ejecutar con `F5`.

---

## 📜 Licencia
Este proyecto es de uso libre bajo la licencia MIT.

---

## 🖥️ Código base (WinForms con modo claro/oscuro)

**Program.cs**
```csharp
using System;
using System.Windows.Forms;

namespace CalculadoraCientifica
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculatorForm());
        }
    }
}
```

**CalculatorForm.cs con (fragmento clave para alternar tema)**
```csharp
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculadoraCientifica
{
    public partial class CalculatorForm : Form
    {
        private bool darkMode = false;

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
                this.BackColor = Color.FromArgb(30, 30, 30);
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

    }
}
```

**CalculatorForm.Designer.cs (ejemplo con botones)**
```csharp
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
        }
    }
}
```

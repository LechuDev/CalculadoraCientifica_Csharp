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
        private Button btnSumar;
        private Button btnRestar;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnSeno;
        private Button btnCoseno;
        private Button btnTangente;
        private Button btnRaiz;
        private Button btnPotencia;
        private Button btnLog;
        private Button btnLog10;
        private Button btnExp;
        private Button btnAbs;
        private TextBox txtInput1;
        private TextBox txtInput2;
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
            this.ClientSize = new System.Drawing.Size(500, 600);
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
            this.lblResultado.Size = new System.Drawing.Size(400, 30);
            this.Controls.Add(this.lblResultado);

            // Ejemplo: botón suma
            this.btnSumar.Text = "Sumar";
            this.btnSumar.Location = new System.Drawing.Point(10, 130);
            this.btnSumar.Click += (s, e) =>
            {
                double a = double.Parse(txtInput1.Text);
                double b = double.Parse(txtInput2.Text);
                lblResultado.Text = $"Resultado: {Sumar(a, b)}";
            };
            this.Controls.Add(this.btnSumar);

            // Aquí se agregan los demás botones igual que el de suma...
        }
    }
}
```

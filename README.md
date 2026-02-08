# 🔢 Calculadora Científica – Jorge A. Fuentes (Lechu)

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

**CalculatorForm.cs (fragmento clave para alternar tema)**
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

        // Aquí irían las funciones matemáticas (suma, resta, trigonometría, etc.)
    }
}
```


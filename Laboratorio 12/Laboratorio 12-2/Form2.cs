using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laboratorio_12_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void buttonCalcular_Click1(object sender, EventArgs e)
        {
            // Obtener las notas ingresadas y convertirlas a números
            double nota1 = double.Parse(labelPromedio.Text);
            double nota2 = double.Parse(textBox2.Text);
            double nota3 = double.Parse(textBox3.Text);

            // Calcular el promedio
            double promedio = (nota1 + nota2 + nota3) / 3;

            // Mostrar el resultado en el label
            labelPromedio.Text = "El promedio es: " + promedio.ToString();
        }

        private void buttonLimpiar_Click_Click(object sender, EventArgs e)
        {
        }
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los TextBox y el Label
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            labelPromedio.Text = "";
        }

        private void buttonSalir_Click_Click(object sender, EventArgs e)
        {
        }
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

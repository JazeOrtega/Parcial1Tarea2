using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromedioEstudiantes
{
    public partial class Tarea2 : Form
    {
        public Tarea2()
        {
            InitializeComponent();
        }

        private async void PromedioButton1_Click(object sender, EventArgs e)
        {
            decimal nota1 = Convert.ToDecimal(Parcial1TextBox1.Text);
            decimal nota2 = Convert.ToDecimal(Parcial2TextBox2.Text);
            decimal nota3 = Convert.ToDecimal(Parcial3TextBox3.Text);
            decimal nota4 = Convert.ToDecimal(Parcial4TextBox1.Text);
            decimal promediar = await promedioNotasAsync(nota1, nota2, nota3, nota4);

            MessageBox.Show("El promedio es: " + promediar);
            limpiar();
        }

        private async Task<decimal> promedioNotasAsync(decimal nota1, decimal nota2, decimal nota3, decimal nota4)
        {
            decimal promedio = await Task.Run(() =>
            {
                return (nota1 + nota2 + nota3 + nota4) / 4;
            });
            return promedio;
        }

        private void limpiar()
        {
            Parcial1TextBox1.Clear();
            Parcial2TextBox2.Clear();
            Parcial3TextBox3.Clear();
            Parcial4TextBox1.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_2
{
    public partial class Bibliotecario : Form
    {
        public Bibliotecario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void button2_Click(object sender, EventArgs e)
        {

            GestorUsuarios proceso = new GestorUsuarios();
            proceso.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Bibliotecario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Ingresar Libros
            GestorLibros proceso = new GestorLibros();
            proceso.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Gestionar Informes
            GestorInforme proceso = new GestorInforme();
            proceso.Show();
        }
    }
}

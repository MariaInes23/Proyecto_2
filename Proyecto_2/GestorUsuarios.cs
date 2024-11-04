using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_2
{
    public partial class GestorUsuarios : Form
    {

        public Biblioteca biblioteca;

        public GestorUsuarios(Biblioteca biblioteca)
        {
            this.biblioteca = biblioteca;
            InitializeComponent();
            var usuarios = biblioteca.ObtenerUsuarios();
            if (usuarios != null && usuarios.Count > 0)
            {
                dataGridView1.DataSource = usuarios;
            }
            else
            {
                MessageBox.Show("No hay usuarios para mostrar.");
            }

        }
        private void button2_Click_1(object sender, EventArgs e)
        {


        }
        public GestorUsuarios()
        {
            InitializeComponent();
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //AGREGAR

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

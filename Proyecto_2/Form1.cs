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

namespace Proyecto_2
{
    public partial class Form1 : Form
    {
        public Biblioteca biblioteca;

        public Form1(Biblioteca biblioteca)
        {
            this.biblioteca = biblioteca;
            InitializeComponent();
            biblioteca = new Biblioteca();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        public void button2_Click(object sender, EventArgs e)
        {
            // CREAR CUENTA

            string nombreUsuario = Nombre.Text; 
            string contraseña = Contraseña.Text;
            string rol = TipoCuenta.Text;

            biblioteca.Crear(nombreUsuario, contraseña, rol); 
            Nombre.Text = "";
            Contraseña.Text = "";
            TipoCuenta.Text = "";

        }

 

            private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
            //INGRESAR A CUENTA

            string nombreUsuario = Nombre.Text; 
            string contraseña = Contraseña.Text;
            string rol = TipoCuenta.Text;


            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contraseña) || string.IsNullOrWhiteSpace(rol))
            {
                MessageBox.Show("Llene todos los campos");
                return;
            }

            biblioteca.Ingresar(nombreUsuario, contraseña, rol); 
            Nombre.Text = "";
            Contraseña.Text = "";
            TipoCuenta.Text = "";

        }

        private void TipoCuenta_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}

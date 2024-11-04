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
    public partial class GestorLibros : Form
    {
        public GestorLibros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void AgregarLibro(Libro libro)
        {
            dataGridViewLibros.Rows.Add(libro.Titulo, libro.Autor, libro.ISBN, libro.Genero, libro.ObtenerDisponibilidadTexto());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            bool disponibilidad;
            if (txtDisponibilidad.Text.Trim().Equals("Disponible", StringComparison.OrdinalIgnoreCase))
            {
                disponibilidad = true;
            }
            else if (txtDisponibilidad.Text.Trim().Equals("No disponible", StringComparison.OrdinalIgnoreCase))
            {
                disponibilidad = false;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese 'Disponible' o 'No disponible' en el campo de disponibilidad.");
                return;
            }

            Libro nuevoLibro = new Libro(txtTitulo.Text, txtAutor.Text, txtISBN.Text, txtGenero.Text, disponibilidad);


            AgregarLibro(nuevoLibro);

            // Limpiar las cajas 
            txtTitulo.Clear();
            txtAutor.Clear();
            txtISBN.Clear();
            txtGenero.Clear();
            txtDisponibilidad.Clear();
        }
    }
}

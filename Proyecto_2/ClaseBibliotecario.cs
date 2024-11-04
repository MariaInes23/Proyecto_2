using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_2
{
    public class ClaseBibliotecario : Usuario
    {
        public ClaseBibliotecario(string nombreUsuario, string contraseña, string rol) : base(nombreUsuario, contraseña, rol) { }

        public override void MostrarBienvenida()
        {
            MessageBox.Show($"Bienvenido, {NombreUsuario}! Tienes acceso de Bibliotecario.");
        }
    }
}

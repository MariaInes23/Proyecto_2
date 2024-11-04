using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Proyecto_2
{
    public class Biblioteca
    {

        public List<Usuario> listaUsuarios { get; set; }

        public Usuario UsuarioAutenticado { get; set; }


        public Biblioteca()
        {
            listaUsuarios = new List<Usuario>();

        }

        public void Crear(string nombreUsuario, string contraseña, string rol)
        {
  
            if (listaUsuarios.Exists(u => u.NombreUsuario == nombreUsuario))
            {
                MessageBox.Show($"El usuario '{nombreUsuario}' ya existe.");
            }
            else if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contraseña) || string.IsNullOrWhiteSpace(rol))
            {
                MessageBox.Show("Llene todos los campos");
                return;
            }
            else
            {
                
                if (rol == "Lector")
                {
                    listaUsuarios.Add(new ClaseLector(nombreUsuario, contraseña, rol));
                    MessageBox.Show($"Usuario LECTOR: '{nombreUsuario}' creado exitosamente.");
                }
                else if (rol == "Bibliotecario")
                {
                    listaUsuarios.Add(new ClaseBibliotecario(nombreUsuario, contraseña, rol));
                    MessageBox.Show($"Usuario BIBLIOTECARIO: '{nombreUsuario}' creado exitosamente.");
                }
                else
                {
                    MessageBox.Show("Rol no válido. Use 'Lector' o 'Bibliotecario'.");
                }
            }
        }


        public void Ingresar(string nombreUsuario, string contraseña, string rol)
        {
            // Busca el usuario en la lista
            Usuario usuario = listaUsuarios.Find(u => u.NombreUsuario == nombreUsuario);

            // Verifica si el usuario existe
            if (usuario != null)
            {

                if (usuario.Rol == rol)
                {
                    if (usuario.Contraseña == contraseña)
                    {
                        if (usuario is ClaseLector && rol == "Lector")
                        {
                            Lector proceso = new Lector();
                            proceso.Show();
                            usuario.MostrarBienvenida();
                        }
                        else if (usuario is ClaseBibliotecario && rol == "Bibliotecario")
                        {
                            Bibliotecario proceso = new Bibliotecario();
                            proceso.Show();
                            usuario.MostrarBienvenida();
                        }
                        else
                        {
                            MessageBox.Show("Rol incorrecto para este usuario.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseña Incorrecta");
                    }
                }
                else
                {
                    MessageBox.Show($"No tiene acceso como {rol.ToUpper()}");
                }
            }
            else
            {
                MessageBox.Show("Usuario Inexistente");
            }
        }
        public List<Usuario> ObtenerUsuarios()
        {
            return listaUsuarios;
        }
    }
}
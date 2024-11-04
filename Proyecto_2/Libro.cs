﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public string Genero { get; set; }
        public bool Disponibilidad { get; set; }


        public Libro(string titulo, string autor, string isbn, string genero, bool disponibilidad)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            Genero = genero;
            Disponibilidad = disponibilidad;
        }

        
        public string ObtenerDisponibilidadTexto()
        {
            return Disponibilidad ? "Disponible" : "No disponible";
        }
    }
}

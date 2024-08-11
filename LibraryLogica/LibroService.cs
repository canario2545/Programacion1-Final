using LibraryDate;
using LibraryEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogica
{
    public class LibroService
    {
        private readonly LibroDAL libroDAL;
        public LibroService()
        {
            libroDAL = new LibroDAL();
        }

        public List<Libro> ObtenerLibros()
        {
            return libroDAL.ObtenerLibros();
        }

        public void AgregarLibro(Libro libro)
        {
            libroDAL.AgregarLibro(libro);
        }

        public void ActualizarLibro(Libro libro)
        {
            libroDAL.ActualizarLibro(libro);
        }

        public void EliminarLibro(int id)
        {
            libroDAL.EliminarLibro(id);
        }

        public List<Libro> BuscarLibros(string query)
        {
            return libroDAL.BuscarLibros(query);
        }
    }
}

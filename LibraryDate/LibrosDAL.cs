using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using LibraryEntidad;
using Microsoft.Data.SqlClient; 

namespace LibraryDate
{
    public class LibroDAL
    {
        private readonly DatabaseLibrary dbConnection;

        
        public LibroDAL()
        {
            dbConnection = new DatabaseLibrary();   
        }

        public List<Libro> BuscarLibros(string query)
        {
            var libros = new List<Libro>();
            using (var connection = dbConnection.GetConnection())
            {
                connection.Open();
                var sqlQuery = "SELECT * FROM Libros WHERE Titulo LIKE @Query OR Autor LIKE @Query OR ISBN LIKE @Query";
                using (var command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@Query", "%" + query + "%");
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var libro = new Libro
                            {
                                Id = (int)reader["Id"],
                                Titulo = reader["Titulo"].ToString(),
                                Autor = reader["Autor"].ToString(),
                                ISBN = reader["ISBN"].ToString(),
                                Prestado = (bool)reader["Prestado"]
                            };
                            libros.Add(libro);
                        }
                    }
                }
            }
            return libros;
        }


        public List<Libro> ObtenerLibros()
        {
            var libros = new List<Libro>();
            using (var connection = dbConnection.GetConnection())
            {
                connection.Open();
                var query = "SELECT * FROM Libros";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var libro = new Libro
                            {
                                Id = (int)reader["Id"],
                                Titulo = reader["Titulo"].ToString(),
                                Autor = reader["Autor"].ToString(),
                                ISBN = reader["ISBN"].ToString(),
                                Prestado = (bool)reader["Prestado"]
                            };
                            libros.Add(libro);
                        }
                    }
                }
            }
            return libros;
        }

        public void AgregarLibro(Libro libro)
        {
            using (var connection = dbConnection.GetConnection())
            {
                connection.Open();
                var query = "INSERT INTO Libros (Titulo, Autor, ISBN, Prestado) VALUES (@Titulo, @Autor, @ISBN, @Prestado)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Titulo", libro.Titulo);
                    command.Parameters.AddWithValue("@Autor", libro.Autor);
                    command.Parameters.AddWithValue("@ISBN", libro.ISBN);
                    command.Parameters.AddWithValue("@Prestado", libro.Prestado);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void EliminarLibro(int id)
        {
            using (var connection = dbConnection.GetConnection())
            {
                connection.Open();
                var query = "DELETE FROM Libros WHERE Id = @Id";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarLibro(Libro libro)
        {
            using (var connection = dbConnection.GetConnection())
            {
                connection.Open();
                var query = "UPDATE Libros SET Titulo = @Titulo, Autor = @Autor, ISBN = @ISBN, Prestado = @Prestado WHERE Id = @Id";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", libro.Id);
                    command.Parameters.AddWithValue("@Titulo", libro.Titulo);
                    command.Parameters.AddWithValue("@Autor", libro.Autor);
                    command.Parameters.AddWithValue("@ISBN", libro.ISBN);
                    command.Parameters.AddWithValue("@Prestado", libro.Prestado);
                    command.ExecuteNonQuery();
                }



            }
        }     
    } 
}

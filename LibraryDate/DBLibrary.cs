using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;
namespace LibraryDate
{
    public class DatabaseLibrary
    {
        string connectionString = "Server=DESKTOP-MHMKLO6\\SQLEXPREX;Database=LibraryDB;Integrated Security=True;TrustServerCertificate=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}

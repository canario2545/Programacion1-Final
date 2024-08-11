using LibraryLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormLibrery : Form
    {
        private LibroService libroService;

        public FormLibrery()
        {
            InitializeComponent();
            libroService = new LibroService();
            CargarLibros();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarLibros()
        {
            var libros = libroService.ObtenerLibros();
            dataGridView1.DataSource = libros;
        }

        private void FormLibrery_Load(object sender, EventArgs e)
        {

        }
    }
}

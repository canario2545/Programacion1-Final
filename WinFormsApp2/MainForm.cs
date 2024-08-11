using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibraryEntidad;
using LibraryDate;

namespace WinFormsApp2
{
    public partial class MainForm : Form
    {
        private readonly LibroDAL libroDAL;

        public MainForm()
        {
            InitializeComponent();
            libroDAL = new LibroDAL(); 
            CargarLibros(); 
        }

        private void CargarLibros()
        {
            var libros = libroDAL.ObtenerLibros();
            dataGridView1.DataSource = libros;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chkPrestado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            var libro = new Libro
            {
                Titulo = txtTitulo.Text,
                Autor = txtAutor.Text,
                ISBN = txtISBN.Text,
                Prestado = chkPrestado.Checked
            };

            libroDAL.AgregarLibro(libro);
            MessageBox.Show("Libro agregado exitosamente.");
            CargarLibros(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var libroId = (int)selectedRow.Cells["Id"].Value;

                libroDAL.EliminarLibro(libroId);
                MessageBox.Show("Libro eliminado exitosamente.");
                CargarLibros(); 
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un libro para eliminar.");
            }
        }

        private void bActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var libroId = (int)selectedRow.Cells["Id"].Value;

                var libro = new Libro
                {
                    Id = libroId,
                    Titulo = txtTitulo.Text,
                    Autor = txtAutor.Text,
                    ISBN = txtISBN.Text,
                    Prestado = chkPrestado.Checked
                };

                libroDAL.ActualizarLibro(libro);
                MessageBox.Show("Libro actualizado exitosamente.");
                CargarLibros(); 
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un libro para actualizar.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtTitulo.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtAutor.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtISBN.Text = dataGridView1.SelectedCells[3].Value.ToString();

        }

        private void Codigo(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            var query = txtBuscar.Text;
            var libros = libroDAL.BuscarLibros(query);
            dataGridView1.DataSource = libros;
            
            dataGridView1.AutoResizeColumns();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

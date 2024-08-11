namespace WinFormsApp2
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtISBN = new TextBox();
            chkPrestado = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bAgregar = new Button();
            button2 = new Button();
            bActualizar = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            bBuscar = new Button();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.CornflowerBlue;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.MenuHighlight;
            dataGridView1.Location = new Point(85, 225);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(566, 214);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = SystemColors.Menu;
            txtTitulo.BorderStyle = BorderStyle.FixedSingle;
            txtTitulo.Cursor = Cursors.IBeam;
            txtTitulo.Location = new Point(85, 63);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(279, 25);
            txtTitulo.TabIndex = 1;
            txtTitulo.TextChanged += txtTitulo_TextChanged;
            // 
            // txtAutor
            // 
            txtAutor.BackColor = SystemColors.Menu;
            txtAutor.BorderStyle = BorderStyle.FixedSingle;
            txtAutor.Cursor = Cursors.IBeam;
            txtAutor.Location = new Point(85, 99);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(279, 25);
            txtAutor.TabIndex = 2;
            txtAutor.TextChanged += txtAutor_TextChanged;
            // 
            // txtISBN
            // 
            txtISBN.BackColor = SystemColors.Menu;
            txtISBN.BorderStyle = BorderStyle.FixedSingle;
            txtISBN.Cursor = Cursors.IBeam;
            txtISBN.Location = new Point(85, 140);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(279, 25);
            txtISBN.TabIndex = 3;
            txtISBN.TextChanged += txtISBN_TextChanged;
            // 
            // chkPrestado
            // 
            chkPrestado.AutoSize = true;
            chkPrestado.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            chkPrestado.Location = new Point(85, 171);
            chkPrestado.Name = "chkPrestado";
            chkPrestado.Size = new Size(88, 24);
            chkPrestado.TabIndex = 4;
            chkPrestado.Text = "Prestado";
            chkPrestado.UseVisualStyleBackColor = true;
            chkPrestado.CheckedChanged += chkPrestado_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 5;
            label1.Text = "Titulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 102);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "Autor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 143);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 7;
            label3.Text = "ISBN";
            // 
            // bAgregar
            // 
            bAgregar.BackColor = Color.Navy;
            bAgregar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bAgregar.ForeColor = SystemColors.ControlLightLight;
            bAgregar.Location = new Point(388, 26);
            bAgregar.Name = "bAgregar";
            bAgregar.Size = new Size(162, 36);
            bAgregar.TabIndex = 8;
            bAgregar.Text = "Agregar";
            bAgregar.UseVisualStyleBackColor = false;
            bAgregar.Click += bAgregar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkBlue;
            button2.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 0);
            button2.FlatAppearance.BorderSize = 100;
            button2.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(388, 66);
            button2.Name = "button2";
            button2.Size = new Size(162, 34);
            button2.TabIndex = 9;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // bActualizar
            // 
            bActualizar.BackColor = Color.Navy;
            bActualizar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bActualizar.ForeColor = SystemColors.ControlLightLight;
            bActualizar.Location = new Point(388, 106);
            bActualizar.Name = "bActualizar";
            bActualizar.Size = new Size(162, 36);
            bActualizar.TabIndex = 10;
            bActualizar.Text = "Modificar";
            bActualizar.UseVisualStyleBackColor = false;
            bActualizar.Click += bActualizar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 26);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 11;
            label4.Text = "Codigo";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(85, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(279, 25);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // bBuscar
            // 
            bBuscar.BackColor = Color.DarkBlue;
            bBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bBuscar.ForeColor = SystemColors.ControlLightLight;
            bBuscar.Location = new Point(520, 176);
            bBuscar.Name = "bBuscar";
            bBuscar.Size = new Size(162, 43);
            bBuscar.TabIndex = 13;
            bBuscar.Text = "Buscar";
            bBuscar.UseVisualStyleBackColor = false;
            bBuscar.Click += bBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(308, 196);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(206, 25);
            txtBuscar.TabIndex = 14;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(704, 451);
            Controls.Add(txtBuscar);
            Controls.Add(bBuscar);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(bActualizar);
            Controls.Add(button2);
            Controls.Add(bAgregar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkPrestado);
            Controls.Add(txtISBN);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "MainForm";
            Text = "BookManager";
            TransparencyKey = Color.CadetBlue;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dataGridView1;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtISBN;
        private CheckBox chkPrestado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button bAgregar;
        private Button button2;
        private Button bActualizar;
        private Label label4;
        private TextBox textBox1;
        private Button bBuscar;
        private TextBox txtBuscar;
    }
}

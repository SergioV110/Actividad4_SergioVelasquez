namespace GestionDeClientes.VISTAS.ClienteVista
{
    partial class ClienteListarVista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSeleccionar = new Button();
            buttonEliminar = new Button();
            buttonEditar = new Button();
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            buttonInsertar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonSeleccionar
            // 
            buttonSeleccionar.DialogResult = DialogResult.OK;
            buttonSeleccionar.Font = new Font("Impact", 12F);
            buttonSeleccionar.Location = new Point(638, 403);
            buttonSeleccionar.Name = "buttonSeleccionar";
            buttonSeleccionar.Size = new Size(128, 41);
            buttonSeleccionar.TabIndex = 11;
            buttonSeleccionar.Text = "SELECCIONAR";
            buttonSeleccionar.UseVisualStyleBackColor = true;
            buttonSeleccionar.Click += buttonSeleccionar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.DialogResult = DialogResult.OK;
            buttonEliminar.Font = new Font("Impact", 12F);
            buttonEliminar.Location = new Point(416, 403);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(107, 41);
            buttonEliminar.TabIndex = 10;
            buttonEliminar.Text = "ELIMINAR";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.DialogResult = DialogResult.OK;
            buttonEditar.Font = new Font("Impact", 12F);
            buttonEditar.Location = new Point(212, 403);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(107, 41);
            buttonEditar.TabIndex = 9;
            buttonEditar.Text = "EDITAR";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 46);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 42);
            label1.TabIndex = 0;
            label1.Text = "LISTA DE CLIENTES";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(800, 340);
            dataGridView1.TabIndex = 6;
            // 
            // buttonInsertar
            // 
            buttonInsertar.Font = new Font("Impact", 12F);
            buttonInsertar.Location = new Point(41, 403);
            buttonInsertar.Name = "buttonInsertar";
            buttonInsertar.Size = new Size(107, 41);
            buttonInsertar.TabIndex = 12;
            buttonInsertar.Text = "INSERTAR";
            buttonInsertar.UseVisualStyleBackColor = true;
            buttonInsertar.Click += buttonInsertar_Click;
            // 
            // ClienteListarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonInsertar);
            Controls.Add(buttonSeleccionar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonEditar);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "ClienteListarVista";
            Text = "ClienteListarVista";
            Load += ClienteListarVista_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSeleccionar;
        private Button buttonEliminar;
        private Button buttonEditar;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button buttonInsertar;
        private Label label1;
    }
}
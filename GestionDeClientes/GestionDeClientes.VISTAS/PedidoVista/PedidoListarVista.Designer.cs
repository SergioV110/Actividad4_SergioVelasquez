namespace GestionDeClientes.VISTAS.PedidoVista
{
    partial class PedidoListarVista
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
            buttonEliminar = new Button();
            buttonEditar = new Button();
            buttonInsertar = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonEliminar
            // 
            buttonEliminar.DialogResult = DialogResult.OK;
            buttonEliminar.Font = new Font("Impact", 16.2F);
            buttonEliminar.Location = new Point(583, 379);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(191, 45);
            buttonEliminar.TabIndex = 9;
            buttonEliminar.Text = "ELIMINAR";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.DialogResult = DialogResult.OK;
            buttonEditar.Font = new Font("Impact", 16.2F);
            buttonEditar.Location = new Point(305, 379);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(191, 45);
            buttonEditar.TabIndex = 8;
            buttonEditar.Text = "EDITAR";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonInsertar
            // 
            buttonInsertar.DialogResult = DialogResult.OK;
            buttonInsertar.Font = new Font("Impact", 16.2F);
            buttonInsertar.Location = new Point(19, 379);
            buttonInsertar.Name = "buttonInsertar";
            buttonInsertar.Size = new Size(191, 45);
            buttonInsertar.TabIndex = 7;
            buttonInsertar.Text = "INSERTAR";
            buttonInsertar.UseVisualStyleBackColor = true;
            buttonInsertar.Click += buttonInsertar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 306);
            dataGridView1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 50);
            label1.TabIndex = 0;
            label1.Text = "LISTA DE PEDIDOS";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // PedidoListarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonEditar);
            Controls.Add(buttonInsertar);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "PedidoListarVista";
            Text = "PedidoListarVista";
            Load += PedidoListarVista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonEliminar;
        private Button buttonEditar;
        private Button buttonInsertar;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
    }
}
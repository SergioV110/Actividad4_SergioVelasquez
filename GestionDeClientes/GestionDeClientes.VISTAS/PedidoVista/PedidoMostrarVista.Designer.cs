namespace GestionDeClientes.VISTAS.PedidoVista
{
    partial class PedidoMostrarVista
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            buttonSeleccionar = new Button();
            buttonMostrarLista = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            dataGridView2 = new DataGridView();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            buttonMostrarTotal = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 232);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(634, 172);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1399, 71);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 22.2F);
            label4.Location = new Point(772, 26);
            label4.Name = "label4";
            label4.Size = new Size(587, 45);
            label4.TabIndex = 1;
            label4.Text = "TOTAL DE PEDIDOS HECHOS POR CLIENTE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 22.2F);
            label3.Location = new Point(60, 26);
            label3.Name = "label3";
            label3.Size = new Size(538, 45);
            label3.TabIndex = 0;
            label3.Text = "LISTA PEDIDOS HECHOS POR CLIENTE";
            // 
            // buttonSeleccionar
            // 
            buttonSeleccionar.Location = new Point(498, 174);
            buttonSeleccionar.Name = "buttonSeleccionar";
            buttonSeleccionar.Size = new Size(94, 29);
            buttonSeleccionar.TabIndex = 2;
            buttonSeleccionar.Text = "Seleccionar";
            buttonSeleccionar.UseVisualStyleBackColor = true;
            buttonSeleccionar.Click += buttonSeleccionar_Click;
            // 
            // buttonMostrarLista
            // 
            buttonMostrarLista.Font = new Font("Impact", 13.8F);
            buttonMostrarLista.Location = new Point(250, 471);
            buttonMostrarLista.Name = "buttonMostrarLista";
            buttonMostrarLista.Size = new Size(165, 39);
            buttonMostrarLista.TabIndex = 3;
            buttonMostrarLista.Text = "Mostrar Lista";
            buttonMostrarLista.UseVisualStyleBackColor = true;
            buttonMostrarLista.Click += buttonMostrarLista_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 182);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 4;
            label1.Text = "Seleccione el Cliente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(230, 175);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 27);
            textBox1.TabIndex = 5;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(738, 232);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(634, 172);
            dataGridView2.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(942, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 27);
            textBox2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(772, 181);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 8;
            label2.Text = "Seleccione el Cliente";
            // 
            // button1
            // 
            button1.Location = new Point(1210, 173);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Seleccionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonMostrarTotal
            // 
            buttonMostrarTotal.Font = new Font("Impact", 13.8F);
            buttonMostrarTotal.Location = new Point(982, 471);
            buttonMostrarTotal.Name = "buttonMostrarTotal";
            buttonMostrarTotal.Size = new Size(188, 39);
            buttonMostrarTotal.TabIndex = 10;
            buttonMostrarTotal.Text = "Mostrar Total";
            buttonMostrarTotal.UseVisualStyleBackColor = true;
            buttonMostrarTotal.Click += buttonMostrarTotal_Click;
            // 
            // PedidoMostrarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1399, 585);
            Controls.Add(buttonMostrarTotal);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(buttonMostrarLista);
            Controls.Add(buttonSeleccionar);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "PedidoMostrarVista";
            Text = "PedidoMostrarVista";
            Load += PedidoMostrarVista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button buttonSeleccionar;
        private Button buttonMostrarLista;
        private Label label1;
        private TextBox textBox1;
        private DataGridView dataGridView2;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private Button buttonMostrarTotal;
        private Label label4;
        private Label label3;
    }
}
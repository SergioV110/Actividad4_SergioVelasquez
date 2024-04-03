namespace GestionDeClientes.VISTAS.PedidoVista
{
    partial class PedidoEditarVista
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
            buttonGuardar = new Button();
            buttonSeleccionar = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonGuardar
            // 
            buttonGuardar.DialogResult = DialogResult.OK;
            buttonGuardar.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGuardar.Location = new Point(671, 405);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(117, 39);
            buttonGuardar.TabIndex = 21;
            buttonGuardar.Text = "GUARDAR";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonSeleccionar
            // 
            buttonSeleccionar.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSeleccionar.Location = new Point(496, 125);
            buttonSeleccionar.Name = "buttonSeleccionar";
            buttonSeleccionar.Size = new Size(150, 32);
            buttonSeleccionar.TabIndex = 20;
            buttonSeleccionar.Text = "Seleccionar";
            buttonSeleccionar.UseVisualStyleBackColor = true;
            buttonSeleccionar.Click += buttonSeleccionar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(276, 193);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(370, 27);
            dateTimePicker1.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Impact", 12F);
            textBox3.Location = new Point(276, 316);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(370, 32);
            textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Impact", 12F);
            textBox2.Location = new Point(276, 252);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(370, 32);
            textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Impact", 12F);
            textBox1.Location = new Point(276, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 32);
            textBox1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 18F);
            label4.Location = new Point(114, 311);
            label4.Name = "label4";
            label4.Size = new Size(104, 37);
            label4.TabIndex = 15;
            label4.Text = "Estado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 18F);
            label3.Location = new Point(114, 247);
            label3.Name = "label3";
            label3.Size = new Size(84, 37);
            label3.TabIndex = 14;
            label3.Text = "Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 18F);
            label2.Location = new Point(114, 183);
            label2.Name = "label2";
            label2.Size = new Size(96, 37);
            label2.TabIndex = 13;
            label2.Text = "Fecha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 18F);
            label1.Location = new Point(114, 119);
            label1.Name = "label1";
            label1.Size = new Size(136, 37);
            label1.TabIndex = 12;
            label1.Text = "ID Cliente";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 11;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(800, 46);
            label5.TabIndex = 0;
            label5.Text = "EDITAR PEDIDO";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // PedidoEditarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonSeleccionar);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "PedidoEditarVista";
            Text = "PedidoEditarVista";
            Load += PedidoEditarVista_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGuardar;
        private Button buttonSeleccionar;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label5;
    }
}
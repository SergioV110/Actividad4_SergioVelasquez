namespace GestionDeClientes.VISTAS.ClienteVista
{
    partial class ClienteEditarVista
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
            panel1 = new Panel();
            label6 = new Label();
            buttonGuardar = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 46);
            panel1.TabIndex = 23;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(800, 46);
            label6.TabIndex = 0;
            label6.Text = "EDITAR CLIENTES";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.DimGray;
            buttonGuardar.DialogResult = DialogResult.OK;
            buttonGuardar.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGuardar.ForeColor = Color.White;
            buttonGuardar.Location = new Point(647, 401);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(141, 43);
            buttonGuardar.TabIndex = 22;
            buttonGuardar.Text = "GUARDAR";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(258, 345);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(323, 27);
            textBox5.TabIndex = 21;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(258, 288);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(323, 27);
            textBox4.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(258, 231);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(323, 27);
            textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(258, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(323, 27);
            textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(258, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(323, 27);
            textBox1.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 13.8F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(59, 345);
            label5.Name = "label5";
            label5.Size = new Size(103, 28);
            label5.TabIndex = 16;
            label5.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 13.8F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(59, 288);
            label4.Name = "label4";
            label4.Size = new Size(95, 28);
            label4.TabIndex = 15;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 13.8F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(59, 231);
            label3.Name = "label3";
            label3.Size = new Size(188, 28);
            label3.TabIndex = 14;
            label3.Text = "Correo Electronico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 13.8F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(59, 174);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.TabIndex = 13;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 13.8F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 117);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 12;
            label1.Text = "Nombre:";
            // 
            // ClienteEditarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(buttonGuardar);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClienteEditarVista";
            Text = "ClienteEditarVista";
            Load += ClienteEditarVista_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonGuardar;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
    }
}
namespace GestionDeClientes.VISTAS.ClienteVista
{
    partial class ClienteInsertarVista
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            buttonGuardar = new Button();
            panel1 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 13.8F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 111);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 13.8F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(59, 168);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 13.8F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(59, 225);
            label3.Name = "label3";
            label3.Size = new Size(188, 28);
            label3.TabIndex = 2;
            label3.Text = "Correo Electronico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 13.8F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(59, 282);
            label4.Name = "label4";
            label4.Size = new Size(95, 28);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 13.8F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(59, 339);
            label5.Name = "label5";
            label5.Size = new Size(103, 28);
            label5.TabIndex = 4;
            label5.Text = "Direccion";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(258, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(323, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(258, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(323, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(258, 225);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(323, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(258, 282);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(323, 27);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(258, 339);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(323, 27);
            textBox5.TabIndex = 9;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.DimGray;
            buttonGuardar.DialogResult = DialogResult.OK;
            buttonGuardar.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGuardar.ForeColor = Color.White;
            buttonGuardar.Location = new Point(647, 395);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(141, 43);
            buttonGuardar.TabIndex = 10;
            buttonGuardar.Text = "GUARDAR";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 46);
            panel1.TabIndex = 11;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(800, 48);
            label6.TabIndex = 0;
            label6.Text = "INSERTAR CLIENTES";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // ClienteInsertarVista
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
            Name = "ClienteInsertarVista";
            Text = "ClienteInsertarVista";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button buttonGuardar;
        private Panel panel1;
        private Label label6;
    }
}
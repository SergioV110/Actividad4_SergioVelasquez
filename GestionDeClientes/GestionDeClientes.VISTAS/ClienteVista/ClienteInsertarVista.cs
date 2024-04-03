using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDeClientes.BSS;
using GestionDeClientes.MODELOS;

namespace GestionDeClientes.VISTAS.ClienteVista
{
    public partial class ClienteInsertarVista : Form
    {
        public ClienteInsertarVista()
        {
            InitializeComponent();
        }
        ClienteBss bss= new ClienteBss();
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = textBox1.Text;
            cliente.Apellido = textBox2.Text;
            cliente.CorreoElectronico = textBox3.Text;
            cliente.Telefono = textBox4.Text;
            cliente.Direccion = textBox5.Text;

            bss.InsertarClienteBss(cliente);
            MessageBox.Show("El Cliente ha sido Insertado Correctamente");
        }
    }
}

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
    public partial class ClienteEditarVista : Form
    {
        int idcliente = 0;
        Cliente cliente = new Cliente();
        ClienteBss bss = new ClienteBss();
        public ClienteEditarVista(int idClienteSeleccionado)
        {
            idcliente = idClienteSeleccionado;
            InitializeComponent();
        }
        
        private void ClienteEditarVista_Load(object sender, EventArgs e)
        {
            cliente = bss.ObtenerClienteIdBss(idcliente);
            textBox1.Text = cliente.Nombre;
            textBox2.Text = cliente.Apellido;
            textBox3.Text = cliente.CorreoElectronico;
            textBox4.Text = cliente.Telefono;
            textBox5.Text = cliente.Direccion;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
             cliente.Nombre = textBox1.Text;
            cliente.Apellido = textBox2.Text;
            cliente.CorreoElectronico = textBox3.Text;
            cliente.Telefono = textBox4.Text;
            cliente.Direccion = textBox5.Text;

            bss.EditarClienteBss(cliente);
            MessageBox.Show("Los datos del cliente han sido actualizados correctamente");
        }
    }
}

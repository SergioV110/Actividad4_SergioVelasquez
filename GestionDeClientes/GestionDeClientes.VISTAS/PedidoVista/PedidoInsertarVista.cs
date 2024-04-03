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
using GestionDeClientes.VISTAS.ClienteVista;

namespace GestionDeClientes.VISTAS.PedidoVista
{
    public partial class PedidoInsertarVista : Form
    {
        public PedidoInsertarVista()
        {
            InitializeComponent();
        }
        
        PedidoBss bsspedido = new PedidoBss();
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.IdCliente = IdClienteSeleccionado;
            pedido.Fecha = dateTimePicker1.Value;
            pedido.Total = Convert.ToDecimal(textBox2.Text);
            pedido.Estado = textBox3.Text;

            bsspedido.InsertarPedidoBss(pedido);
            MessageBox.Show("El pedido ha sido insertado Correctamente");
        }
        public static int IdClienteSeleccionado = 0;
        ClienteBss bss = new ClienteBss();
        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            ClienteListarVista fr = new ClienteListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = bss.ObtenerClienteIdBss(IdClienteSeleccionado);
                textBox1.Text = cliente.Nombre + " " + cliente.Apellido;
            }
        }
    }
}

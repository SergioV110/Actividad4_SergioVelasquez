using GestionDeClientes.BSS;
using GestionDeClientes.MODELOS;
using GestionDeClientes.VISTAS.ClienteVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeClientes.VISTAS.PedidoVista
{
    public partial class PedidoEditarVista : Form
    {
        int idpedido = 0;
        Pedido pedido = new Pedido();
        PedidoBss bsspedido = new PedidoBss();
        public PedidoEditarVista(int idPedidoSeleccionado)
        {
            idpedido = idPedidoSeleccionado;
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            pedido.IdCliente = IdClienteSeleccionado;
            pedido.Fecha = dateTimePicker1.Value;
            pedido.Total = Convert.ToDecimal( textBox2.Text);
            pedido.Estado = textBox3.Text; 
            
            bsspedido.EditarPedidoBss(pedido);
            MessageBox.Show("Los datos del pedido han sido actualizados correctamente");

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

        private void PedidoEditarVista_Load(object sender, EventArgs e)
        {
            pedido = bsspedido.ObtenerPedidoIdBss(IdClienteSeleccionado);
            textBox1.Text = pedido.IdCliente.ToString();
            dateTimePicker1.Value = pedido.Fecha;
            textBox2.Text = pedido.Total.ToString();
            textBox3.Text = pedido.Estado;
        }
    }
}

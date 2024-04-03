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
    public partial class PedidoMostrarVista : Form
    {
        public PedidoMostrarVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        PedidoBss bsspedido = new PedidoBss();
        public static int IdclienteSeleccionado = 0;

        private void PedidoMostrarVista_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = bss.PedidoDatosBss();
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            ClienteListarVista fr = new ClienteListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = bss.ObtenerClienteIdBss(IdclienteSeleccionado);
                textBox1.Text = cliente.Nombre + " " + cliente.Apellido;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteListarVista fr = new ClienteListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = bss.ObtenerClienteIdBss(IdclienteSeleccionado);
                textBox2.Text = cliente.Nombre + " " + cliente.Apellido;
            }
        }

        private void buttonMostrarLista_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bsspedido.PedidosMostrarDatosBss(IdclienteSeleccionado);
            //dataGridView2.DataSource = bsspedido.PedidoDatosBss(IdclienteSeleccionado);
        }

        private void buttonMostrarTotal_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = bsspedido.PedidoDatosBss(IdclienteSeleccionado);
        }
    }
}

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
    public partial class ClienteListarVista : Form
    {
        public ClienteListarVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void ClienteListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClienteBss();
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            PedidoVista.PedidoInsertarVista.IdClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            PedidoVista.PedidoEditarVista.IdClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            PedidoVista.PedidoMostrarVista.IdclienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int idClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de eliminar a este cliente", "El cliente ha sido eliminado Correctamente",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarClenteBss(idClienteSeleccionado);
                dataGridView1.DataSource = bss.ListarClienteBss();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            int idClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ClienteEditarVista fr = new ClienteEditarVista(idClienteSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarClienteBss();
            }
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            ClienteInsertarVista fr = new ClienteInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK) 
            {
                dataGridView1.DataSource = bss.ListarClienteBss();
            }
        }
    }
}

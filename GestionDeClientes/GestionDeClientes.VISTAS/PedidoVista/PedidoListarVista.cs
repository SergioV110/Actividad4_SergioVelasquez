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
    public partial class PedidoListarVista : Form
    {
        public PedidoListarVista()
        {
            InitializeComponent();
        }
        PedidoBss bss = new PedidoBss();
        private void PedidoListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarPedidoBss();
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            PedidoInsertarVista fr = new PedidoInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarPedidoBss();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            int idPedidoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            PedidoEditarVista fr = new PedidoEditarVista(idPedidoSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarPedidoBss();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int idPedidoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de eliminar este pedido", "El Pedido ha sido eliminado correctamente", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarPedidoBss(idPedidoSeleccionado);
                dataGridView1.DataSource = bss.ListarPedidoBss();
            }
        }
    }
}

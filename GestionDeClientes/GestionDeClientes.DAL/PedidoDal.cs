using GestionDeClientes.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeClientes.DAL
{
    public class PedidoDal
    {
        Pedido pedido = new Pedido();
        public DataTable ListarPedidoDal()
        {
            string consulta = "select * from pedido ";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "table");
            return lista;
        }
        public void InsertarPedidoDal(Pedido pedido)
        {
            string consulta = "insert into pedido values(" + pedido.IdCliente + "," +
                                                         "'" + pedido.Fecha + "'," +
                                                         "'" + pedido.Total + "'," +
                                                         "'" + pedido.Estado +  "')";
            conexion.Ejecutar(consulta);
        }
        public Pedido ObtenerPedidoIdDal(int id)
        {
            string consulta = "select * from pedido where idpedido=" + id;
            DataTable table = conexion.EjecutarDataTabla(consulta, "table");
            if (table.Rows.Count > 0)
            {
                pedido.IdPedido = Convert.ToInt32(table.Rows[0]["idpedido"]);
                pedido.IdCliente = Convert.ToInt32(table.Rows[0]["idcliente"]);
                pedido.Fecha = Convert.ToDateTime(table.Rows[0]["fecha"].ToString());
                pedido.Total = Convert.ToDecimal( table.Rows[0]["total"].ToString());
                pedido.Estado = table.Rows[0]["estado"].ToString();
            }
            return pedido;
        }
        public void EditarPedidoDal(Pedido p)
        {
            string consulta = "update pedido set idcliente='" + p.IdCliente + "'," +
                                                        "fecha='" + p.Fecha + "'," +
                                                        "total='" + p.Total + "'," +
                                                        "estado='" + p.Estado + "'" +
                                                "where idpedido=" + p.IdPedido;
            conexion.Ejecutar(consulta);
        }

        public void EliminarPedidoDal(int idpedido)
        {
            string consulta = "delete from pedido where idpedido=" + idpedido;
            conexion.Ejecutar(consulta);
        }
        public DataTable PedidoDatosDal(int id)
        {
            string consulta = "SELECT P.IDCLIENTE, COUNT(P.IDPEDIDO) CANTIDAD_DE_PEDIDOS , SUM (P.TOTAL) MONTO_TOTAL " +
                "              FROM PEDIDO P " +
                "              WHERE P.IDCLIENTE =  " + id +
                "              GROUP BY P.IDCLIENTE ";
            return conexion.EjecutarDataTabla(consulta, "abe");
        }
        public DataTable PedidoMostrarDatosDal(int id)
        {
            string consulta = "SELECT PEDIDO.IDPEDIDO, PEDIDO.FECHA, PEDIDO.TOTAL, PEDIDO.ESTADO " +
                "              FROM CLIENTE" +
                "                       INNER JOIN PEDIDO ON CLIENTE.IDCLIENTE = PEDIDO.IDCLIENTE" +
                "              WHERE CLIENTE.IDCLIENTE = " + id;
            return conexion.EjecutarDataTabla(consulta, "abe");
        }
    }
}

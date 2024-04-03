using GestionDeClientes.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeClientes.DAL
{
    public class ClienteDal
    {
        Cliente cliente = new Cliente();
        public DataTable ListarClienteDal()
        {
            string consulta = "select * from cliente";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "table");
            return lista;
        }
        public void InsertarClienteDal(Cliente cliente)
        {
            string consulta = "insert into cliente values('" + cliente.Nombre + "'," +
                                                         "'" + cliente.Apellido + "'," +
                                                         "'" + cliente.CorreoElectronico + "'," +
                                                         "'" + cliente.Telefono + "'," +
                                                         "'" + cliente.Direccion + "')";
            conexion.Ejecutar(consulta);
        }
        public Cliente ObtenerClienteIdDal(int idcliente)
        {
            string consulta = "select * from cliente where idcliente=" + idcliente;
            DataTable table = conexion.EjecutarDataTabla(consulta, "table");
            if (table.Rows.Count > 0)
            {
                cliente.IdCliente = Convert.ToInt32(table.Rows[0]["idcliente"]);
                cliente.Nombre = table.Rows[0]["nombre"].ToString();
                cliente.Apellido = table.Rows[0]["apellido"].ToString();
                cliente.CorreoElectronico = table.Rows[0]["correoelectronico"].ToString();
                cliente.Telefono = table.Rows[0]["telefono"].ToString();
                cliente.Direccion = table.Rows[0]["direccion"].ToString();

            }
            return cliente;
        }
        public void EditarClienteDal(Cliente c)
        {
            string consulta = "update cliente set nombre='" + c.Nombre + "'," +
                                                        "apellido='" + c.Apellido + "'," +
                                                        "correoelectronico='" + c.CorreoElectronico + "'," +
                                                        "telefono='" + c.Telefono + "'," +
                                                        "direccion='" + c.Direccion + "'" +
                                                "where idcliente=" + c.IdCliente;
            conexion.Ejecutar(consulta);
        }
        public void EliminarClienteDal(int idcliente)
        {
            string consulta = "delete from cliente where idcliente=" + idcliente;
            conexion.Ejecutar(consulta);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeClientes.DAL;
using GestionDeClientes.MODELOS;
namespace GestionDeClientes.BSS
{
    public class ClienteBss
    {
        ClienteDal dal = new ClienteDal();
        public DataTable ListarClienteBss()
        {
            return dal.ListarClienteDal();
        }
        public void InsertarClienteBss(Cliente cliente)
        {
            dal.InsertarClienteDal(cliente);
        }
        public Cliente ObtenerClienteIdBss(int id)
        {
            return dal.ObtenerClienteIdDal(id);
        }
        public void EditarClienteBss(Cliente c)
        {
            dal.EditarClienteDal(c);
        }
        public void EliminarClenteBss(int id)
        {
            dal.EliminarClienteDal(id);
        }
    }
}

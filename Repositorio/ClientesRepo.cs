using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data;

namespace Repositorio
{
    public class ClientesRepo
    {
        public void GuardarClientes(Clientes cliente)
        {
            using (segurosEntities context = new segurosEntities())
            {
                context.Clientes.Add(cliente);
                context.SaveChanges();
            }
        }

        public List<Clientes> ListarClientes()
        {
            List<Clientes> clientesList = new List<Clientes>();

            using (var context = new segurosEntities())
            {

                var query = from c in context.Clientes
                            select c;
                foreach (var item in query)
                {
                    clientesList.Add(item);
                }

            }
            return clientesList;
        }

        public List<Clientes> LlenarComboCliente()
        {
            List<Clientes> clientesList = new List<Clientes>();

            using (var context = new segurosEntities())
            {

                var query = from c in context.Clientes
                            select c;
                foreach (var item in query)
                {
                    clientesList.Add(item);
                }

            }
            return clientesList;
        }
    }
}

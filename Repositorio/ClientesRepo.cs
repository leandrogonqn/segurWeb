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
    }
}

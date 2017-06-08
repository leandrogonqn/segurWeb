using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;
using System.Data;

namespace Negocio
{
    public class ClientesNego
    {

        ClientesRepo clientesRepo = new ClientesRepo();

        public void GuardarClientes(Clientes cliente)
        {
            clientesRepo.GuardarClientes(cliente);
        }

        public List<Clientes> LlenarComboCliente()
        {
            return clientesRepo.LlenarComboCliente();
        }
    }
}

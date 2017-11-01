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

        public DataSet LlenarComboCliente()
        {
            return clientesRepo.LlenarComboCliente();
        }

        public DataTable ListarClientes()
        {
            return clientesRepo.ListarClientes();
        }

        public Clientes BuscarCliente(int? clienteId)
        {
            return clientesRepo.BuscarCliente(clienteId);
        }

        public void BorrarCliente(int clienteId)
        {
            clientesRepo.BorrarCliente(clienteId);
        }

        public void ModificarCliente(Clientes clientes)
        {
            clientesRepo.ModificarCliente(clientes);
        }
    }
}

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
                            where c.clienteEstado == 1
                            select c;
                foreach (var item in query)
                {
                    clientesList.Add(item);
                }

            }
            return clientesList;
        }

        public Clientes BuscarCliente(int clienteId)
        {
            Clientes cliente;
            using (segurosEntities context = new segurosEntities())
            {

                cliente = (from v in context.Clientes
                            where v.clienteId == clienteId
                           select v).FirstOrDefault();

            }
            return cliente;
        }

        public void ModificarCliente(Clientes clientes)
        {
            using (segurosEntities context = new segurosEntities())
            {
                Clientes cli = (from v in context.Clientes
                                   where v.clienteId == clientes.clienteId
                                   select v).FirstOrDefault();
                cli.clienteNombre = clientes.clienteNombre;
                cli.clienteApellido = clientes.clienteApellido;
                cli.clienteDni = clientes.clienteDni;
                cli.clienteFechaNacimiento = clientes.clienteFechaNacimiento;
                cli.clienteDomicilio = clientes.clienteDomicilio;
                cli.clienteTelefono = clientes.clienteTelefono;
                cli.clienteMail = clientes.clienteMail;
                context.SaveChanges();
            }
        }

        public void BorrarCliente(int clienteId)
        {
            using (segurosEntities context = new segurosEntities())
            {
                Clientes cli = (from v in context.Clientes
                                   where v.clienteId == clienteId
                                select v).FirstOrDefault();
                cli.clienteEstado = 0;
                context.SaveChanges();
            }
        }

        public List<object> LlenarComboCliente()
        {
            List<object> clientesList = new List<object>();

            using (var context = new segurosEntities())
            {
                var name = from c in context.Clientes
                           let nombreCompleto = c.clienteApellido + " " + c.clienteNombre + " " + c.clienteDni

                           orderby c.clienteNombre
                           select new
                           {
                               c.clienteId,
                               nombreCompleto
                           };


                foreach (var item in name)
                {
                    clientesList.Add(item);
                }

            }
            return clientesList;
        }

    }
}

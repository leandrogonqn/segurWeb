using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Repositorio
{
    public class ClientesRepo
    {
        public static string conexion = ConfigurationManager.ConnectionStrings["seguros"].ConnectionString;
        SqlConnection con = new SqlConnection(conexion);
        public void GuardarClientes(Clientes cliente)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("InsertarCliente", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter vehiculoDominio = cmd.Parameters.Add("@clienteApellido", SqlDbType.VarChar);
            vehiculoDominio.Value = cliente.clienteApellido;
            SqlParameter clienteNombre = cmd.Parameters.Add("@clienteNombre", SqlDbType.VarChar);
            clienteNombre.Value = cliente.clienteNombre;
            SqlParameter clienteDni = cmd.Parameters.Add("@clienteDni", SqlDbType.VarChar);
            clienteDni.Value = cliente.clienteDni;
            SqlParameter clienteFechaNacimiento = cmd.Parameters.Add("@clienteFechaNacimiento", SqlDbType.VarChar);
            clienteFechaNacimiento.Value = cliente.clienteFechaNacimiento;
            SqlParameter clienteDomicilio = cmd.Parameters.Add("@clienteDomicilio", SqlDbType.VarChar);
            clienteDomicilio.Value = cliente.clienteDomicilio;
            SqlParameter clienteTelefono = cmd.Parameters.Add("@clienteTelefono", SqlDbType.VarChar);
            clienteTelefono.Value = cliente.clienteTelefono;
            SqlParameter clienteMail = cmd.Parameters.Add("@clienteMail", SqlDbType.VarChar);
            clienteMail.Value = cliente.clienteMail;
            SqlParameter clienteEstado = cmd.Parameters.Add("@clienteEstado", SqlDbType.VarChar);
            clienteEstado.Value = cliente.clienteEstado;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataSet ListarClientes()
        {
            DataSet clientesList = new DataSet();
            SqlCommand cmd = new SqlCommand("ListarClientes", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(clientesList);
            con.Close();
            return clientesList;
        }

        public Clientes BuscarCliente(int clienteId)
        {
            Clientes cliente = new Clientes();
            con.Open();
            DataTable dtCliente = new DataTable();

            SqlCommand cmd = new SqlCommand("BuscarCliente", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter clientId = cmd.Parameters.Add("@clienteId", SqlDbType.Int);
            clientId.Value = clienteId;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtCliente);
            con.Close();

            foreach (DataRow data in dtCliente.Rows)
            {
                cliente.clienteApellido = data["clienteApellido"].ToString();
                cliente.clienteNombre = data["clienteNombre"].ToString();
                cliente.clienteDni = int.Parse(data["clienteDni"].ToString());
                cliente.clienteFechaNacimiento = DateTime.Parse(data["clienteFechaNacimiento"].ToString());
                cliente.clienteDomicilio = data["clienteDomicilio"].ToString();
                cliente.clienteTelefono = data["clienteTelefono"].ToString();
                cliente.clienteMail = data["clienteMail"].ToString();
                cliente.clienteEstado = int.Parse(data["clienteEstado"].ToString());
            }
            
            con.Close();
            return cliente;
        }

        public void ModificarCliente(Clientes clientes)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ModificarCliente", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter clienteId = cmd.Parameters.Add("@clienteId", SqlDbType.VarChar);
            clienteId.Value = clientes.clienteId;
            SqlParameter clienteApellido = cmd.Parameters.Add("@clienteApellido", SqlDbType.VarChar);
            clienteApellido.Value = clientes.clienteApellido;
            SqlParameter clienteNombre = cmd.Parameters.Add("@clienteNombre", SqlDbType.VarChar);
            clienteNombre.Value = clientes.clienteNombre;
            SqlParameter clienteDni = cmd.Parameters.Add("@clienteDni", SqlDbType.Int);
            clienteDni.Value = clientes.clienteDni;
            SqlParameter clienteFechaNacimiento = cmd.Parameters.Add("@clienteFechaNacimiento", SqlDbType.DateTime);
            clienteFechaNacimiento.Value = clientes.clienteFechaNacimiento;
            SqlParameter clienteDomicilio = cmd.Parameters.Add("@clienteDomicilio", SqlDbType.VarChar);
            clienteDomicilio.Value = clientes.clienteDomicilio;
            SqlParameter clienteTelefono = cmd.Parameters.Add("@clienteTelefono", SqlDbType.VarChar);
            clienteTelefono.Value = clientes.clienteTelefono;
            SqlParameter clienteMail = cmd.Parameters.Add("@clienteMail", SqlDbType.VarChar);
            clienteMail.Value = clientes.clienteMail;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void BorrarCliente(int clienteId)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EliminarCliente", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter clientId = cmd.Parameters.Add("@clienteId", SqlDbType.Int);
            clientId.Value = clienteId;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataSet LlenarComboCliente()
        {
            DataSet clientesList = new DataSet();

            con.Open();
            SqlCommand cmd = new SqlCommand("CargarComboCliente", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(clientesList);
            con.Close();
            return clientesList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Repositorio
{
    public class PolizaRepo
    {
        public static string conexion = ConfigurationManager.ConnectionStrings["seguros"].ConnectionString;
        SqlConnection con = new SqlConnection(conexion);
        public void Guardar(Polizas poliza)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("InsertarPoliza", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter vehiculoId = cmd.Parameters.Add("@vehiculoId", SqlDbType.VarChar);
            vehiculoId.Value = poliza.vehiculoId;
            SqlParameter clienteId = cmd.Parameters.Add("@clienteId", SqlDbType.VarChar);
            clienteId.Value = poliza.clienteId;
            SqlParameter polizaFechaAlta = cmd.Parameters.Add("@polizaFechaAlta", SqlDbType.VarChar);
            polizaFechaAlta.Value = poliza.polizaFechaAlta;
            SqlParameter polizaFechaVigencia = cmd.Parameters.Add("@polizaFechaVigencia", SqlDbType.VarChar);
            polizaFechaVigencia.Value = poliza.polizaFechaVigencia;
            SqlParameter polizaFechaBaja = cmd.Parameters.Add("@polizaFechaBaja", SqlDbType.VarChar);
            polizaFechaBaja.Value = poliza.polizaFechaBaja;
            SqlParameter companiaId = cmd.Parameters.Add("@companiaId", SqlDbType.VarChar);
            companiaId.Value = poliza.companiaId;
            SqlParameter polizaEstado = cmd.Parameters.Add("@polizaEstado", SqlDbType.VarChar);
            polizaEstado.Value = poliza.polizaEstado;
            SqlParameter polizaNumero = cmd.Parameters.Add("@polizaNumero", SqlDbType.VarChar);
            polizaNumero.Value = poliza.polizaNumero;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void BajaPoliza(int polizaId)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EliminarPoliza", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter polizId = cmd.Parameters.Add("@polizaId", SqlDbType.Int);
            polizId.Value = polizaId;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Modificar(Polizas poliza)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ModificarPoliza", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter polizaId = cmd.Parameters.Add("@polizaId", SqlDbType.VarChar);
            polizaId.Value = poliza.polizaId;
            SqlParameter vehiculoId = cmd.Parameters.Add("@vehiculoId", SqlDbType.VarChar);
            vehiculoId.Value = poliza.vehiculoId;
            SqlParameter clienteId = cmd.Parameters.Add("@clienteId", SqlDbType.VarChar);
            clienteId.Value = poliza.clienteId;
            SqlParameter polizaFechaVigencia = cmd.Parameters.Add("@polizaFechaVigencia", SqlDbType.VarChar);
            polizaFechaVigencia.Value = poliza.polizaFechaVigencia;
            SqlParameter polizaFechaBaja = cmd.Parameters.Add("@polizaFechaBaja", SqlDbType.VarChar);
            polizaFechaBaja.Value = poliza.polizaFechaBaja;
            SqlParameter companiaId = cmd.Parameters.Add("@companiaId", SqlDbType.VarChar);
            companiaId.Value = poliza.companiaId;
            SqlParameter polizaEstado = cmd.Parameters.Add("@polizaEstado", SqlDbType.VarChar);
            polizaEstado.Value = poliza.polizaEstado;
            SqlParameter polizaNumero = cmd.Parameters.Add("@polizaNumero", SqlDbType.VarChar);
            polizaNumero.Value = poliza.polizaNumero;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public Polizas LlenarObjetoPoliza(int? polizaId)
        {
            Polizas poliza = new Polizas();
            con.Open();
            DataTable dtPoliza = new DataTable();

            SqlCommand cmd = new SqlCommand("BuscarPoliza", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter polizId = cmd.Parameters.Add("@polizaId", SqlDbType.Int);
            polizId.Value = polizaId;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtPoliza);
            con.Close();


            foreach (DataRow data in dtPoliza.Rows)
            {
                poliza.vehiculoId = int.Parse(data["vehiculoId"].ToString());
                poliza.clienteId = int.Parse(data["clienteId"].ToString());
                poliza.polizaFechaAlta = DateTime.Parse(data["polizaFechaAlta"].ToString());
                poliza.polizaFechaVigencia = DateTime.Parse(data["polizaFechaVigencia"].ToString());
                poliza.polizaFechaBaja = DateTime.Parse(data["polizaFechaBaja"].ToString());
                poliza.companiaId = int.Parse(data["companiaId"].ToString());
                poliza.polizaEstado = int.Parse(data["polizaEstado"].ToString());
                poliza.polizaNumero = data["polizaNumero"].ToString();
            }
            con.Close();
            return poliza;
        }



        public DataTable ListarPolizas()
        {
            con.Open();
            DataTable dtListarPolizas = new DataTable();
            SqlCommand cmd = new SqlCommand("ListarPolizas", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtListarPolizas);
            con.Close();
            return dtListarPolizas;
        }
    }
}

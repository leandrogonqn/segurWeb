using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Dominio;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Repositorio
{
    public class VehiculosRepo
    {
        public static string conexion = ConfigurationManager.ConnectionStrings["seguros"].ConnectionString;
        SqlConnection con = new SqlConnection(conexion);
        public void GuardarVehiculos(Vehiculos vehiculo)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("InsertarVehiculo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter vehiculoDominio = cmd.Parameters.Add("@vehiculoDominio", SqlDbType.VarChar);
            vehiculoDominio.Value = vehiculo.vehiculoDominio;
            SqlParameter vehiculoAnio = cmd.Parameters.Add("@vehiculoAnio", SqlDbType.VarChar);
            vehiculoAnio.Value = vehiculo.vehiculoAnio;
            SqlParameter vehiculoNumeroChasis = cmd.Parameters.Add("@vehiculoNumeroChasis", SqlDbType.VarChar);
            vehiculoNumeroChasis.Value = vehiculo.vehiculoNumeroChasis;
            SqlParameter vehiculoNumeroMotor = cmd.Parameters.Add("@vehiculoNumeroMotor", SqlDbType.VarChar);
            vehiculoNumeroMotor.Value = vehiculo.vehiculoNumeroMotor;
            SqlParameter modeloId = cmd.Parameters.Add("@modeloId", SqlDbType.VarChar);
            modeloId.Value = vehiculo.modeloId;
            SqlParameter vehiculoEstado = cmd.Parameters.Add("@vehiculoEstado", SqlDbType.VarChar);
            vehiculoEstado.Value = vehiculo.vehiculoEstado;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ModificarVehiculo(Vehiculos vehiculo)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ModificarVehiculo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter vehiculoId = cmd.Parameters.Add("@vehiculoId", SqlDbType.VarChar);
            vehiculoId.Value = vehiculo.vehiculoId;
            SqlParameter vehiculoDominio = cmd.Parameters.Add("@vehiculoDominio", SqlDbType.VarChar);
            vehiculoDominio.Value = vehiculo.vehiculoDominio;
            SqlParameter vehiculoAnio = cmd.Parameters.Add("@vehiculoAnio", SqlDbType.VarChar);
            vehiculoAnio.Value = vehiculo.vehiculoAnio;
            SqlParameter vehiculoNumeroChasis = cmd.Parameters.Add("@vehiculoNumeroChasis", SqlDbType.VarChar);
            vehiculoNumeroChasis.Value = vehiculo.vehiculoNumeroChasis;
            SqlParameter vehiculoNumeroMotor = cmd.Parameters.Add("@vehiculoNumeroMotor", SqlDbType.VarChar);
            vehiculoNumeroMotor.Value = vehiculo.vehiculoNumeroMotor;
            SqlParameter modeloId = cmd.Parameters.Add("@modeloId", SqlDbType.VarChar);
            modeloId.Value = vehiculo.modeloId;
            SqlParameter vehiculoEstado = cmd.Parameters.Add("@vehiculoEstado", SqlDbType.VarChar);
            vehiculoEstado.Value = vehiculo.vehiculoEstado;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void BorrarVehiculo(int vehiculoId)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EliminarVehiculo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter vehiculId = cmd.Parameters.Add("@vehiculoId", SqlDbType.Int);
            vehiculId.Value = vehiculoId;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public Vehiculos BuscarVehiculo(int? vehiculoId)
        {
            Vehiculos vehiculo = new Vehiculos();
            con.Open();
            DataTable dtVehiculo = new DataTable();
            
            SqlCommand cmd = new SqlCommand("BuscarVehiculo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter vehiculId = cmd.Parameters.Add("@vehiculoId", SqlDbType.Int);
            vehiculId.Value = vehiculoId;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtVehiculo);
            con.Close();


            foreach (DataRow data in dtVehiculo.Rows)
            {
                vehiculo.vehiculoId = int.Parse(vehiculoId.ToString());
                vehiculo.vehiculoDominio = data["vehiculoDominio"].ToString();
                vehiculo.vehiculoAnio = int.Parse(data["vehiculoAnio"].ToString());
                vehiculo.vehiculoNumeroChasis = data["vehiculoNumeroChasis"].ToString();
                vehiculo.vehiculoNumeroMotor = data["vehiculoNumeroMotor"].ToString();
                vehiculo.modeloId = int.Parse(data["modeloId"].ToString());
                vehiculo.vehiculoEstado = int.Parse(data["vehiculoEstado"].ToString());
            }



            con.Close();
    
            return vehiculo;
        }

        public DataSet CargarComboVehiculo()
        {
            DataSet dtComboVehiculo = new DataSet();

            con.Open();
            SqlCommand cmd = new SqlCommand("CargarComboVehiculo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtComboVehiculo);
            con.Close();
            return dtComboVehiculo;
        }

        public DataSet ListarVehiculos()
        {
            con.Open();
            DataSet dtListarVehiculos = new DataSet();
            SqlCommand cmd = new SqlCommand("ListarVehiculos", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtListarVehiculos);
            con.Close();
            return dtListarVehiculos;
        }

    }
}

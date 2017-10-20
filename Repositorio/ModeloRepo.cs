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
    public class ModeloRepo
    {
        public static string conexion = ConfigurationManager.ConnectionStrings["seguros"].ConnectionString;
        SqlConnection con = new SqlConnection(conexion);
        public DataSet CargarComboModelo(int marcaId)
        {
            con.Open();
            DataSet dtListarModelos = new DataSet();
            SqlCommand cmd = new SqlCommand("CargarComboModelo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter marcId = cmd.Parameters.Add("@marcaId", SqlDbType.Int);
            marcId.Value = marcaId;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtListarModelos);
            con.Close();
            return dtListarModelos;
        }

        public Modelos BuscarModelo(int? modeloId)
        {
            Modelos modelos = new Modelos();
            con.Open();
            DataTable dtModelo = new DataTable();
            SqlCommand cmd = new SqlCommand("BuscarModelo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter modelId = cmd.Parameters.Add("@modeloId", SqlDbType.Int);
            modelId.Value = modeloId;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtModelo);
            con.Close();


            foreach (DataRow data in dtModelo.Rows)
            {
                modelos.modeloId = int.Parse(modeloId.ToString());
                modelos.modeloDescripcion = data["modeloDescripcion"].ToString();
                modelos.marcaId = int.Parse(data["marcaId"].ToString());
                modelos.tipoVehiculoId = int.Parse(data["tipoVehiculoId"].ToString());
                modelos.modeloEstado = int.Parse(data["modeloEstado"].ToString());
            }

            con.Close();
            return modelos;
        }
    }
}

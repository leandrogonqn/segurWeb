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
    public class MarcaRepo
    {
        public static string conexion = ConfigurationManager.ConnectionStrings["seguros"].ConnectionString;
        SqlConnection con = new SqlConnection(conexion);
        public DataSet CargarComboMarca()
        {
            con.Open();
            DataSet dtListarMarcas = new DataSet();
            SqlCommand cmd = new SqlCommand("CargarComboMarca", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtListarMarcas);
            con.Close();
            return dtListarMarcas;
        }

        public Marcas BuscarMarca(int? marcaId)
        {
            Marcas marcas = new Marcas();
            con.Open();
            DataTable dtMarcas = new DataTable();
            SqlCommand cmd = new SqlCommand("BuscarMarca", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter marcId = cmd.Parameters.Add("@marcaId", SqlDbType.Int);
            marcId.Value = marcaId;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtMarcas);
            con.Close();


            foreach (DataRow data in dtMarcas.Rows)
            {
                marcas.marcaId = int.Parse(marcaId.ToString());
                marcas.marcaDescripcion = data["marcaDescripcion"].ToString();
                marcas.marcaEstado = int.Parse(data["marcaEstado"].ToString());
            }
            
            con.Close();
            return marcas;
        }
    }
}

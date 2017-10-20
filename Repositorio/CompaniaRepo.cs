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
    public class CompaniaRepo
    {
        public static string conexion = ConfigurationManager.ConnectionStrings["seguros"].ConnectionString;
        SqlConnection con = new SqlConnection(conexion);
        public DataSet LlenarComboCompanias()
        {
            List<Companias> companiasList = new List<Companias>();

            con.Open();
            DataSet dtCompanias = new DataSet();
            SqlCommand cmd = new SqlCommand("CargarComboCompania", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtCompanias);
            con.Close();
            return dtCompanias;
        }
    }
}

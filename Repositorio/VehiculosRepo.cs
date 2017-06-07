using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Dominio;
using System.Data;

namespace Repositorio
{
    public class VehiculosRepo
    {
        public void GuardarVehiculos(Vehiculos vehiculo)
        {
            using (segurosEntities context = new segurosEntities())
            {
                context.Vehiculos.Add(vehiculo);
                context.SaveChanges();
            }
        }

        public IQueryable<Vehiculos> listarVehiculos()
        {
            using (segurosEntities context = new segurosEntities())
            {
                DataTable dt = new DataTable();

                var contrat = from Vehiculos in context.Vehiculos select Vehiculos;

                //conexion.ConnectionString = datosConexion;

                //conexion.Open();

                //string query = "select * from Personas inner join Turnos on Turnos.personaId = Personas.personasId";

                //SqlCommand cmd = new SqlCommand(query, conexion);
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                //da.Fill(dt);
                //conexion.Close();
            }
            return null;

        }
    }
}

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

        public List<Vehiculos> listarVehiculos()
        {
            List<Vehiculos> vehiculosList = new List<Vehiculos>();

            using (var context = new segurosEntities())
            {
                var query = from v in context.Vehiculos select v;
                foreach (var item in query)
                {
                    vehiculosList.Add(item);
                }

            }
            return vehiculosList;

        }

    }
}

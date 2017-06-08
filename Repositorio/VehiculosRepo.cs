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

        public List<Vehiculos> LlenarComboVehiculo()
        {
            List<Vehiculos> vehiculoList = new List<Vehiculos>();

            using (var context = new segurosEntities())
            {

                var query = from c in context.Vehiculos
                            select c;
                foreach (var item in query)
                {
                    vehiculoList.Add(item);
                }

            }
            return vehiculoList;
        }

        public List<Vehiculos> ListarVehiculos()
        {
            List<Vehiculos> vehiculoList = new List<Vehiculos>();
            using (var context = new segurosEntities())
            {

                var query = from c in context.Vehiculos
                            select c;
                foreach (var item in query)
                {
                    vehiculoList.Add(item);
                }

            }
            return vehiculoList;
        }
    }
}

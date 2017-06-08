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

<<<<<<< HEAD
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

=======
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
>>>>>>> desarrollo
        }

    }
}

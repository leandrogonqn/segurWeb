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

        public void ModificarVehiculo(Vehiculos vehiculos)
        {
            using (segurosEntities context = new segurosEntities())
            {
                Vehiculos vehic = (from v in context.Vehiculos
                                   where v.vehiculoId == vehiculos.vehiculoId
                                   select v).FirstOrDefault();
                vehic.vehiculoDominio = vehiculos.vehiculoDominio;
                vehic.vehiculoAnio = vehiculos.vehiculoAnio;
                vehic.modeloId = vehiculos.modeloId;
                vehic.vehiculoNumeroChasis = vehiculos.vehiculoNumeroChasis;
                vehic.vehiculoNumeroMotor = vehiculos.vehiculoNumeroMotor;
                context.SaveChanges();
            }
        }

        public void BorrarVehiculo(int vehiculoId)
        {
            using (segurosEntities context = new segurosEntities())
            {
                Vehiculos vehic = (from v in context.Vehiculos
                                   where v.vehiculoId == vehiculoId
                                   select v).FirstOrDefault();
                vehic.vehiculoEstado = 0;
                context.SaveChanges();
            }
        }

        public Vehiculos BuscarVehiculo(int vehiculoId)
        {
            Vehiculos vehiculo;
            using (segurosEntities context = new segurosEntities())
            {

                vehiculo = (from v in context.Vehiculos
                            where v.vehiculoId == vehiculoId
                            select v).FirstOrDefault();

            }
            return vehiculo;
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

        public List<object> ListarVehiculos()
        {
            List<object> vehiculoList = new List<object>();
            using (var context = new segurosEntities())
            {

                var query = from c in context.Vehiculos
                            join m in context.Modelos on c.modeloId equals m.modeloId
                            join ma in context.Marcas on m.marcaId equals ma.marcaId
                            join t in context.TipoVehiculos on m.tipoVehiculoId equals t.tipoVehiculosId
                            where c.vehiculoEstado == 1
                            select new
                            {   
                                c.vehiculoId,
                                c.vehiculoDominio,
                                c.vehiculoAnio,
                                ma.marcaDescripcion,
                                m.modeloDescripcion,
                                c.vehiculoNumeroChasis,
                                c.vehiculoNumeroMotor, 
                                t.tipoVehiculoDescripcion
                            };
                foreach (var item in query)
                {
                    vehiculoList.Add(item);
                }
                
            }
            return vehiculoList;
        }

    }
}

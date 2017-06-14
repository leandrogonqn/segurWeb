using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Repositorio
{
    public class PolizaRepo
    {
        public void Guardar(Polizas poliza)
        {
            using (segurosEntities context = new segurosEntities())
            {
                context.Polizas.Add(poliza);
                context.SaveChanges();
            };
        }

        public void BajaPoliza(int polizaId)
        {
            using (segurosEntities context = new segurosEntities())
            {
                Polizas poliza = (from p in context.Polizas
                                   where p.polizaId == polizaId
                                  select p).FirstOrDefault();
                poliza.polizaEstado = 0;
                poliza.polizaFechaBaja = DateTime.Now;
                context.SaveChanges();
            }
        }

        public List<object> ListarPolizas()
        {
            List<object> listaPolizas = new List<object>();
            using (var context = new segurosEntities())
            {

               var polizas = from p in context.Polizas
                                  join v in context.Vehiculos on p.vehiculoId equals v.vehiculoId
                                  join c in context.Clientes on p.clienteId equals c.clienteId
                             //where p.polizaEstado == 1
                             select new{v.vehiculoDominio , c.clienteApellido,c.clienteNombre,p.polizaNumero ,p.polizaFechaVigencia,p.polizaId , p.polizaEstado } ;

                foreach (var item in polizas)
                {
                    listaPolizas.Add(item);
                }              
            }
            return listaPolizas;
        }
    }
}

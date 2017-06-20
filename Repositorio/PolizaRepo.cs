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

        public void Modificar(Polizas poliza)
        {
            using (segurosEntities context = new segurosEntities())
            {
                Polizas polizaa = (from p in context.Polizas
                                   where p.polizaId == poliza.polizaId
                                   select p).FirstOrDefault();

                polizaa.polizaNumero = poliza.polizaNumero;
                polizaa.polizaFechaVigencia = poliza.polizaFechaVigencia;
                polizaa.clienteId = poliza.clienteId;
                polizaa.vehiculoId = poliza.vehiculoId;
                polizaa.companiaId = poliza.companiaId;
                context.SaveChanges();
            }
        }

        public Polizas LlenarObjetoPoliza(int? polizaId)
        {
            Polizas poliza;
            using (segurosEntities context = new segurosEntities())
            {

                poliza = (from p in context.Polizas
                          where p.polizaId == polizaId
                          select p).FirstOrDefault();

            }
            return poliza;
        }



        public List<object> ListarPolizas()
        {
            List<object> listaPolizas = new List<object>();
            using (var context = new segurosEntities())
            {   

                var polizas = from p in context.Polizas
                              join c in context.Clientes on p.clienteId equals c.clienteId
                              join v in context.Vehiculos on p.vehiculoId equals v.vehiculoId
                              join m in context.Modelos on v.modeloId equals m.modeloId
                              join ma in context.Marcas on m.marcaId equals ma.marcaId
                              where p.polizaEstado == 1
                              select new
                              {
                                  p.polizaNumero,
                                  p.polizaFechaVigencia,
                                  p.polizaId,
                                  c.clienteApellido,
                                  c.clienteNombre,
                                  v.vehiculoDominio,
                                  ma.marcaDescripcion,
                                  m.modeloDescripcion
                              };

                foreach (var item in polizas)
                {
                    listaPolizas.Add(item);
                }
            }
            return listaPolizas;
        }
    }
}

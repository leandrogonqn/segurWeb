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
            using (segurosEntities seg = new segurosEntities())
            {
                seg.Polizas.Add(poliza);
                seg.SaveChanges();
            };
        }


    }
}

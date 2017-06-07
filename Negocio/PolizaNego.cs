using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;

namespace Negocio
{
    public class PolizaNego
    {
        PolizaRepo polizaRepo = new PolizaRepo();
        public void Guardar(Polizas poliza)
        {
            polizaRepo.Guardar(poliza);
        }
    }
}

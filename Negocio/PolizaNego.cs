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
        public List<object> ListarPoliza()
        {
            return polizaRepo.ListarPolizas();
        }

        public void BajaPoliza(int polizaId)
        {
            polizaRepo.BajaPoliza(polizaId);
        }
    }

}

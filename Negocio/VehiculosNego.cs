using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;
using System.Data;

namespace Negocio
{
    public class VehiculosNego
    {
        VehiculosRepo vehiculosRepo = new VehiculosRepo();

        public void GuardarVehiculos(Vehiculos vehiculo)
        {
            vehiculosRepo.GuardarVehiculos(vehiculo);
        }
        
        public List<Vehiculos> CargarComboVehiculo()
        {
            return vehiculosRepo.LlenarComboVehiculo();
        }

        public List<Vehiculos> ListarVehiculos()
        {
            return vehiculosRepo.ListarVehiculos();
        }
    }
}

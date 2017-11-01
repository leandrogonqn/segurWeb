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
        
        public DataSet CargarComboVehiculo()
        {
            return vehiculosRepo.CargarComboVehiculo();
        }

        public DataTable ListarVehiculos()
        {
            return vehiculosRepo.ListarVehiculos();
        }

        public Vehiculos BuscarVehiculo(int vehiculoId)
        {
            return vehiculosRepo.BuscarVehiculo(vehiculoId);
        }

        public void ModificarVehiculo(Vehiculos vehiculos)
        {
            vehiculosRepo.ModificarVehiculo(vehiculos);
        }

        public void BorrarVehiculo(int vehiculoId)
        {
            vehiculosRepo.BorrarVehiculo(vehiculoId);
        }
    }
}

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
    public class MarcaNego
    {
        MarcaRepo marcaRepo = new MarcaRepo();

        public DataSet CargarComboMarca()
        {
            return marcaRepo.CargarComboMarca();
        }

        public Marcas BuscarMarca(int? marcaId)
        {
            return marcaRepo.BuscarMarca(marcaId);
        }
    }
}

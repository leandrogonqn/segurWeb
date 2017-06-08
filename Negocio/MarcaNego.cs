using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;

namespace Negocio
{
    public class MarcaNego
    {
        MarcaRepo marcaRepo = new MarcaRepo();

        public List<Marcas> CargarComboMarca()
        {
            return marcaRepo.CargarComboMarca();
        }
    }
}

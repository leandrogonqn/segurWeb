using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;

namespace Negocio
{
    public class ModeloNego
    {
        ModeloRepo modeloRepo = new ModeloRepo();

        public List<Modelos> CargarComboModelo()
        {
            return modeloRepo.CargarComboModelo();
        }
    }
}

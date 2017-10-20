using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio;
using Dominio;
using System.Data;


namespace Negocio
{
    public class CompaniaNego
    {
        CompaniaRepo companiaRepo = new CompaniaRepo();

        public DataSet LlenarComboCompanias()
        {
            return companiaRepo.LlenarComboCompanias();
        }
    }
}

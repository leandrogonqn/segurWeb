using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio;
using Dominio;


namespace Negocio
{
    public class CompaniaNego
    {
        CompaniaRepo companiaRepo = new CompaniaRepo();

        public List<Companias> LlenarComboCompanias()
        {
            return companiaRepo.LlenarComboCompanias();
        }
    }
}

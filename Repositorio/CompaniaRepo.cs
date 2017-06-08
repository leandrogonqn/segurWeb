using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Repositorio
{
    public class CompaniaRepo
    {
        public List<Companias> LlenarComboCompanias()
        {
            List<Companias> companiasList = new List<Companias>();

            using (var context = new segurosEntities())
            {

                var query = from c in context.Companias
                            select c;
                foreach (var item in query)
                {
                    companiasList.Add(item);
                }

            }
            return companiasList;
        }
    }
}

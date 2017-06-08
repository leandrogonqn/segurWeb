using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Repositorio
{
    public class MarcaRepo
    {
        public List<Marcas> CargarComboMarca()
        {
            List<Marcas> marcasList = new List<Marcas>();
            using (var context = new segurosEntities())
            {

                var query = from c in context.Marcas
                            select c;
                foreach (var item in query)
                {
                    marcasList.Add(item);
                }

            }
            return marcasList;
        }
    }
}

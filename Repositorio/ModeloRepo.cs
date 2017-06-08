using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Repositorio
{
    public class ModeloRepo
    {
        public List<Modelos> CargarComboModelo()
        {
            List<Modelos> modelosList = new List<Modelos>();
            using (var context = new segurosEntities())
            {

                var query = from c in context.Modelos
                            select c;
                foreach (var item in query)
                {
                    modelosList.Add(item);
                }

            }
            return modelosList;
        }
    }
}

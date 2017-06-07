using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class AltaPolizas : System.Web.UI.Page
    {
        ClientesNego clienteNego = new ClientesNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }



        private void Guardar()
        {
            Polizas poliza = new Polizas();
            PolizaNego polizaNego = new PolizaNego();

            poliza.clienteId = 3;
            poliza.vehiculoId = 1;
            poliza.companiaId = 1;
            poliza.polizaFechaAlta = DateTime.Now;
            poliza.polizaFechaVigencia = Convert.ToDateTime(dtFechaVigencia.Value);
           poliza.polizaFechaBaja = DateTime.Now;

            polizaNego.Guardar(poliza);
        }

        private void CargarCombos()
        {
            ddlCliente.DataSource = clienteNego.ListarClientes();
            ddlCliente.DataTextField = "clienteApellido";
            ddlCliente.DataValueField = "clienteId";
            ddlCliente.DataBind();
            ddlCliente.Items.Insert(0, "Seleccione un cliente");
        }


        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
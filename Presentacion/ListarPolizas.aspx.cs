using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace Presentacion
{
    public partial class ListarPolizas : System.Web.UI.Page
    {
        PolizaNego polizaNego = new PolizaNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
        }

        protected void gdvPoliza_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "bntEliminar")
            {
                int polizaId = int.Parse(e.CommandArgument.ToString());
                polizaNego.BajaPoliza(polizaId);
            }

            if (e.CommandName == "btnEditar")
            {
                int polizaId = int.Parse(e.CommandArgument.ToString());
                string pagina = "ModificarPolizas.aspx?polizaId=" + polizaId;
                Response.Redirect(pagina);
            }
        }


        public string pasarAJson()
        {
            string json = JsonConvert.SerializeObject(polizaNego.ListarPoliza(), Formatting.Indented);
            return json;
        }
    }
}
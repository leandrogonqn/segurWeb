using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class ListarPolizas : System.Web.UI.Page
    {
        PolizaNego polizaNego = new PolizaNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            CargarGrilla();
        }

        protected void gdvPoliza_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "bntEliminar")
            {
                int polizaId = int.Parse(e.CommandArgument.ToString());
                polizaNego.BajaPoliza(polizaId);
                CargarGrilla();
            }

            if (e.CommandName == "btnEditar")
            {
                int polizaId = int.Parse(e.CommandArgument.ToString());
                string pagina = "ModificarPolizas.aspx?polizaId=" + polizaId;
                Response.Redirect(pagina);
            }
        }


        private void CargarGrilla()
        {
            gdvPoliza.AutoGenerateColumns = false;
            gdvPoliza.DataSource = polizaNego.ListarPoliza();
            gdvPoliza.DataBind();

        }
    }
}
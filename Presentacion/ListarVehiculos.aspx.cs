using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using System.Data;

namespace Presentacion
{
    public partial class ListarVehiculos : System.Web.UI.Page
    {

        VehiculosNego vehiculosNego = new VehiculosNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            //CargarGrilla();
        }

        //private void CargarGrilla()
        //{
        //    gdvVehiculos.DataSource = vehiculosNego.ListarVehiculos();
        //    gdvVehiculos.DataBind();
        //}

        protected void gdvVehiculos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Modificar")
            {
                int vehiculoId = int.Parse(e.CommandArgument.ToString());
                string pagina = "ModificarVehiculos.aspx?vehiculoId=" + vehiculoId;
                Response.Redirect(pagina);
            }
        }
    }
}
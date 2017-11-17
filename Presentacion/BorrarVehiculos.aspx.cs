using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Presentacion
{
    public partial class BorrarVehiculos : System.Web.UI.Page
    {
        VehiculosNego vehiculoNego = new VehiculosNego();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            int vehiculoId = int.Parse(Request["vehiculoId"].ToString());
            vehiculoNego.BorrarVehiculo(vehiculoId);
            Response.Redirect("ListarVehiculos.aspx");
        }
    }
}
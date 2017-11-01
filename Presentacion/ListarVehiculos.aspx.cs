using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using System.Data;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace Presentacion
{
    public partial class ListarVehiculos : System.Web.UI.Page
    {

        VehiculosNego vehiculosNego = new VehiculosNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            
        }

        public string pasarAJson()
        {
            string json = JsonConvert.SerializeObject(vehiculosNego.ListarVehiculos(), Formatting.Indented);
            return json;
        }

        protected void gdvVehiculos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Modificar")
            {
                int vehiculoId = int.Parse(e.CommandArgument.ToString());
                string pagina = "ModificarVehiculos.aspx?vehiculoId=" + vehiculoId;
                Response.Redirect(pagina);
            }
            if (e.CommandName == "Borrar")
            {
                int vehiculoId = int.Parse(e.CommandArgument.ToString());
                vehiculosNego.BorrarVehiculo(vehiculoId);
            }
        }
    }
}
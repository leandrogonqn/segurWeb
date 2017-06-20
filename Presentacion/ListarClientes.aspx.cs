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
    public partial class ListarClientes : System.Web.UI.Page
    {
        ClientesNego clientesNego = new ClientesNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            CargarGrilla();
        }
        private void CargarGrilla()
        {
            gdvClientes.DataSource = clientesNego.ListarClientes();
            gdvClientes.DataBind();
        }

        protected void gdvClientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Modificar")
            {
                int clienteId = int.Parse(e.CommandArgument.ToString());
                string pagina = "ModificarCliente.aspx?clienteId=" + clienteId;
                Response.Redirect(pagina);
            }
            if (e.CommandName == "Borrar")
            {
                int clienteId = int.Parse(e.CommandArgument.ToString());
                clientesNego.BorrarCliente(clienteId);
                CargarGrilla();
            }
        }
    }
}